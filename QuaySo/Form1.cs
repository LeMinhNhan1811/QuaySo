using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Timers.Timer;

namespace QuaySo
{
    public partial class Form1 : Form
    {
        /// Objects that have been declaration
        /// menuStrip1
        /// fontDialog1
        /// colorDialog
        /// openDialog
        /// drawShape1
        /// button1
        /// buttonSet
        /// timer

        bool isSaved = true;            //flag if user saved option
        bool isQuaySoEnable = false;
        bool isSelecting = false;       //flag if it is selecting
        bool isLoaded = false;          //flag if file is loaded
        bool isFullScreen = false;      //flag if it is in fullscreen mode
        bool isCleared = true;          //flag if it is cleared screen after selecting

        private string fileLocation;        // Location of previous file
        private string backgroundLocation;  // location of background image, ex: "D:\image.bmp"
        private string soundSelectingLoc;   // location of sound selecting
        private string soundWinLoc;         // location of sound when show winner
        SoundPlayer soundSelecting;
        SoundPlayer soundWin;

        /// list load from file, 2D string Array, 0 is name, 1 is company
        List<string[]> database;

        /// Listbox content Name data, which was loaded from file
        ListBox listBox2 = new ListBox();

        /// Timer interval, calculate by milisec
        private int interval = 100;
        /// Time of slow-down  process
        private int lastshownTime = 3000;
        private int lastshownCounter = 0;
        private int lastshownCounterLimit = 0;

        /// Color used for render
        private Color mainFillColor = Color.Orange;
        private Color mainOutlineColor = Color.OrangeRed;
        private Color mainShadowColor = Color.Black;

        private Color selectFillColor = Color.GhostWhite;
        private Color selectOutlineColor = Color.Gray;
        private Color selectShadowColor = Color.Black;

        /// Other option of sofware
        private Font font1;
        private Font font2;
        private Font font3;
        private int outlineStrength;

        /// Draw Shape option
        private float drawShape1Ratio = 2.5f / 5.0f;
        private float drawShape2Ratio = 1.0f / 5.0f;
        private float drawShape3Ratio = 1.0f / 5.0f;

        /**
         * @brief enable buffer for a Control
         * 
         * param[in] c controler need double buffer for rendering
         */
        public static void SetDoubleBuffered(System.Windows.Forms.Control c)
        {
            if (System.Windows.Forms.SystemInformation.TerminalServerSession)
                return;

            System.Reflection.PropertyInfo aProp =
                  typeof(System.Windows.Forms.Control).GetProperty(
                        "DoubleBuffered",
                        System.Reflection.BindingFlags.NonPublic |
                        System.Reflection.BindingFlags.Instance);

            aProp.SetValue(c, true, null);
        }

        /**
         * @brief function to call enable double buffer in all current form
         */
        private void SetAllDoubleBuffer()
        {
            this.DoubleBuffered = true;
            SetDoubleBuffered(panel1);
            SetDoubleBuffered(menuStrip1);
            SetDoubleBuffered(drawShape1);
            SetDoubleBuffered(drawShape2);
            SetDoubleBuffered(drawShape3);
        }

        /// Form1
        public Form1()
        {
            InitializeComponent();
        }

        /**
         * @brief Form1_Load event, which will show current GUI
         */
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadOption();
            timer.Interval = interval;

            this.FormClosing += Form1_FormClosing;

