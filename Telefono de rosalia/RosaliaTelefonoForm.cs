using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;
using System.Reflection;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.InteropServices;

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


            if (callAnswered)
            {
                Task.Run(() => Beep(1209, 200));
                Task.Run(() => Beep(697, 200));

            }
        }


        private bool callAnswered = false;
        private void RosaliaTelefonoForm_Shown(object sender, EventArgs e)
        {
            this.Refresh();

            ConfigForm(new List<Button>() {
                this.InvisibleButton,
                this.Number_Asterisk_Button,
                this.Number_9_Button,
                this.Number_7_Button,
                this.Number_5_Button,
                this.Number_2_Button,
                this.Number_1_Button,
                this.NullButton,
                this.Number_Hashtag_Button,
                this.Number_8_Button,
                this.Number_4_Button,
                this.Number_0_Button,
                this.Number_6_Button,
                this.Number_3_Button
            });

            this.Opacity = 1;


            player.LoadCompleted += (object snd, AsyncCompletedEventArgs a) => Invoke(new MethodInvoker(async () =>
            {
                await Task.Delay(800);

                await Shake(800, 10, 15);

                await Task.Delay(400);

                await Shake(800, 11, 14);

                await Task.Delay(800);

                TelefonoPictureBox.Image = Properties.Resources.NokiarosalicoOcupado;

                /*typeof(PictureBox).GetMethod("SetStyle", BindingFlags.Instance | BindingFlags.NonPublic).Invoke(RosaliaDancePictureBox, new object[] { ControlStyles.Selectable, false });
                RosaliaDancePictureBox.Image = Properties.Resources.RosaliaBailando;
                RosaliaDancePictureBox.Parent = TelefonoPictureBox;
                RosaliaDancePictureBox.Visible = true;*/

                callAnswered = true;
            }));

            Task tsk = Task.Factory.StartNew(() =>
            {
                player.Load();

                player.PlaySync();

                Environment.Exit(0);
            });
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

                if (FormButton.Name.StartsWith("Number_"))
                {
                    FormButton.Click += NumbersButton_Click;
                }

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



        private void RosaliaDancePictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            TelefonoPictureBox_MouseDown(sender, e);
        }
        private void RosaliaDancePictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            TelefonoPictureBox_MouseUp(sender, e);
        }
        private void RosaliaDancePictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            TelefonoPictureBox_MouseMove(sender, e);
        }




        private void RosaliaTelefonoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

    }
}
