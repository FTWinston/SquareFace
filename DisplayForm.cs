using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SquareFace
{
    public partial class DisplayForm : Form
    {
        public DisplayForm()
        {
            InitializeComponent();
        }

        FaceState state;
        FaceDisplay face;
        ControlForm controller = null;
        private void DisplayForm_Load(object sender, EventArgs e)
        {
            state = new FaceState();

            face = new FaceDisplay(state);
            Controls.Add(face);

            face.Dock = DockStyle.Fill;

            face.Click += face_Click;
            //face.DoubleClick += face_Click;
            face.MouseDown += face_MouseDown;
        }

        void face_Click(object sender, EventArgs e)
        {
            if (controller == null || controller.IsDisposed)
                controller = new ControlForm(state);
            controller.Show();
        }

        protected override void OnInvalidated(InvalidateEventArgs e)
        {
            base.OnInvalidated(e);
            if (face != null)
                face.Refresh();
        }

        // allow dragging of the window
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void face_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