            if (File.Exists(backgroundLocation) == true)
            {
                panel1.BackgroundImage =
                Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, backgroundLocation));
            }

            // Show Outline
            txtBoxOutLineStrength.Text = drawShape1.BoderPenWidth.ToString();
            // Show Speed
            txtBoxSpeed.Text = (10000 / interval).ToString();
            // Show lastshownSlowDown Time
            txtBoxLasttimeSlowDown.Text = lastshownTime.ToString();

            soundSelecting = new SoundPlayer(soundSelectingLoc);
            soundWin = new SoundPlayer(soundWinLoc);

            drawShape1.lineAlignment = StringAlignment.Far;

            SetAllDoubleBuffer();
        }

        /**
         * @brief Form1_Resize event, which will re-position, resize all rendering controler
         */
        private void Form1_Resize(object sender, EventArgs e)
        {
            drawShape1.Size = new Size(panel1.Size.Width, (int)(panel1.Size.Height * drawShape1Ratio));

            drawShape2.Location = new Point(drawShape1.Location.X, drawShape1.Location.Y + drawShape1.Size.Height);
            drawShape2.Size = new Size(panel1.Size.Width, (int)(panel1.Size.Height * drawShape2Ratio));

            drawShape3.Location = new Point(drawShape2.Location.X, drawShape1.Location.Y + drawShape1.Size.Height + drawShape2.Size.Height);
            drawShape3.Size = new Size(panel1.Size.Width, (int)(panel1.Size.Height * drawShape3Ratio));
        }

        /**
         * @brief Form1_Form1Closing event, which will ask for saving option before quiting
         */
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isSaved == false)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to save Option", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SaveOption();
                }
            }
        }

        /**
         * @brief Override to detect key press for selected key in need
         */
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Space) //pressing space
            {
                if (isSelecting == false && isLoaded == true) //if not selecting and data have been load, begin selecting
                {
                    if (isCleared == false)
                    {
                        drawShape1.Caption = "";
                        drawShape2.Caption = "";
                        drawShape3.Caption = "";

                        drawShape1.Invalidate();
                        drawShape2.Invalidate();
                        drawShape3.Invalidate();

                        isCleared = true;
                    }
                    else //
                    {
                        isCleared = false;
                        isSelecting = true;
                        QuaySo();
                    }
                }
                else if (isSelecting == true)
                {
                    isSelecting = false;
                }
                return true;
            }
            if (keyData == Keys.F11)    //enable full-screen mode
            {
                if (isFullScreen == false)
                {
                    isFullScreen = true;

                    menuStrip1.Visible = false;
                    buttonSet.Visible = false;
                    txtBoxOutLineStrength.Visible = false;
                    buttonSetSpeed.Visible = false;
                    txtBoxSpeed.Visible = false;
                    buttonSetSlownDown.Visible = false;
                    txtBoxLasttimeSlowDown.Visible = false;
                    labelLastshowTime.Visible = false;

                    FormBorderStyle = FormBorderStyle.None;
                    WindowState = FormWindowState.Maximized;
                }
                else
                {
                    isFullScreen = false;

                    menuStrip1.Visible = true;
                    buttonSet.Visible = true;
                    txtBoxOutLineStrength.Visible = true;
                    buttonSetSpeed.Visible = true;
                    txtBoxSpeed.Visible = true;
                    buttonSetSlownDown.Visible = true;
                    txtBoxLasttimeSlowDown.Visible = true;
                    labelLastshowTime.Visible = true;

                    FormBorderStyle = FormBorderStyle.Sizable;
                    WindowState = FormWindowState.Normal;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        /// Private method
        /**
         * @brief Load data from file, read in Unicode
         * 
         * param[in] dir file location
         */
        private void LoadData(string dir)
        {
            database = new List<string[]>();

            IEnumerable<string> names = File.ReadLines(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, dir));

            foreach (var name in names)
            {
                if (name != null)
                {
                    int i = 0;
                    string[] temp = new string[3];
                    temp[0] = name;

                    i = temp[0].IndexOf('\t');

                    if (i != -1)
                    {
                        temp[1] = String.Copy(temp[0]);
                        temp[0] = temp[0].Remove(i);
                        temp[1] = temp[1].Remove(0, i + 1);
                    }
                    else
                    {
                        temp[1] = "";
                    }

                    i = temp[1].IndexOf('\t');

                    if (i != -1)
                    {
                        temp[2] = String.Copy(temp[1]);
                        temp[1] = temp[1].Remove(i);
                        temp[2] = temp[2].Remove(0, i + 1);
                    }
                    else
                    {
                        temp[2] = "";
                    }

                    database.Add(temp);
                }
            }


            isQuaySoEnable = true;
        }

        /**
         * @brief load background prom selected file
         * 
         * param[in] dir location of background file
         */
        private void LoadBackground(string dir)
        {
            panel1.BackgroundImage =
                Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, dir));
        }

        /**
         * @brief draw random user from UserList to screen
         * 
         * return return index of drawed user 
         */
        public int randomUser()
        {
            //drawing
            Random r = new Random(); //using for create random number
            int index = 0;

            index = r.Next(database.Count);

            if (index >= database.Count)
            {
                index = database.Count - 1;
            }

            return index;
        }

        /**
         * @brief selecting event for timer using
         */
        public void Selecting(object sender, EventArgs e)
        {
            int index = randomUser();

            string[] user = new string[2];
            user = database[index];

            //drawing
            drawShape1.Caption = user[0].ToString();
            drawShape1.Invalidate();

            if (isSelecting == false)
            {
                timer.Stop();
                timer.Enabled = false;
                timer.Tick -= Selecting;

                //calculate lastshown slow down                
                int usedTime = 0;
                lastshownCounterLimit = 0;
                for (int i = 0; usedTime < lastshownTime; i++)
                {
                    usedTime += interval * i;
                    lastshownCounterLimit++;
                }

                lastshownCounter = 0;
                timer.Enabled = true;
                timer.Tick += lastshownBefore;
                timer.Start();
            }
        }

        /**
         * @brief event happen before lastshown
         */
        public void lastshownBefore(object sender, EventArgs e)
        {
            lastshownCounter += 1;
            timer.Interval += interval;

            int index = randomUser();

            string[] user = new string[2];
            user = database[index];

            //drawing
            drawShape1.Caption = user[0].ToString();
            drawShape1.Invalidate();

            if (lastshownCounter >= lastshownCounterLimit)
            {
                timer.Stop();
                timer.Enabled = false;
                timer.Tick -= lastshownBefore;
                lastShown(index);
            }
        }

        /**
         * @brief function called after selecting for lasted selected
         */
        public void lastShown(int index)
        {
            //int index = 277;
            string[] user = new string[2];
            user = database[index];

            drawShape1.FillColor = mainFillColor;
            drawShape1.BoderColor = mainOutlineColor;
            drawShape1.ShadowColor = mainShadowColor;

            drawShape2.FillColor = mainFillColor;
            drawShape2.BoderColor = mainOutlineColor;
            drawShape2.ShadowColor = mainShadowColor;

            drawShape3.FillColor = mainFillColor;
            drawShape3.BoderColor = mainOutlineColor;
            drawShape3.ShadowColor = mainShadowColor;

            drawShape1.Caption = user[0].ToString();
            drawShape2.Caption = user[1].ToString();
            drawShape3.Caption = user[2].ToString();

            drawShape1.Invalidate();
            drawShape2.Invalidate();
            drawShape3.Invalidate();

            database.RemoveAt(index);

            isQuaySoEnable = true;

            soundSelecting.Stop();

            if (File.Exists(soundWinLoc) == true)
            {
                soundWin.Play();
            }
        }

        /**
         * @brief setting all GUI properties before begin Selecting, set time for Timer
         */
        private void QuaySo()
        {
            timer.Interval = interval;  //setting timer for each time called func Selecting

            if (isQuaySoEnable == true && database.Count != 0)
            {
                isQuaySoEnable = false;

                /// Set color to selectColor before start timer
                drawShape1.FillColor = selectFillColor;
                drawShape1.BoderColor = selectOutlineColor;
                drawShape1.ShadowColor = selectShadowColor;

                drawShape2.FillColor = selectFillColor;
                drawShape2.BoderColor = selectOutlineColor;
                drawShape2.ShadowColor = selectShadowColor;

                drawShape3.FillColor = selectFillColor;
                drawShape3.BoderColor = selectOutlineColor;
                drawShape3.ShadowColor = selectShadowColor;

                if (File.Exists(soundSelectingLoc) == true)
                {
                    soundSelecting.Play();
                }

                timer.Enabled = true;
                timer.Tick += Selecting; //Set Selecting is a function that called every time Tick does
                timer.Start();
            }
        }

        /**
         * @brief Save all current porperties option
         */
        private void SaveOption()
        {
            Properties.Settings.Default.mainFillColor = mainFillColor;
            Properties.Settings.Default.mainOutlineColor = mainOutlineColor;
            Properties.Settings.Default.mainShadowColor = mainShadowColor;
            Properties.Settings.Default.selectFillColor = selectFillColor;
            Properties.Settings.Default.selectOutlineColor = selectOutlineColor;
            Properties.Settings.Default.selectShadowColor = selectShadowColor;
            Properties.Settings.Default.font = font1;
            Properties.Settings.Default.font2 = font2;
            Properties.Settings.Default.font3 = font3;
            Properties.Settings.Default.outlineStrength = outlineStrength;
            Properties.Settings.Default.interval = interval;
            Properties.Settings.Default.backgroundLocation = backgroundLocation;
            Properties.Settings.Default.soundSelectingLoc = soundSelectingLoc;
            Properties.Settings.Default.soundWinLoc = soundWinLoc;
            Properties.Settings.Default.lastshownSlowDownTime = lastshownTime;

            Properties.Settings.Default.Save();

            isSaved = true;
        }

        /**
         * @brief Load all current porperties option
         */
        private void LoadOption()
        {
            mainFillColor = Properties.Settings.Default.mainFillColor;
            mainOutlineColor = Properties.Settings.Default.mainOutlineColor;
            mainShadowColor = Properties.Settings.Default.mainShadowColor;
            selectFillColor = Properties.Settings.Default.selectFillColor;
            selectOutlineColor = Properties.Settings.Default.selectOutlineColor;
            selectShadowColor = Properties.Settings.Default.selectShadowColor;
            font1 = Properties.Settings.Default.font;
            font2 = Properties.Settings.Default.font2;
            font3 = Properties.Settings.Default.font3;
            outlineStrength = Properties.Settings.Default.outlineStrength;
            interval = Properties.Settings.Default.interval;
            backgroundLocation = Properties.Settings.Default.backgroundLocation;
            soundSelectingLoc = Properties.Settings.Default.soundSelectingLoc;
            soundWinLoc = Properties.Settings.Default.soundWinLoc;
            lastshownTime = Properties.Settings.Default.lastshownSlowDownTime;

            drawShape1.Font = font1;
            drawShape1.FontName = font1.FontFamily.Name.ToString();
            drawShape1.PenSize = (int)font1.Size;
            drawShape1.BoderPenWidth = outlineStrength;

            drawShape2.Font = font2;
            drawShape2.FontName = font2.FontFamily.Name.ToString();
            drawShape2.PenSize = (int)font2.Size;
            drawShape2.BoderPenWidth = outlineStrength;

            drawShape3.Font = font3;
            drawShape3.FontName = font3.FontFamily.Name.ToString();
            drawShape3.PenSize = (int)font3.Size;
            drawShape3.BoderPenWidth = outlineStrength;
        }

        /**
         * @brief call corlor Dialog
         * 
         * param[in] dlg dialog controler
         */
        private Color DialogColor(ColorDialog dlg)
        {
            DialogResult result = dlg.ShowDialog();

            if (result == DialogResult.OK)
            {
                Color temp = dlg.Color;
                isSaved = false;
                return temp;
            }

            return dlg.Color;
        }

        /**
         * @brief call corlor Dialog
         * 
         * param[in] dlg dialog controler
         */
        private Font DialogFont(FontDialog dlg)
        {
            DialogResult result = dlg.ShowDialog();

            if (result == DialogResult.OK)
            {
                return dlg.Font;
            }
            else
            {
                return null;
            }
        }

        /// File menu
        /**
         * @brief event File->Exit exit application
         */
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isSaved == false)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to save Option", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SaveOption();
                }
            }
            Application.Exit();
        }

        /**
         * @brief event File->Load load data before application start
         */
        private void loadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Text File (*.txt)|*.txt";
            openFileDialog.FilterIndex = 1;
            openFileDialog.Multiselect = false;

            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                fileLocation = openFileDialog.FileName;
                LoadData(fileLocation);

                isLoaded = true;
                labelFileStatus.Text = "Loaded";
            }
        }



        /// Options menu: for font selection
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font temp = DialogFont(fontDialog1);
            if (temp != null)
            {
                drawShape1.Font = temp;
                drawShape1.FontName = temp.FontFamily.Name.ToString();
                drawShape1.PenSize = (int)temp.Size;
                font1 = temp;
                isSaved = false;
            }
        }
        private void font2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font temp = DialogFont(fontDialog1);
            if (temp != null)
            {
                drawShape2.Font = temp;
                drawShape2.FontName = temp.FontFamily.Name.ToString();
                drawShape2.PenSize = (int)temp.Size;
                font2 = temp;
                isSaved = false;
            }
        }
        private void font3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font temp = DialogFont(fontDialog1);
            if (temp != null)
            {
                drawShape3.Font = temp;
                drawShape3.FontName = temp.FontFamily.Name.ToString();
                drawShape3.PenSize = (int)temp.Size;
                font3 = temp;
                isSaved = false;
            }
        }

        /// Options for Color select: "main color" and "selecting color"
        ///     Selecting Color is used when the names is in rotation
        ///     Main color is the last shown

        /// Main color
        private void colorFillToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            mainFillColor = DialogColor(colorDialog);
        }
        private void colorOutlineToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            mainOutlineColor = DialogColor(colorDialog);
        }
        private void colorShadowToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            mainShadowColor = DialogColor(colorDialog);
        }

        /// Selecting Color
        private void colorFillToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            selectFillColor = DialogColor(colorDialog);
        }
        private void colorOutlineToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            selectOutlineColor = DialogColor(colorDialog);
        }
        private void colorShadowToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            selectShadowColor = DialogColor(colorDialog);
        }
        private void loadSelectingSoundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "WAV File (*.wav)|*.wav";
            openFileDialog.FilterIndex = 1;
            openFileDialog.Multiselect = false;

            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                soundSelectingLoc = openFileDialog.FileName;

                soundSelecting = new SoundPlayer(soundSelectingLoc);

                isSaved = false;
            }
        }
        private void loadWinSoundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "WAV File (*.wav)|*.wav";
            openFileDialog.FilterIndex = 1;
            openFileDialog.Multiselect = false;

            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                soundWinLoc = openFileDialog.FileName;

                soundWin = new SoundPlayer(soundWinLoc);

                isSaved = false;
            }
        }

        /// Load Background
        private void loadBackgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Image Files (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";
            openFileDialog.FilterIndex = 1;
            openFileDialog.Multiselect = false;

            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                LoadBackground(openFileDialog.FileName);
                backgroundLocation = openFileDialog.FileName;
                isSaved = false;
            }
        }

        /// Set button on upper right conner, used to save width of outline
        private void buttonSet_Click(object sender, EventArgs e)
        {
            int temp = 0;
            Int32.TryParse(txtBoxOutLineStrength.Text.ToString(), out temp);

            outlineStrength = temp;
            drawShape1.BoderPenWidth = temp;

            drawShape1.Invalidate();

            isSaved = false;
        }
        private void buttonSetSpeed_Click(object sender, EventArgs e)
        {
            int temp = 0;
            Int32.TryParse(txtBoxSpeed.Text.ToString(), out temp);

            interval = 10000 / temp;
            timer.Interval = interval;

            isSaved = false;
        }
        private void btnSetSlownDown_Click(object sender, EventArgs e)
        {
            int temp = 0;
            Int32.TryParse(txtBoxLasttimeSlowDown.Text.ToString(), out temp);

            lastshownTime = temp;

            isSaved = false;
        }

        /// Save Load Option
        private void saveOptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveOption();
            isSaved = true;
        }
        private void loadPreviousOptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadOption();
        }

    }
}