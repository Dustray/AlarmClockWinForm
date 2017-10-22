namespace AlarmClockWinForm
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.showNowTimeLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.setTimeMinute = new System.Windows.Forms.NumericUpDown();
            this.setTimeHour = new System.Windows.Forms.NumericUpDown();
            this.setClockButton = new System.Windows.Forms.Button();
            this.showSetTimeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setTimeMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setTimeHour)).BeginInit();
            this.SuspendLayout();
            // 
            // showNowTimeLabel
            // 
            this.showNowTimeLabel.AutoSize = true;
            this.showNowTimeLabel.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.showNowTimeLabel.Location = new System.Drawing.Point(34, 9);
            this.showNowTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.showNowTimeLabel.Name = "showNowTimeLabel";
            this.showNowTimeLabel.Size = new System.Drawing.Size(195, 52);
            this.showNowTimeLabel.TabIndex = 0;
            this.showNowTimeLabel.Text = "12:43:32";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.setTimeMinute);
            this.groupBox1.Controls.Add(this.setTimeHour);
            this.groupBox1.Controls.Add(this.setClockButton);
            this.groupBox1.Location = new System.Drawing.Point(13, 118);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(238, 177);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "控制";
            // 
            // setTimeMinute
            // 
            this.setTimeMinute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.setTimeMinute.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.setTimeMinute.Location = new System.Drawing.Point(145, 64);
            this.setTimeMinute.Margin = new System.Windows.Forms.Padding(4);
            this.setTimeMinute.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.setTimeMinute.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.setTimeMinute.Name = "setTimeMinute";
            this.setTimeMinute.Size = new System.Drawing.Size(85, 37);
            this.setTimeMinute.TabIndex = 3;
            this.setTimeMinute.ValueChanged += new System.EventHandler(this.setTimeMinute_ValueChanged);
            // 
            // setTimeHour
            // 
            this.setTimeHour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.setTimeHour.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.setTimeHour.Location = new System.Drawing.Point(8, 64);
            this.setTimeHour.Margin = new System.Windows.Forms.Padding(4);
            this.setTimeHour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.setTimeHour.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.setTimeHour.Name = "setTimeHour";
            this.setTimeHour.Size = new System.Drawing.Size(85, 37);
            this.setTimeHour.TabIndex = 2;
            this.setTimeHour.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.setTimeHour.ValueChanged += new System.EventHandler(this.setTimeHour_ValueChanged);
            // 
            // setClockButton
            // 
            this.setClockButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.setClockButton.Location = new System.Drawing.Point(8, 114);
            this.setClockButton.Margin = new System.Windows.Forms.Padding(4);
            this.setClockButton.Name = "setClockButton";
            this.setClockButton.Size = new System.Drawing.Size(222, 55);
            this.setClockButton.TabIndex = 0;
            this.setClockButton.Text = "设  置";
            this.setClockButton.UseVisualStyleBackColor = true;
            this.setClockButton.Click += new System.EventHandler(this.setClockButton_Click);
            // 
            // showSetTimeLabel
            // 
            this.showSetTimeLabel.AutoSize = true;
            this.showSetTimeLabel.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.showSetTimeLabel.Location = new System.Drawing.Point(129, 71);
            this.showSetTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.showSetTimeLabel.Name = "showSetTimeLabel";
            this.showSetTimeLabel.Size = new System.Drawing.Size(96, 39);
            this.showSetTimeLabel.TabIndex = 2;
            this.showSetTimeLabel.Text = "12:43";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "已定闹钟：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(8, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "时            分";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(110, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = ":";
            // 
            // Form1
            // 
            this.AcceptButton = this.setClockButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 308);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showSetTimeLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.showNowTimeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "简易闹钟";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setTimeMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setTimeHour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label showNowTimeLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button setClockButton;
        private System.Windows.Forms.NumericUpDown setTimeMinute;
        private System.Windows.Forms.NumericUpDown setTimeHour;
        private System.Windows.Forms.Label showSetTimeLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

