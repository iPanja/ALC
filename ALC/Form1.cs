using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using PushbulletSharp;
using PushbulletSharp.Models.Requests;

namespace ALC {
    public partial class Form1 : MetroFramework.Forms.MetroForm {
        public Process leagueProcess;
        public int plus = 2;
        public Timer timer = new Timer();
        public Timer monitorTimer = new Timer();
        public bool initiated = false;
        Image checkmark = Image.FromFile(Application.StartupPath + "/checkmark.png");
        Image x = Image.FromFile(Application.StartupPath + "/x.png");
        Color fPixel = Color.FromArgb(0, 133, 163, 164);
        Color bPixel = Color.FromArgb(0, 30, 37, 42);
        const int Press = 0x02;
        const int Unpress = 0x04;
        PushbulletClient pbClient;


        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowRect(IntPtr hWnd, ref Rect rect);
        [DllImport("user32.dll")]
        public static extern bool PrintWindow(IntPtr hWnd, IntPtr hdcBlt, int nFlags);
        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll", EntryPoint = "SetCursorPos")]
        private static extern bool SetCursorPos(int x, int y);
        [DllImport("user32.dll")]
        private static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        [StructLayout(LayoutKind.Sequential)]
        public struct Rect {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        public Form1() {
            InitializeComponent();
            timer.Tick += new EventHandler(move);
            timer.Interval = 3;
            monitorTimer.Tick += new EventHandler(scan);
            monitorTimer.Interval = 5000;
            pbCheckbox.Checked = Properties.Settings.Default.pbNotify;
            pbKeyTextbox.Text = Properties.Settings.Default.pbKey;
            pbKeyTextbox.Enabled = pbCheckbox.Checked;
        }

        //Events
        private void initiateButton_Click(object sender, EventArgs e) {
            if (!initiated) {
                toggleButton();
                if (stepFindClient()) {
                    locateClientPicture.Image = checkmark;
                    stepMonitorQueue();
                }else {
                    toggleButton();
                }
            }
            else {
                toggleButton();
            }
        }
        private void pbHelpButton_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("https://www.pushbullet.com/#settings/account");
        }
        private void pbKeyTextbox_TextChanged(object sender, EventArgs e) {
            Properties.Settings.Default.pbKey = pbKeyTextbox.Text;
            Properties.Settings.Default.Save();
        }
        private void pbCheckbox_CheckedChanged(object sender, EventArgs e) {
            Properties.Settings.Default.pbNotify = pbCheckbox.Checked;
            Properties.Settings.Default.Save();
            pbKeyTextbox.Enabled = pbCheckbox.Checked;
        }
        //Functions
        public bool stepFindClient() {
            Process temp = findProcess();
            if (temp == null) {
                showBalloon("Could not locate a single league instance", SystemIcons.Exclamation);
                return false;
            }
            else {
                leagueProcess = temp;
                return true;
            }
        }
        public void stepMonitorQueue() {
            //Initiate Progress Bar
            monitorQueuePicture.Image = checkmark;
            monitorTimer.Start();
        }
        void toggleButton() {
            if (initiated) {
                //The process has ended
                initiateButton.Text = "Initiate";
                timer.Stop();
                monitorTimer.Stop();
                locateClientPicture.Image = x;
                monitorQueuePicture.Image = x;
                insidePanel.Left = 0;
            }else {
                initiateButton.Text = "Cancel";
                timer.Start();
            }
            initiated = !initiated;
        }
        Process findProcess() {
            Process[] procs = Process.GetProcessesByName("leagueclientux");
            if (procs.Length != 1) {
                return null;
            }
            else {
                return procs[0];
            }
        }
        void showBalloon(string body, Icon icon) {
            NotifyIcon notifyIcon = new NotifyIcon();
            notifyIcon.Visible = true;
            notifyIcon.Icon = icon;

            notifyIcon.BalloonTipTitle = "Auto League Client";
            notifyIcon.BalloonTipText = body;
            notifyIcon.ShowBalloonTip(3000);
        }
        public void move(object sender, EventArgs e) {
            insidePanel.Left = insidePanel.Left + plus;
            if (insidePanel.Left > 385) {
                plus = -2;
            }
            else if (insidePanel.Left < 0) {
                plus = 2;
            }
        }
        public void scan(object sender, EventArgs e) {
            Tuple<Bitmap, Rect> values = CaptureScreenshot();
            Bitmap screenshot = values.Item1;
            Rect rect = values.Item2;
            //screenshot.Save(Application.StartupPath + "/Screenshot.png", ImageFormat.Png);
            int x = Convert.ToInt32(screenshot.Width / 2);
            int y = Convert.ToInt32(screenshot.Height * 0.75);
            Color pixel = screenshot.GetPixel(x, y);
            //Console.Out.WriteLine("A" + pixel.A + " R" + pixel.R + " G" + pixel.G + " B" + pixel.B);
            if(pixcmp(pixel, fPixel) || pixcmp(pixel, bPixel)) {
                //Accept the match
                Console.Out.WriteLine("Match found!"); 
                AcceptMatch(rect.left + x, rect.top + y);
                handleNotifications();
                toggleButton();
            }
        }
        public void AcceptMatch(int x, int y) {
            SetForegroundWindow(leagueProcess.MainWindowHandle);
            SetCursorPos(x, y);
            mouse_event(Press, 0, 0, 0, 0);
            mouse_event(Unpress, 0, 0, 0, 0);
        }
        public void pushNotification(string message, string pbKey) {
            if (pbClient == null) {
                pbClient = new PushbulletClient(pbKey);
            }
            if(pbClient.CurrentUsersInformation() == null) {
                showBalloon("Your Pushbullet key is invalid", SystemIcons.Error);
                return;
            }
            PushNoteRequest note = new PushNoteRequest {
                Title = "ALC",
                Body = message,
            };
            pbClient.PushNote(note);
        }
        public Tuple<Bitmap, Rect> CaptureScreenshot() {
            Rect rect = new Rect();
            GetWindowRect(leagueProcess.MainWindowHandle, ref rect);
            Bitmap bmp = new Bitmap(rect.right - rect.left, rect.bottom - rect.top, PixelFormat.Format32bppArgb);
            Graphics graphics = Graphics.FromImage(bmp);
            IntPtr bitmap = graphics.GetHdc();
            PrintWindow(leagueProcess.MainWindowHandle, bitmap, 0);
            graphics.ReleaseHdc(bitmap);
            graphics.Dispose();
            return Tuple.Create(bmp, rect);
        }
        public void handleNotifications() {
            string temp = pbKeyTextbox.Text;
            if (!string.IsNullOrWhiteSpace(temp) && pbCheckbox.Checked) {
                pushNotification("A match has been found!", pbKeyTextbox.Text);
            }
        }
        public bool pixcmp(Color p1, Color p2) {
            return p1.R == p2.R && p1.G == p2.G && p1.B == p2.B;
        }
    }
}
