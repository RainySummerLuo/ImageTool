namespace ImageTool {
    partial class FrmMain {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.picIn = new System.Windows.Forms.PictureBox();
            this.picOut = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInput = new System.Windows.Forms.Button();
            this.tbarWidth = new System.Windows.Forms.TrackBar();
            this.tbarHeight = new System.Windows.Forms.TrackBar();
            this.cboxInterpolation = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblZoom = new System.Windows.Forms.Label();
            this.tbarZoom = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbarAlpha = new System.Windows.Forms.TrackBar();
            this.tbarBeta = new System.Windows.Forms.TrackBar();
            this.tbarGamma = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.picIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarBeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarGamma)).BeginInit();
            this.SuspendLayout();
            // 
            // picIn
            // 
            this.picIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picIn.Location = new System.Drawing.Point(12, 12);
            this.picIn.Name = "picIn";
            this.picIn.Size = new System.Drawing.Size(360, 360);
            this.picIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIn.TabIndex = 0;
            this.picIn.TabStop = false;
            this.picIn.Click += new System.EventHandler(this.PicIn_Click);
            this.picIn.DoubleClick += new System.EventHandler(this.PicIn_DoubleClick);
            this.picIn.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.PicIn_MouseWheel);
            // 
            // picOut
            // 
            this.picOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picOut.Location = new System.Drawing.Point(480, 12);
            this.picOut.Name = "picOut";
            this.picOut.Size = new System.Drawing.Size(360, 360);
            this.picOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOut.TabIndex = 1;
            this.picOut.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(417, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 60);
            this.label1.TabIndex = 2;
            this.label1.Text = "➪";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnInput
            // 
            this.btnInput.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInput.Location = new System.Drawing.Point(538, 378);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(260, 39);
            this.btnInput.TabIndex = 3;
            this.btnInput.Text = "Input Image";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.BtnInput_Click);
            // 
            // tbarWidth
            // 
            this.tbarWidth.Enabled = false;
            this.tbarWidth.Location = new System.Drawing.Point(12, 378);
            this.tbarWidth.Maximum = 0;
            this.tbarWidth.Name = "tbarWidth";
            this.tbarWidth.Size = new System.Drawing.Size(360, 69);
            this.tbarWidth.TabIndex = 4;
            this.tbarWidth.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbarWidth.Scroll += new System.EventHandler(this.TbarWidth_Scroll);
            // 
            // tbarHeight
            // 
            this.tbarHeight.Enabled = false;
            this.tbarHeight.Location = new System.Drawing.Point(378, 12);
            this.tbarHeight.Maximum = 0;
            this.tbarHeight.Name = "tbarHeight";
            this.tbarHeight.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbarHeight.Size = new System.Drawing.Size(69, 360);
            this.tbarHeight.TabIndex = 5;
            this.tbarHeight.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbarHeight.Scroll += new System.EventHandler(this.TbarHeight_Scroll);
            // 
            // cboxInterpolation
            // 
            this.cboxInterpolation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxInterpolation.FormattingEnabled = true;
            this.cboxInterpolation.Items.AddRange(new object[] {
            "INTER_NEAREST: nearest neighbor interpolation",
            "INTER_LINEAR: bilinear interpolation",
            "INTER_CUBIC: bicubic interpolation",
            "INTER_AREA: resampling using pixel area relation",
            "INTER_LANCZOS4: Lanczos interpolation over 8x8 neighborhood",
            "INTER_LINEAR_EXACT: Bit exact bilinear interpolation"});
            this.cboxInterpolation.Location = new System.Drawing.Point(232, 490);
            this.cboxInterpolation.Name = "cboxInterpolation";
            this.cboxInterpolation.Size = new System.Drawing.Size(577, 26);
            this.cboxInterpolation.TabIndex = 6;
            this.cboxInterpolation.SelectedIndexChanged += new System.EventHandler(this.CboxInterpolation_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 488);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Resize() Interpolation:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 445);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Zoom Ratio:";
            // 
            // lblZoom
            // 
            this.lblZoom.AutoSize = true;
            this.lblZoom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZoom.Location = new System.Drawing.Point(173, 445);
            this.lblZoom.Name = "lblZoom";
            this.lblZoom.Size = new System.Drawing.Size(39, 25);
            this.lblZoom.TabIndex = 10;
            this.lblZoom.Text = "1 ×";
            // 
            // tbarZoom
            // 
            this.tbarZoom.Location = new System.Drawing.Point(218, 444);
            this.tbarZoom.Minimum = 1;
            this.tbarZoom.Name = "tbarZoom";
            this.tbarZoom.Size = new System.Drawing.Size(591, 69);
            this.tbarZoom.TabIndex = 11;
            this.tbarZoom.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbarZoom.Value = 1;
            this.tbarZoom.Scroll += new System.EventHandler(this.TbarZoom_Scroll);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 532);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 32);
            this.label5.TabIndex = 12;
            this.label5.Text = "Alpha: ";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 575);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Beta: ";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(45, 619);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Gamma:";
            // 
            // tbarAlpha
            // 
            this.tbarAlpha.Location = new System.Drawing.Point(139, 532);
            this.tbarAlpha.Name = "tbarAlpha";
            this.tbarAlpha.Size = new System.Drawing.Size(670, 69);
            this.tbarAlpha.TabIndex = 15;
            this.tbarAlpha.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbarAlpha.Scroll += new System.EventHandler(this.TbarAlpha_Scroll);
            // 
            // tbarBeta
            // 
            this.tbarBeta.Location = new System.Drawing.Point(138, 575);
            this.tbarBeta.Name = "tbarBeta";
            this.tbarBeta.Size = new System.Drawing.Size(671, 69);
            this.tbarBeta.TabIndex = 16;
            this.tbarBeta.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbarBeta.Scroll += new System.EventHandler(this.TbarBeta_Scroll);
            // 
            // tbarGamma
            // 
            this.tbarGamma.Location = new System.Drawing.Point(138, 619);
            this.tbarGamma.Name = "tbarGamma";
            this.tbarGamma.Size = new System.Drawing.Size(671, 69);
            this.tbarGamma.TabIndex = 17;
            this.tbarGamma.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbarGamma.Scroll += new System.EventHandler(this.TbarGamma_Scroll);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 678);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbarGamma);
            this.Controls.Add(this.tbarBeta);
            this.Controls.Add(this.tbarAlpha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboxInterpolation);
            this.Controls.Add(this.picOut);
            this.Controls.Add(this.picIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.tbarHeight);
            this.Controls.Add(this.lblZoom);
            this.Controls.Add(this.tbarZoom);
            this.Controls.Add(this.tbarWidth);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Image Enlargement & USM Sharpen";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarBeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarGamma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picIn;
        private System.Windows.Forms.PictureBox picOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.TrackBar tbarWidth;
        private System.Windows.Forms.TrackBar tbarHeight;
        private System.Windows.Forms.ComboBox cboxInterpolation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblZoom;
        private System.Windows.Forms.TrackBar tbarZoom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar tbarAlpha;
        private System.Windows.Forms.TrackBar tbarBeta;
        private System.Windows.Forms.TrackBar tbarGamma;
    }
}

