using System.Runtime.InteropServices;

namespace WinFormsAppEstruturaControle
{
    public partial class FormConta : Form
    { // EVENTOS DO MOUSE
        private const int MOUSEEVENTF_MOVE = 0x0001;
        private const int MOUSEEVENTF_ABSOLUTE = 0x8000;
        private const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const int MOUSEEVENTF_LEFTUP = 0x0004;

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
        private Random random = new Random();

        public FormConta()
        {
            InitializeComponent();
            MoverCursorAleatorio();
            MouseClicar();
        }

        private void MoverCursorAleatorio()
        {
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            int randomX = random.Next(screenWidth);
            int randomY = random.Next(screenHeight);
            Cursor.Position = new System.Drawing.Point(randomX, randomY);
        }

        private void MouseClicar()
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN, Cursor.Position.X, Cursor.Position.Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, Cursor.Position.X, Cursor.Position.Y, 0, 0);
        }
    }
}
