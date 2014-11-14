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
    public partial class ControlForm : Form
    {
        FaceState State { get; set; }
        public ControlForm(FaceState state)
        {
            InitializeComponent();
            State = state;

            trackEyeSep.Value = (int)(state.EyeSeparation * 100);
            trackEyeScale.Value = (int)(state.EyeScale * 100);
            trackEyeTilt.Value = (int)(state.EyeTilt * 100);
            trackEyeX.Value = (int)(state.EyeOffsetX * 100);
            trackEyeY.Value = (int)(state.EyeOffsetY * 100);

            trackMouthWidth.Value = (int)(state.MouthWidth * 100);
            trackMouthTilt.Value = (int)(state.MouthTilt * 100);
            trackMouthCurve.Value = (int)(state.MouthCurve * 100);
            trackMouthX.Value = (int)(state.MouthOffsetX * 100);
            trackMouthY.Value = (int)(state.MouthOffsetY * 100);
        }

        private void trackEyeSep_Scroll(object sender, EventArgs e)
        {
            State.EyeSeparation = trackEyeSep.Value / 100f;
        }

        private void trackEyeScale_Scroll(object sender, EventArgs e)
        {
            State.EyeScale = trackEyeScale.Value / 100f;
        }

        private void trackEyeTilt_Scroll(object sender, EventArgs e)
        {
            State.EyeTilt = trackEyeTilt.Value / 100f;
        }

        private void trackEyeX_Scroll(object sender, EventArgs e)
        {
            State.EyeOffsetX = trackEyeX.Value / 100f;
        }

        private void trackEyeY_Scroll(object sender, EventArgs e)
        {
            State.EyeOffsetY = trackEyeY.Value / 100f;
        }

        private void trackMouthWidth_Scroll(object sender, EventArgs e)
        {
            State.MouthWidth = trackMouthWidth.Value / 100f;
        }

        private void trackMouthTilt_Scroll(object sender, EventArgs e)
        {
            State.MouthTilt = trackMouthTilt.Value / 100f;
        }

        private void trackMouthCurve_Scroll(object sender, EventArgs e)
        {
            State.MouthCurve = trackMouthCurve.Value / 100f;
        }

        private void trackMouthX_Scroll(object sender, EventArgs e)
        {
            State.MouthOffsetX = trackMouthX.Value / 100f;
        }

        private void trackMouthY_Scroll(object sender, EventArgs e)
        {
            State.MouthOffsetY = trackMouthY.Value / 100f;
        }
    }
}
