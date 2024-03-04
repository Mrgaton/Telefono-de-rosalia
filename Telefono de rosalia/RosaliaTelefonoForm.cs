using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Media;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telefono_de_rosalia
{
    public partial class RosaliaTelefonoForm : Form
    {
        private static SoundPlayer player = new SoundPlayer();

        public RosaliaTelefonoForm()
        {
            InitializeComponent();

            this.Icon = Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location);

            this.ShowInTaskbar = false;

            Console.WriteLine(SystemColors.Control);

            InvisibleButton.FlatStyle = FlatStyle.Flat;
            InvisibleButton.BackColor = Color.Transparent;
            InvisibleButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            InvisibleButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            InvisibleButton.Focus();

            this.Opacity = 0;
        }

        private void RosaliaTelefonoForm_Load(object sender, EventArgs e)
        {
            player.Stream = Properties.Resources.TararaTaratata;

            TelefonoPictureBox.Image = Properties.Resources.Nokiarosalico;

            this.ShowInTaskbar = false;
            this.TopMost = true;
        }

        private void NullButton_Click(object sender, EventArgs e)
        {
            if (callAnswered) Environment.Exit(0);
        }

        [DllImport("kernel32.dll")] public static extern bool Beep(int freq, int duration);

        private async void NumbersButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Button clicked " + ((Button)sender).Name.ToString());

            Shake(5, 1, 2);
        }

        private bool callAnswered = false;

        private void RosaliaTelefonoForm_Shown(object sender, EventArgs e)
        {
            this.Refresh();

            ConfigForm(new List<Button>() {
                this.Number_1_Button,
                this.Number_2_Button,
                this.Number_3_Button,
                this.Number_4_Button,
                this.Number_5_Button,
                this.Number_6_Button,
                this.Number_7_Button,
                this.Number_8_Button,
                this.Number_9_Button,
                this.Number_0_Button,
                this.Number_Asterisk_Button,
                this.NullButton,
                this.Number_Hashtag_Button,
                this.InvisibleButton,
            });

            this.Opacity = 1;

            player.LoadCompleted += (object snd, AsyncCompletedEventArgs a) => Invoke(new MethodInvoker(async () =>
            {
                Task.Factory.StartNew(() =>
                {
                    player.PlaySync();

                    Environment.Exit(0);
                });

                await Task.Delay(800);

                await Shake(800, 10, 15);

                await Task.Delay(500);

                await Shake(1250, 12, 14);

                await Task.Delay(850);

                TelefonoPictureBox.Image = Properties.Resources.NokiarosalicoOcupado;

                /*typeof(PictureBox).GetMethod("SetStyle", BindingFlags.Instance | BindingFlags.NonPublic).Invoke(RosaliaDancePictureBox, new object[] { ControlStyles.Selectable, false });
                RosaliaDancePictureBox.Image = Properties.Resources.RosaliaBailando;
                RosaliaDancePictureBox.Parent = TelefonoPictureBox;
                RosaliaDancePictureBox.Visible = true;*/

                callAnswered = true;
            }));

            player.Load();

            this.Focus();
        }

        private static Random rnd = new Random();

        private static Point originalPoint = new Point();

        private async Task Shake(int Time, int ShakeMult, int TimeBetwemShake)
        {
            originalPoint = this.Location;

            for (int i = 0; i < Time / TimeBetwemShake; i++)
            {
                this.Location = new Point(originalPoint.X + rnd.Next(-ShakeMult, ShakeMult), originalPoint.Y + rnd.Next(-ShakeMult, ShakeMult));

                await Task.Delay(TimeBetwemShake);
            }

            this.Location = originalPoint;
        }

        private void ConfigForm(List<Button> Buttons)
        {
            foreach (Button FormButton in Buttons)
            {
                Console.WriteLine(FormButton.Name);

                if (FormButton.Name.StartsWith("Number_")) FormButton.Click += NumbersButton_Click;

                FormButton.MouseDown += TelefonoPictureBox_MouseDown;
                FormButton.MouseUp += TelefonoPictureBox_MouseUp;
                FormButton.MouseMove += TelefonoPictureBox_MouseMove;

                FormButton.Parent = TelefonoPictureBox;

                FormButton.GotFocus += (object c, EventArgs f) =>
                {
                    if (FormButton.Name == InvisibleButton.Name) return;

                    InvisibleButton.Focus();
                };
            }
        }

        private bool DraggingForm = false;
        private Point DragCursorPoint;
        private Point DragFormPoint;

        private void TelefonoPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            DraggingForm = true;
            DragCursorPoint = Cursor.Position;
            DragFormPoint = this.Location;
        }

        private void TelefonoPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            DraggingForm = false;
        }

        private void TelefonoPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (DraggingForm)
            {
                this.Location = Point.Add(DragFormPoint, new Size(Point.Subtract(Cursor.Position, new Size(DragCursorPoint))));

                originalPoint = this.Location;
            }
        }

        private void RosaliaDancePictureBox_MouseDown(object sender, MouseEventArgs e) => TelefonoPictureBox_MouseDown(sender, e);

        private void RosaliaDancePictureBox_MouseUp(object sender, MouseEventArgs e) => TelefonoPictureBox_MouseUp(sender, e);

        private void RosaliaDancePictureBox_MouseMove(object sender, MouseEventArgs e) => TelefonoPictureBox_MouseMove(sender, e);

        private void RosaliaTelefonoForm_FormClosing(object sender, FormClosingEventArgs e) => e.Cancel = true;

        private static double[] horizontalFreq = { 697, 770, 852, 941 };

        private static double[] verticalFreq = { 1209, 1336, 1477, 1632 };

        private void PlayFrequency(int num)
        {
            if (!callAnswered) return;

            int x = (num - 1) % 3;
            int y = (num - 1) / 3;

            PlayFrequency(x, y);
        }

        private static void PlayFrequency(int x, int y)
        {
            Task.Factory.StartNew(() => Beep(Math.Abs((int)((horizontalFreq[x] + verticalFreq[y]) / 1.5)), 250));
        }

        private void Number_1_Button_Click(object sender, EventArgs e) => PlayFrequency(1);

        private void Number_2_Button_Click(object sender, EventArgs e) => PlayFrequency(2);

        private void Number_3_Button_Click(object sender, EventArgs e) => PlayFrequency(3);

        private void Number_4_Button_Click(object sender, EventArgs e) => PlayFrequency(4);

        private void Number_5_Button_Click(object sender, EventArgs e) => PlayFrequency(5);

        private void Number_6_Button_Click(object sender, EventArgs e) => PlayFrequency(6);

        private void Number_7_Button_Click(object sender, EventArgs e) => PlayFrequency(7);

        private void Number_8_Button_Click(object sender, EventArgs e) => PlayFrequency(8);

        private void Number_9_Button_Click(object sender, EventArgs e) => PlayFrequency(9);

        private void Number_Asterisk_Button_Click(object sender, EventArgs e) => PlayFrequency(10);

        private void Number_0_Button_Click(object sender, EventArgs e) => PlayFrequency(11);

        private void Number_Hashtag_Button_Click(object sender, EventArgs e) => PlayFrequency(12);
    }
}