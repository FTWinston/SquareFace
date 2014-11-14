using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        private void Form1_Load(object sender, EventArgs e)
        {
            state = new FaceState();

            face = new FaceDisplay(state);
            Controls.Add(face);

            face.Dock = DockStyle.Fill;

            face.Click += face_Click;
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
    }
}
