namespace SquareFace
{
    partial class ControlForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.trackEyeSep = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackEyeY = new System.Windows.Forms.TrackBar();
            this.trackEyeX = new System.Windows.Forms.TrackBar();
            this.trackEyeTilt = new System.Windows.Forms.TrackBar();
            this.trackEyeScale = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.trackMouthY = new System.Windows.Forms.TrackBar();
            this.trackMouthX = new System.Windows.Forms.TrackBar();
            this.trackMouthCurve = new System.Windows.Forms.TrackBar();
            this.trackMouthTilt = new System.Windows.Forms.TrackBar();
            this.trackMouthWidth = new System.Windows.Forms.TrackBar();
            this.btnRandom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackEyeSep)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackEyeY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackEyeX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackEyeTilt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackEyeScale)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackMouthY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackMouthX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackMouthCurve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackMouthTilt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackMouthWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // trackEyeSep
            // 
            this.trackEyeSep.LargeChange = 10;
            this.trackEyeSep.Location = new System.Drawing.Point(70, 19);
            this.trackEyeSep.Maximum = 100;
            this.trackEyeSep.Name = "trackEyeSep";
            this.trackEyeSep.Size = new System.Drawing.Size(169, 45);
            this.trackEyeSep.TabIndex = 0;
            this.trackEyeSep.TickFrequency = 10;
            this.trackEyeSep.Value = 50;
            this.trackEyeSep.ValueChanged += new System.EventHandler(this.trackEyeSep_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.trackEyeY);
            this.groupBox1.Controls.Add(this.trackEyeX);
            this.groupBox1.Controls.Add(this.trackEyeTilt);
            this.groupBox1.Controls.Add(this.trackEyeScale);
            this.groupBox1.Controls.Add(this.trackEyeSep);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 274);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eyes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Offset Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Offset X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tilt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Scale";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Separation";
            // 
            // trackEyeY
            // 
            this.trackEyeY.LargeChange = 10;
            this.trackEyeY.Location = new System.Drawing.Point(70, 223);
            this.trackEyeY.Maximum = 100;
            this.trackEyeY.Minimum = -100;
            this.trackEyeY.Name = "trackEyeY";
            this.trackEyeY.Size = new System.Drawing.Size(169, 45);
            this.trackEyeY.TabIndex = 0;
            this.trackEyeY.TickFrequency = 10;
            this.trackEyeY.ValueChanged += new System.EventHandler(this.trackEyeY_Scroll);
            // 
            // trackEyeX
            // 
            this.trackEyeX.LargeChange = 10;
            this.trackEyeX.Location = new System.Drawing.Point(70, 172);
            this.trackEyeX.Maximum = 100;
            this.trackEyeX.Minimum = -100;
            this.trackEyeX.Name = "trackEyeX";
            this.trackEyeX.Size = new System.Drawing.Size(169, 45);
            this.trackEyeX.TabIndex = 0;
            this.trackEyeX.TickFrequency = 10;
            this.trackEyeX.ValueChanged += new System.EventHandler(this.trackEyeX_Scroll);
            // 
            // trackEyeTilt
            // 
            this.trackEyeTilt.LargeChange = 10;
            this.trackEyeTilt.Location = new System.Drawing.Point(70, 121);
            this.trackEyeTilt.Maximum = 100;
            this.trackEyeTilt.Minimum = -100;
            this.trackEyeTilt.Name = "trackEyeTilt";
            this.trackEyeTilt.Size = new System.Drawing.Size(169, 45);
            this.trackEyeTilt.TabIndex = 0;
            this.trackEyeTilt.TickFrequency = 10;
            this.trackEyeTilt.ValueChanged += new System.EventHandler(this.trackEyeTilt_Scroll);
            // 
            // trackEyeScale
            // 
            this.trackEyeScale.LargeChange = 10;
            this.trackEyeScale.Location = new System.Drawing.Point(70, 70);
            this.trackEyeScale.Maximum = 100;
            this.trackEyeScale.Name = "trackEyeScale";
            this.trackEyeScale.Size = new System.Drawing.Size(169, 45);
            this.trackEyeScale.TabIndex = 0;
            this.trackEyeScale.TickFrequency = 10;
            this.trackEyeScale.Value = 50;
            this.trackEyeScale.ValueChanged += new System.EventHandler(this.trackEyeScale_Scroll);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.trackMouthY);
            this.groupBox2.Controls.Add(this.trackMouthX);
            this.groupBox2.Controls.Add(this.trackMouthCurve);
            this.groupBox2.Controls.Add(this.trackMouthTilt);
            this.groupBox2.Controls.Add(this.trackMouthWidth);
            this.groupBox2.Location = new System.Drawing.Point(278, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 274);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mouth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Offset Y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Offset X";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Curve";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Tilt";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Width";
            // 
            // trackMouthY
            // 
            this.trackMouthY.LargeChange = 10;
            this.trackMouthY.Location = new System.Drawing.Point(70, 223);
            this.trackMouthY.Maximum = 100;
            this.trackMouthY.Minimum = -100;
            this.trackMouthY.Name = "trackMouthY";
            this.trackMouthY.Size = new System.Drawing.Size(169, 45);
            this.trackMouthY.TabIndex = 0;
            this.trackMouthY.TickFrequency = 10;
            this.trackMouthY.ValueChanged += new System.EventHandler(this.trackMouthY_Scroll);
            // 
            // trackMouthX
            // 
            this.trackMouthX.LargeChange = 10;
            this.trackMouthX.Location = new System.Drawing.Point(70, 172);
            this.trackMouthX.Maximum = 100;
            this.trackMouthX.Minimum = -100;
            this.trackMouthX.Name = "trackMouthX";
            this.trackMouthX.Size = new System.Drawing.Size(169, 45);
            this.trackMouthX.TabIndex = 0;
            this.trackMouthX.TickFrequency = 10;
            this.trackMouthX.ValueChanged += new System.EventHandler(this.trackMouthX_Scroll);
            // 
            // trackMouthCurve
            // 
            this.trackMouthCurve.LargeChange = 10;
            this.trackMouthCurve.Location = new System.Drawing.Point(70, 121);
            this.trackMouthCurve.Maximum = 100;
            this.trackMouthCurve.Minimum = -100;
            this.trackMouthCurve.Name = "trackMouthCurve";
            this.trackMouthCurve.Size = new System.Drawing.Size(169, 45);
            this.trackMouthCurve.TabIndex = 0;
            this.trackMouthCurve.TickFrequency = 10;
            this.trackMouthCurve.ValueChanged += new System.EventHandler(this.trackMouthCurve_Scroll);
            // 
            // trackMouthTilt
            // 
            this.trackMouthTilt.LargeChange = 10;
            this.trackMouthTilt.Location = new System.Drawing.Point(70, 70);
            this.trackMouthTilt.Maximum = 100;
            this.trackMouthTilt.Minimum = -100;
            this.trackMouthTilt.Name = "trackMouthTilt";
            this.trackMouthTilt.Size = new System.Drawing.Size(169, 45);
            this.trackMouthTilt.TabIndex = 0;
            this.trackMouthTilt.TickFrequency = 10;
            this.trackMouthTilt.ValueChanged += new System.EventHandler(this.trackMouthTilt_Scroll);
            // 
            // trackMouthWidth
            // 
            this.trackMouthWidth.LargeChange = 10;
            this.trackMouthWidth.Location = new System.Drawing.Point(70, 19);
            this.trackMouthWidth.Maximum = 100;
            this.trackMouthWidth.Name = "trackMouthWidth";
            this.trackMouthWidth.Size = new System.Drawing.Size(169, 45);
            this.trackMouthWidth.TabIndex = 0;
            this.trackMouthWidth.TickFrequency = 10;
            this.trackMouthWidth.Value = 50;
            this.trackMouthWidth.ValueChanged += new System.EventHandler(this.trackMouthWidth_Scroll);
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(448, 292);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(75, 23);
            this.btnRandom.TabIndex = 2;
            this.btnRandom.Text = "Randomize";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 333);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ControlForm";
            this.Text = "SquareFace control";
            ((System.ComponentModel.ISupportInitialize)(this.trackEyeSep)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackEyeY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackEyeX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackEyeTilt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackEyeScale)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackMouthY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackMouthX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackMouthCurve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackMouthTilt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackMouthWidth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar trackEyeSep;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackEyeY;
        private System.Windows.Forms.TrackBar trackEyeX;
        private System.Windows.Forms.TrackBar trackEyeTilt;
        private System.Windows.Forms.TrackBar trackEyeScale;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TrackBar trackMouthY;
        private System.Windows.Forms.TrackBar trackMouthX;
        private System.Windows.Forms.TrackBar trackMouthCurve;
        private System.Windows.Forms.TrackBar trackMouthTilt;
        private System.Windows.Forms.TrackBar trackMouthWidth;
        private System.Windows.Forms.Button btnRandom;
    }
}