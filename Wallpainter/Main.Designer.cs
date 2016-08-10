namespace Wallpainter
{
    partial class WallpainterMain
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WallpainterMain));
			this.textboxWindowName = new System.Windows.Forms.TextBox();
			this.buttonAttach = new System.Windows.Forms.Button();
			this.buttonDetach = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.numericUpDownPosY = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownPosX = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownSizeX = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownSizeY = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownPosY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownPosX)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownSizeX)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownSizeY)).BeginInit();
			this.SuspendLayout();
			// 
			// textboxWindowName
			// 
			this.textboxWindowName.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
			this.textboxWindowName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textboxWindowName.Location = new System.Drawing.Point(87, 12);
			this.textboxWindowName.Name = "textboxWindowName";
			this.textboxWindowName.Size = new System.Drawing.Size(299, 20);
			this.textboxWindowName.TabIndex = 0;
			// 
			// buttonAttach
			// 
			this.buttonAttach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonAttach.Location = new System.Drawing.Point(12, 38);
			this.buttonAttach.Name = "buttonAttach";
			this.buttonAttach.Size = new System.Drawing.Size(291, 39);
			this.buttonAttach.TabIndex = 1;
			this.buttonAttach.Text = "ATTACH";
			this.buttonAttach.UseVisualStyleBackColor = true;
			this.buttonAttach.Click += new System.EventHandler(this.buttonAttach_Click);
			// 
			// buttonDetach
			// 
			this.buttonDetach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonDetach.Enabled = false;
			this.buttonDetach.Location = new System.Drawing.Point(309, 38);
			this.buttonDetach.Name = "buttonDetach";
			this.buttonDetach.Size = new System.Drawing.Size(77, 39);
			this.buttonDetach.TabIndex = 2;
			this.buttonDetach.Text = "DETACH";
			this.buttonDetach.UseVisualStyleBackColor = true;
			this.buttonDetach.Click += new System.EventHandler(this.buttonDetach_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Window Title";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 83);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 20);
			this.label2.TabIndex = 5;
			this.label2.Text = "Window Position X";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(243, 83);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(14, 20);
			this.label3.TabIndex = 6;
			this.label3.Text = "Y";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// numericUpDownPosY
			// 
			this.numericUpDownPosY.Location = new System.Drawing.Point(263, 83);
			this.numericUpDownPosY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numericUpDownPosY.Name = "numericUpDownPosY";
			this.numericUpDownPosY.Size = new System.Drawing.Size(123, 20);
			this.numericUpDownPosY.TabIndex = 7;
			// 
			// numericUpDownPosX
			// 
			this.numericUpDownPosX.Location = new System.Drawing.Point(114, 83);
			this.numericUpDownPosX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numericUpDownPosX.Name = "numericUpDownPosX";
			this.numericUpDownPosX.Size = new System.Drawing.Size(123, 20);
			this.numericUpDownPosX.TabIndex = 8;
			// 
			// numericUpDownSizeX
			// 
			this.numericUpDownSizeX.Location = new System.Drawing.Point(114, 109);
			this.numericUpDownSizeX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numericUpDownSizeX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
			this.numericUpDownSizeX.Name = "numericUpDownSizeX";
			this.numericUpDownSizeX.Size = new System.Drawing.Size(123, 20);
			this.numericUpDownSizeX.TabIndex = 12;
			this.numericUpDownSizeX.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
			// 
			// numericUpDownSizeY
			// 
			this.numericUpDownSizeY.Location = new System.Drawing.Point(263, 109);
			this.numericUpDownSizeY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numericUpDownSizeY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
			this.numericUpDownSizeY.Name = "numericUpDownSizeY";
			this.numericUpDownSizeY.Size = new System.Drawing.Size(123, 20);
			this.numericUpDownSizeY.TabIndex = 11;
			this.numericUpDownSizeY.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(243, 109);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(14, 20);
			this.label4.TabIndex = 10;
			this.label4.Text = "Y";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(12, 109);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(69, 20);
			this.label5.TabIndex = 9;
			this.label5.Text = "Window Size ";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(94, 109);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(14, 20);
			this.label6.TabIndex = 13;
			this.label6.Text = "X";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
			this.notifyIcon1.Text = "notifyIcon1";
			this.notifyIcon1.Visible = true;
			this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
			// 
			// WallpainterMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(398, 139);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.numericUpDownSizeX);
			this.Controls.Add(this.numericUpDownSizeY);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.numericUpDownPosX);
			this.Controls.Add(this.numericUpDownPosY);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonDetach);
			this.Controls.Add(this.buttonAttach);
			this.Controls.Add(this.textboxWindowName);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "WallpainterMain";
			this.Text = "Wallpainter";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WallpainterMain_FormClosing);
			this.SizeChanged += new System.EventHandler(this.WallpainterMain_Resize);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownPosY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownPosX)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownSizeX)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownSizeY)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxWindowName;
        private System.Windows.Forms.Button buttonAttach;
        private System.Windows.Forms.Button buttonDetach;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown numericUpDownPosY;
		private System.Windows.Forms.NumericUpDown numericUpDownPosX;
		private System.Windows.Forms.NumericUpDown numericUpDownSizeX;
		private System.Windows.Forms.NumericUpDown numericUpDownSizeY;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
	}
}

