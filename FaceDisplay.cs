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
            float eyeWidth = ScalePositive(state.EyeScale, Width * 0.01f, Width * 0.1f);
            float eyeHeight = ScalePositive(state.EyeScale, Height * 0.01f, Height * 0.2f);
            float eyeCenterX = ScalePositive(state.EyeOffsetX, Width * 0.5f, Width - eyeWidth * 2);
            float leftEyeX = eyeCenterX - ScalePositive(state.EyeSeparation, eyeWidth, eyeCenterX - eyeWidth);
            float rightEyeX = eyeCenterX + ScalePositive(state.EyeSeparation, eyeWidth, Width - eyeCenterX - eyeWidth);

            float eyeMaxY = Height * 0.65f - eyeHeight;
            float eyeCenterY = ScaleReal(state.EyeOffsetY, eyeHeight, eyeMaxY);
            float leftEyeY = ScaleReal2(state.EyeTilt, eyeHeight, eyeCenterY, eyeMaxY);
            float rightEyeY = ScaleReal2(-state.EyeTilt, eyeHeight, eyeCenterY, eyeMaxY);

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

        private float ScaleReal(float val, float min, float max)
        {
            return ScalePositive(val, (min + max) / 2f, max);
        }

        private float ScalePositive(float val, float zero, float max)
        {
            return (max - zero) * val + zero;
        }

        private float ScaleReal2(float val, float min, float zero, float max)
        {
            if (val < 0)
                return zero + zero - ScalePositive(val, zero, min);
            return
                ScalePositive(val, zero, max);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            CalculatePens();
        }
    }
}
