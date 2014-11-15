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

            // draw eyes
            float eyeWidth = ScalePositive(state.EyeScale, Width * 0.01f, Width * 0.1f);
            float eyeHeight = ScalePositive(state.EyeScale, Height * 0.01f, Height * 0.2f);
            float eyeCenterX = ScalePositive(state.EyeOffsetX, Width * 0.5f, Width - eyeWidth * 2);
            float leftEyeX = eyeCenterX - ScalePositive(state.EyeSeparation, eyeWidth, eyeCenterX - eyeWidth);
            float rightEyeX = eyeCenterX + ScalePositive(state.EyeSeparation, eyeWidth, Width - eyeCenterX - eyeWidth);

            float eyeMaxY = Height * 0.65f - eyeHeight;
            float eyeCenterY = ScaleReal(state.EyeOffsetY, eyeHeight, eyeMaxY);
            float leftEyeY = ScaleReal2(state.EyeTilt, eyeHeight, eyeCenterY, eyeMaxY);
            float rightEyeY = ScaleReal2(-state.EyeTilt, eyeHeight, eyeCenterY, eyeMaxY);

            e.Graphics.FillEllipse(eyeBrush, leftEyeX - eyeWidth, leftEyeY - eyeHeight, eyeWidth * 2, eyeHeight * 2);
            e.Graphics.FillEllipse(eyeBrush, rightEyeX - eyeWidth, rightEyeY - eyeHeight, eyeWidth * 2, eyeHeight * 2);
        
            // draw mouth
            float mouthCenterX = ScaleReal(state.MouthOffsetX, Width * 0.25f, Width * 0.75f) * 0.66f + eyeCenterX * 0.34f;
            float mouthCenterY = ScaleReal(state.MouthOffsetY, eyeCenterY + eyeHeight + linePen.Width, Height - linePen.Width);

            float mouthLeftEndX = mouthCenterX - ScalePositive(state.MouthWidth, linePen.Width, mouthCenterX - linePen.Width);
            float mouthRightEndX = mouthCenterX + ScalePositive(state.MouthWidth, linePen.Width, Width - mouthCenterX - linePen.Width);

            float mouthLeftEndY = ScaleReal2(state.MouthTilt, leftEyeY + eyeHeight + linePen.Width, mouthCenterY, Height - linePen.Width);
            float mouthRightEndY = ScaleReal2(-state.MouthTilt, rightEyeY + eyeHeight + linePen.Width, mouthCenterY, Height - linePen.Width);
            
            float mouthHeight = ScalePositive(state.MouthCurve, 0, Height * 0.25f);

            PointF leftEnd = new PointF(mouthLeftEndX, mouthLeftEndY), rightEnd = new PointF(mouthRightEndX, mouthRightEndY);
            PointF leftMid = new PointF((mouthCenterX + mouthLeftEndX) * 0.5f, (mouthCenterY + mouthLeftEndY) * 0.5f - mouthHeight);
            PointF rightMid = new PointF((mouthCenterX + mouthRightEndX) * 0.5f, (mouthCenterY + mouthRightEndY) * 0.5f - mouthHeight);

            e.Graphics.DrawBezier(linePen, leftEnd, leftMid, rightMid, rightEnd);
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
