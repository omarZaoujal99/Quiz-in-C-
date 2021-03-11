namespace Quiz
{
    partial class SportNoon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SportNoon));
            this.gb_sm = new System.Windows.Forms.GroupBox();
            this.gb_noonsport = new System.Windows.Forms.GroupBox();
            this.btn_exit_noons = new System.Windows.Forms.Button();
            this.btn_why_noons = new System.Windows.Forms.Button();
            this.cb_noons = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblsn = new System.Windows.Forms.Label();
            this.gb_sm.SuspendLayout();
            this.gb_noonsport.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_sm
            // 
            this.gb_sm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gb_sm.BackgroundImage")));
            this.gb_sm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gb_sm.Controls.Add(this.gb_noonsport);
            this.gb_sm.Controls.Add(this.btn_exit_noons);
            this.gb_sm.Controls.Add(this.btn_why_noons);
            this.gb_sm.Controls.Add(this.cb_noons);
            this.gb_sm.Controls.Add(this.groupBox1);
            this.gb_sm.Location = new System.Drawing.Point(18, 8);
            this.gb_sm.Name = "gb_sm";
            this.gb_sm.Size = new System.Drawing.Size(706, 480);
            this.gb_sm.TabIndex = 1;
            this.gb_sm.TabStop = false;
            // 
            // gb_noonsport
            // 
            this.gb_noonsport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gb_noonsport.BackgroundImage")));
            this.gb_noonsport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gb_noonsport.Controls.Add(this.lblsn);
            this.gb_noonsport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.gb_noonsport.Location = new System.Drawing.Point(20, 222);
            this.gb_noonsport.Name = "gb_noonsport";
            this.gb_noonsport.Size = new System.Drawing.Size(663, 237);
            this.gb_noonsport.TabIndex = 4;
            this.gb_noonsport.TabStop = false;
            this.gb_noonsport.Text = "The reason why";
            // 
            // btn_exit_noons
            // 
            this.btn_exit_noons.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_exit_noons.BackgroundImage")));
            this.btn_exit_noons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exit_noons.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btn_exit_noons.Location = new System.Drawing.Point(569, 157);
            this.btn_exit_noons.Name = "btn_exit_noons";
            this.btn_exit_noons.Size = new System.Drawing.Size(82, 33);
            this.btn_exit_noons.TabIndex = 3;
            this.btn_exit_noons.Text = "Exit";
            this.btn_exit_noons.UseVisualStyleBackColor = true;
            this.btn_exit_noons.Click += new System.EventHandler(this.btn_exit_noons_Click);
            // 
            // btn_why_noons
            // 
            this.btn_why_noons.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_why_noons.BackgroundImage")));
            this.btn_why_noons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_why_noons.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btn_why_noons.Location = new System.Drawing.Point(459, 158);
            this.btn_why_noons.Name = "btn_why_noons";
            this.btn_why_noons.Size = new System.Drawing.Size(82, 32);
            this.btn_why_noons.TabIndex = 2;
            this.btn_why_noons.Text = "Why";
            this.btn_why_noons.UseVisualStyleBackColor = true;
            this.btn_why_noons.Click += new System.EventHandler(this.btn_why_noons_Click);
            // 
            // cb_noons
            // 
            this.cb_noons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cb_noons.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.cb_noons.FormattingEnabled = true;
            this.cb_noons.Items.AddRange(new object[] {
            "Soccer",
            "BasketBall",
            "Tenis",
            "HondBall"});
            this.cb_noons.Location = new System.Drawing.Point(45, 157);
            this.cb_noons.Name = "cb_noons";
            this.cb_noons.Size = new System.Drawing.Size(383, 33);
            this.cb_noons.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 93);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(625, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exercising early in the morning offers both physical and mental gratification.\r\n " +
    "Training exercises\r\n can boost metabolism, ensuring that calories are being burn" +
    "t during the day.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblsn
            // 
            this.lblsn.AutoSize = true;
            this.lblsn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblsn.Location = new System.Drawing.Point(21, 40);
            this.lblsn.Name = "lblsn";
            this.lblsn.Size = new System.Drawing.Size(185, 20);
            this.lblsn.TabIndex = 0;
            this.lblsn.Text = "See the reson why here";
            this.lblsn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SportNoon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(743, 497);
            this.Controls.Add(this.gb_sm);
            this.Name = "SportNoon";
            this.Text = "SportNoon";
            this.gb_sm.ResumeLayout(false);
            this.gb_noonsport.ResumeLayout(false);
            this.gb_noonsport.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_sm;
        private System.Windows.Forms.GroupBox gb_noonsport;
        private System.Windows.Forms.Button btn_exit_noons;
        private System.Windows.Forms.Button btn_why_noons;
        private System.Windows.Forms.ComboBox cb_noons;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblsn;
    }
}