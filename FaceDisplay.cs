using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SquareFace
{
    public class FaceDisplay : Control
    {
        public FaceDisplay()
            : this(new FaceState())
        {

        }

        public FaceDisplay(FaceState state)
        {
            State = state;
            CalculatePens();
            Size = new Size(256, 256);
        }

        private FaceState state;
        public FaceState State
        {
            get { return state; }
            set
            {
                state = value;
                state.ColorsChanged += (o, e) => CalculatePens();
                state.DetailsChanged += (o, e) => Invalidate();
            }
        }

        Pen linePen;
        Brush eyeBrush;

        public void CalculatePens()
        {
            BackColor = state.FillColor;

            float lineWidth = Width / 60;
            linePen = new Pen(state.LineColor, lineWidth);

            eyeBrush = new SolidBrush(state.LineColor);

            Invalidate();
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            e.Graphics.DrawRectangle(linePen, e.ClipRectangle);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            DrawEyes(e.Graphics);
            DrawMouth(e.Graphics);
        }

        private void DrawEyes(Graphics g)
        {
            float eyeCenterX = Width * 0.5f + state.EyeOffsetX * Width * 0.25f;
            float eyeCenterY = Height * 0.33333f + state.EyeOffsetY * Height * 0.25f;

            float eyeSeparationX = state.EyeSeparation * Width * 0.25f;
            float eyeSeparationY = state.EyeTilt * Height * 0.25f;
            float leftEyeX = eyeCenterX - eyeSeparationX, rightEyeX = eyeCenterX + eyeSeparationX;
            float leftEyeY = eyeCenterY - eyeSeparationY, rightEyeY = eyeCenterY + eyeSeparationY;

            float eyeWidth = Width * 0.1f * state.EyeScale, eyeHeight = Height * 0.2f * state.EyeScale;

            g.FillEllipse(eyeBrush, leftEyeX - eyeWidth, leftEyeY - eyeHeight, eyeWidth * 2, eyeHeight * 2);
            g.FillEllipse(eyeBrush, rightEyeX - eyeWidth, rightEyeY - eyeHeight, eyeWidth * 2, eyeHeight * 2);
        }

        private void DrawMouth(Graphics g)
        {
            float mouthCenterX = Width * 0.5f + state.MouthOffsetX * Width * 0.25f;
            float mouthCenterY = Height * 0.66667f + state.MouthOffsetY * Height * 0.25f;

            float mouthWidth = state.MouthWidth * Width * 0.45f;
            float mouthSkew = state.MouthTilt * Height * 0.25f;

            float mouthHeight = state.MouthCurve * Height * 0.25f;

            PointF leftEnd = new PointF(mouthCenterX - mouthWidth, mouthCenterY - mouthSkew), rightEnd = new PointF(mouthCenterX + mouthWidth, mouthCenterY + mouthSkew);
            PointF leftMid = new PointF(mouthCenterX - mouthWidth * 0.5f, mouthCenterY - mouthSkew * 0.5f - mouthHeight), rightMid = new PointF(mouthCenterX + mouthWidth * 0.5f, mouthCenterY + mouthSkew * 0.5f - mouthHeight);

            g.DrawBezier(linePen, leftEnd, leftMid, rightMid, rightEnd);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            CalculatePens();
        }
    }
}
