using System;
using System.Collections.Generic;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AIUtils {

    public partial class AIUtils : Form {

        // VAM variables
        static String process = "AI";
        static VAMemory vam = null;
        IntPtr baseAddress = new IntPtr(0x0);

        String currentLevel = "";

        // used for changing UI elements inside a different thread
        public delegate void delUpdateUITextBox(string text);

        public AIUtils() {
            InitializeComponent();
        }

        private void AIUtils_Load(object sender, EventArgs e) {
            // Initiate levels
            refreshLevels();

            // VAMemory setup
            vam = new VAMemory(process);
            this.baseAddress = this.getBaseAddress("AI.exe");

            // Async thread to updateLabelValues
            ThreadStart threadStart = new ThreadStart(asyncTask);
            Thread updateThread = new Thread(threadStart);
            updateThread.IsBackground = true;
            updateThread.Start();
        }

        /*
         * this async task handels memory reading and the displaying of the coordinates
         */
        private void asyncTask() {
            while (true) {
                float playerX = readPlayerX();
                float playerY = readPlayerY();
                float playerZ = readPlayerZ();

                Level level = new Level(currentLevel, playerX, playerY, playerZ);
                Level calculatedLevel = LevelCalculation.calculateLevel(level);

                // write coordinated into the form fields
                delUpdateUITextBox delUpdateX = new delUpdateUITextBox(updatePlayerCoordinateX);
                textboxPlayerCoordinateX.BeginInvoke(delUpdateX, playerX.ToString());

                delUpdateUITextBox delUpdateY = new delUpdateUITextBox(updatePlayerCoordinateY);
                textboxPlayerCoordinateY.BeginInvoke(delUpdateY, playerY.ToString());

                delUpdateUITextBox delUpdateZ = new delUpdateUITextBox(updatePlayerCoordinateZ);
                textboxPlayerCoordinateZ.BeginInvoke(delUpdateZ, playerZ.ToString());

                delUpdateUITextBox delUpdateCalcX = new delUpdateUITextBox(updatePlayerCoordinateCalculatedX);
                textboxPlayerCoordinateCalculatedX.BeginInvoke(delUpdateCalcX, calculatedLevel.x.ToString());

                delUpdateUITextBox delUpdateCalcY = new delUpdateUITextBox(updatePlayerCoordinateCalculatedY);
                textboxPlayerCoordinateCalculatedY.BeginInvoke(delUpdateCalcY, calculatedLevel.y.ToString());

                delUpdateUITextBox delUpdateCalcZ = new delUpdateUITextBox(updatePlayerCoordinateCalculatedZ);
                textboxPlayerCoordinateCalculatedZ.BeginInvoke(delUpdateCalcZ, calculatedLevel.z.ToString());

                Thread.Sleep(100);
            }
        }

        /*
         * Refreshs the level combobox
         */
        public void refreshLevels() {
            comboboxLevels.SelectedIndex = -1;
            comboboxLevels.Items.Clear();

            List<String> levels = this.getLevels();
            foreach(var level in levels) {
                comboboxLevels.Items.Add(level);
            }
        }

        #region memory handling

        /*
         * Returns the base address of the game
         */
        public IntPtr getBaseAddress(string modulename) {
            IntPtr baseAddr = new IntPtr(0x0);

            Process[] processes = Process.GetProcessesByName(process);
            if(0 < processes.Length) {
                Process gameProcess = processes[0];
                if(gameProcess.ProcessName == "AI" && !gameProcess.HasExited) {
                    baseAddr = gameProcess.MainModule.BaseAddress;
                }
            }

            return baseAddr;
        }

        /*
         * Reads the x coordinate of the player
         */
        public float readPlayerX() {
            int staticPointer = 0x012F0C88;
            int offset0 = 0x24;
            int offset1 = 0x70;
            int offset2 = 0x0;
            int offset3 = 0x174;

            int addr = vam.ReadInt32((IntPtr)(this.baseAddress.ToInt32() + staticPointer));
            addr = vam.ReadInt32((IntPtr)(addr + offset0));
            addr = vam.ReadInt32((IntPtr)(addr + offset1));
            addr = vam.ReadInt32((IntPtr)(addr + offset2));
            float x = (float)vam.ReadFloat((IntPtr)(addr + offset3));

            return x;
        }

        /*
         * Reads the y coordinate of the player
         */
         public float readPlayerY() {
            int staticPointer = 0x012F0C88;
            int offset0 = 0x24;
            int offset1 = 0x70;
            int offset2 = 0x0;
            int offset3 = 0x178;

            int addr = vam.ReadInt32((IntPtr)(this.baseAddress.ToInt32() + staticPointer));
            addr = vam.ReadInt32((IntPtr)(addr + offset0));
            addr = vam.ReadInt32((IntPtr)(addr + offset1));
            addr = vam.ReadInt32((IntPtr)(addr + offset2));
            float y = (float)vam.ReadFloat((IntPtr)(addr + offset3));

            return y;
        }

        /*
         * Reads the z coordinate of the player
         */
        public float readPlayerZ() {
            int staticPointer = 0x012F0C88;
            int offset0 = 0x24;
            int offset1 = 0x70;
            int offset2 = 0x0;
            int offset3 = 0x17C;

            int addr = vam.ReadInt32((IntPtr)(this.baseAddress.ToInt32() + staticPointer));
            addr = vam.ReadInt32((IntPtr)(addr + offset0));
            addr = vam.ReadInt32((IntPtr)(addr + offset1));
            addr = vam.ReadInt32((IntPtr)(addr + offset2));
            float z = (float)vam.ReadFloat((IntPtr)(addr + offset3));

            return z;
        }

        #endregion memory handling

        #region form

        // Make window moveable
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void AIUtils_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        /*
         * Exit form on click
         */
        private void pictureboxExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        #endregion form

        #region asyncUiElements

        /* Update UI TextBoxes through a different Thread */
        private void updatePlayerCoordinateX(string text) {
            textboxPlayerCoordinateX.Text = text;
        }

        private void updatePlayerCoordinateY(string text) {
            textboxPlayerCoordinateY.Text = text;
        }

        private void updatePlayerCoordinateZ(string text) {
            textboxPlayerCoordinateZ.Text = text;
        }

        private void updatePlayerCoordinateCalculatedX(string text) {
            textboxPlayerCoordinateCalculatedX.Text = text;
        }

        private void updatePlayerCoordinateCalculatedY(string text) {
            textboxPlayerCoordinateCalculatedY.Text = text;
        }

        private void updatePlayerCoordinateCalculatedZ(string text) {
            textboxPlayerCoordinateCalculatedZ.Text = text;
        }

        #endregion asyncUiElements

        private void comboboxLevels_SelectedIndexChanged(object sender, EventArgs e) {
            currentLevel = (string)comboboxLevels.SelectedItem;
            changeFocus();
        }

        private List<String> getLevels() {
            List<String> levels = new List<String>() {
                "SCI_HOSPITAL_UPPER",
                "SCI_HOSPITAL_LOWER"
            };

            levels.Sort();
            
            return levels;
        }

        private void checkboxShowWindowOnTop_CheckedChanged(object sender, EventArgs e) {
            if(checkboxShowWindowOnTop.Checked) {
                AIUtils.ActiveForm.TopMost = true;
            } else {
                AIUtils.ActiveForm.TopMost = false;
            }
            changeFocus();
        }

        /*
         * Change focus to the headline so we do not have any annoying highlighting
         */
        private void changeFocus() {
            labelHeadline.Focus();
        }
    }

    public class Level {

        public String name;
        public float x;
        public float y;
        public float z;

        public Level() {}

        public Level(String levelname, float x, float y, float z) {
            this.name = levelname;
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
}
