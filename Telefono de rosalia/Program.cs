using System;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Telefono_de_rosalia
{
    using SLID = Guid;

    internal static class Program
    {
        public class GenuineWindowsDetector
        {
            private enum SL_GENUINE_STATE
            {
                SL_GEN_STATE_IS_GENUINE = 0,
                SL_GEN_STATE_INVALID_LICENSE = 1,
                SL_GEN_STATE_TAMPERED = 2,
                SL_GEN_STATE_LAST = 3
            }

            [DllImportAttribute("Slwga.dll", EntryPoint = "SLIsGenuineLocal", CharSet = CharSet.None, ExactSpelling = false, SetLastError = false, PreserveSig = true, CallingConvention = CallingConvention.Winapi, BestFitMapping = false, ThrowOnUnmappableChar = false)]
            [PreserveSigAttribute()]
            private static extern uint SLIsGenuineLocal(ref SLID slid, [In, Out] ref SL_GENUINE_STATE genuineState, IntPtr val3);

            public static void CheckWindows()
            {
                if (!IsGenuineWindows())
                {
                    MessageBox.Show("Estimado usuario,\r\n\r\nHemos detectado que está usando una versión ilícita y fraudulenta de Windows en su computadora. Esta versión tiene modificaciones ilegales que pueden comprometer la seguridad y el rendimiento de su sistema. Además, el software proporcionado por nosotros fue estrictamente prohibido en su computadora, ya que viola nuestros términos y condiciones de uso.\r\n\r\nLe recomendamos que desinstale inmediatamente esta versión ilícita y fraudulenta de Windows y adquiera una versión original y legal. De lo contrario, se expondrá a posibles sanciones legales y riesgos informáticos.\r\n\r\nGracias por su comprensión y cooperación.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    Environment.Exit(9);
                }
            }

            private static bool IsGenuineWindows()
            {
                if (Environment.OSVersion.Version.Major < 6)
                {
                    return false;
                }

                bool _IsGenuineWindows = false;

                SLID windowsSlid = (Guid)new Guid("55c92734-d682-4d71-983e-d6ec3f16059f");
                try
                {
                    SL_GENUINE_STATE genuineState = SL_GENUINE_STATE.SL_GEN_STATE_LAST;
                    uint ResultInt = SLIsGenuineLocal(ref windowsSlid, ref genuineState, IntPtr.Zero);
                    if (ResultInt == 0)
                    {
                        _IsGenuineWindows = (genuineState == SL_GENUINE_STATE.SL_GEN_STATE_IS_GENUINE);
                    }
                }
                catch { }
                return _IsGenuineWindows;
            }
        }

        [DllImport("winmm.dll", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        public static extern uint waveOutGetNumDevs();

        [DllImport("user32.dll", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern bool SetProcessDPIAware();

        [STAThread]
        private static void Main()
        {
            GenuineWindowsDetector.CheckWindows();

            if (typeof(Program).Name != "Program")
            {
                MessageBox.Show("Error el programa fue modificado y es posible que no funcióne asi que me voy a ir", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }

            double[] freqs = { 697, 770, 852, 941 };
            double[] freqs2 = { 1209, 1336, 1477 };

            for (int i = 0; i < freqs.Length; i++)
            {
                for (int e = 0; e < freqs2.Length; e++)
                {
                    using (var tone = GenerateTone(0.8, freqs[i], freqs2[e]))
                    {
                        using (var player = new SoundPlayer(tone))
                        {
                            player.PlaySync();
                        }
                    }
                }
            }

            if (waveOutGetNumDevs() == 0)
            {
                MessageBox.Show("Error necesitas un dispositivo de audio amorcito.\n\nSi no como vas a escuchar lo que te voy a decir?", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }

            if (Environment.OSVersion.Version.Major >= 6) SetProcessDPIAware();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RosaliaTelefonoForm());
        }

        private static Stream GenerateTone(double duration, params double[] frequencies)
        {
            const int sampleRate = 44100;
            const short bitsPerSample = 16;

            var stream = new MemoryStream();
            var writer = new BinaryWriter(stream);

            writer.Write("RIFF".ToCharArray());
            writer.Write((int)(36 + sampleRate * duration * bitsPerSample / 8));
            writer.Write("WAVEfmt ".ToCharArray());
            writer.Write(16);
            writer.Write((short)1);
            writer.Write((short)1);
            writer.Write(sampleRate);
            writer.Write(sampleRate * bitsPerSample / 8);
            writer.Write((short)(bitsPerSample / 8));
            writer.Write(bitsPerSample);
            writer.Write("data".ToCharArray());
            writer.Write((int)(sampleRate * duration * bitsPerSample / 8));

            for (int i = 0; i < sampleRate * duration; i++)
            {
                double t = (double)i / sampleRate;
                var freqSamples = frequencies.Select(f => (Math.Sin(2 * Math.PI * f * t)));
                short sample = (short)(short.MaxValue * freqSamples.Sum() / 2); ;
                writer.Write(sample);
            }

            writer.Flush();
            stream.Position = 0;
            return stream;
        }
    }
}