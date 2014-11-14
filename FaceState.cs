using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareFace
{
    public class FaceState
    {
        public FaceState()
        {
            fillColor = Color.LightGray;
            lineColor = Color.Black;

            eyeSeparation = 0.5f;
            eyeScale = 0.5f;
            eyeTilt = 0f;
            eyeOffsetX = 0f;
            eyeOffsetY = 0f;

            mouthWidth = 0.5f;
            mouthTilt = 0f;
            mouthCurve = 0f;
            mouthOffsetX = 0f;
            mouthOffsetY = 0f;
        }

        private Color fillColor, lineColor;
        public Color FillColor { get { return fillColor; } set { fillColor = value; if (ColorsChanged != null) ColorsChanged(this, EventArgs.Empty); } }
        public Color LineColor { get { return lineColor; } set { lineColor = value; if (ColorsChanged != null) ColorsChanged(this, EventArgs.Empty); } }

        private float eyeSeparation, eyeTilt, eyeScale, eyeOffsetX, eyeOffsetY;
        public float EyeSeparation { get { return eyeSeparation; } set { eyeSeparation = Constrain(value, 0f, 1f); if (DetailsChanged != null) DetailsChanged(this, EventArgs.Empty); } }
        public float EyeScale { get { return eyeScale; } set { eyeScale = Constrain(value, 0f, 1f); if (DetailsChanged != null) DetailsChanged(this, EventArgs.Empty); } }
        public float EyeTilt { get { return eyeTilt; } set { eyeTilt = Constrain(value, -1f, 1f); if (DetailsChanged != null) DetailsChanged(this, EventArgs.Empty); } }
        public float EyeOffsetX { get { return eyeOffsetX; } set { eyeOffsetX = Constrain(value, -1f, 1f); if (DetailsChanged != null) DetailsChanged(this, EventArgs.Empty); } }
        public float EyeOffsetY { get { return eyeOffsetY; } set { eyeOffsetY = Constrain(value, -1f, 1f); if (DetailsChanged != null) DetailsChanged(this, EventArgs.Empty); } }

        private float mouthWidth, mouthTilt, mouthCurve, mouthOffsetX, mouthOffsetY;
        public float MouthWidth { get { return mouthWidth; } set { mouthWidth = Constrain(value, 0f, 1f); if (DetailsChanged != null) DetailsChanged(this, EventArgs.Empty); } }
        public float MouthTilt { get { return mouthTilt; } set { mouthTilt = Constrain(value, -1f, 1f); if (DetailsChanged != null) DetailsChanged(this, EventArgs.Empty); } }
        public float MouthCurve { get { return mouthCurve; } set { mouthCurve = Constrain(value, -1f, 1f); if (DetailsChanged != null) DetailsChanged(this, EventArgs.Empty); } }
        public float MouthOffsetX { get { return mouthOffsetX; } set { mouthOffsetX = Constrain(value, -1f, 1f); if (DetailsChanged != null) DetailsChanged(this, EventArgs.Empty); } }
        public float MouthOffsetY { get { return mouthOffsetY; } set { mouthOffsetY = Constrain(value, -1f, 1f); if (DetailsChanged != null) DetailsChanged(this, EventArgs.Empty); } }
        
        private static float Constrain(float val, float min, float max)
        {
            return Math.Min(max, Math.Max(min, val));
        }

        public event EventHandler DetailsChanged, ColorsChanged;
    }
}
