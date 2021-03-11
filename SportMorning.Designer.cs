namespace Quiz
{
    partial class SportMorning
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SportMorning));
            this.gb_sm = new System.Windows.Forms.GroupBox();
            this.gb_morningsport = new System.Windows.Forms.GroupBox();
            this.btn_exit_mornings = new System.Windows.Forms.Button();
            this.btn_why_mornings = new System.Windows.Forms.Button();
            this.cb_mornings = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblsm = new System.Windows.Forms.Label();
            this.gb_sm.SuspendLayout();
            this.gb_morningsport.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_sm
            // 
            this.gb_sm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gb_sm.BackgroundImage")));
            this.gb_sm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gb_sm.Controls.Add(this.gb_morningsport);
            this.gb_sm.Controls.Add(this.btn_exit_mornings);
            this.gb_sm.Controls.Add(this.btn_why_mornings);
            this.gb_sm.Controls.Add(this.cb_mornings);
            this.gb_sm.Controls.Add(this.groupBox1);
            this.gb_sm.Location = new System.Drawing.Point(12, 9);
            this.gb_sm.Name = "gb_sm";
            this.gb_sm.Size = new System.Drawing.Size(706, 480);
            this.gb_sm.TabIndex = 0;
            this.gb_sm.TabStop = false;
            // 
            // gb_morningsport
            // 
            this.gb_morningsport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gb_morningsport.BackgroundImage")));
            this.gb_morningsport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gb_morningsport.Controls.Add(this.lblsm);
            this.gb_morningsport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.gb_morningsport.Location = new System.Drawing.Point(20, 222);
            this.gb_morningsport.Name = "gb_morningsport";
            this.gb_morningsport.Size = new System.Drawing.Size(663, 237);
            this.gb_morningsport.TabIndex = 4;
            this.gb_morningsport.TabStop = false;
            this.gb_morningsport.Text = "The reason why";
            this.gb_morningsport.Enter += new System.EventHandler(this.gb_morningsport_Enter);
            // 
            // btn_exit_mornings
            // 
            this.btn_exit_mornings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_exit_mornings.BackgroundImage")));
            this.btn_exit_mornings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exit_mornings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btn_exit_mornings.Location = new System.Drawing.Point(569, 157);
            this.btn_exit_mornings.Name = "btn_exit_mornings";
            this.btn_exit_mornings.Size = new System.Drawing.Size(82, 33);
            this.btn_exit_mornings.TabIndex = 3;
            this.btn_exit_mornings.Text = "Exit";
            this.btn_exit_mornings.UseVisualStyleBackColor = true;
            this.btn_exit_mornings.Click += new System.EventHandler(this.btn_exit_mornings_Click);
            // 
            // btn_why_mornings
            // 
            this.btn_why_mornings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_why_mornings.BackgroundImage")));
            this.btn_why_mornings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_why_mornings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btn_why_mornings.Location = new System.Drawing.Point(459, 158);
            this.btn_why_mornings.Name = "btn_why_mornings";
            this.btn_why_mornings.Size = new System.Drawing.Size(82, 32);
            this.btn_why_mornings.TabIndex = 2;
            this.btn_why_mornings.Text = "Why";
            this.btn_why_mornings.UseVisualStyleBackColor = true;
            this.btn_why_mornings.Click += new System.EventHandler(this.btn_why_mornings_Click);
            // 
            // cb_mornings
            // 
            this.cb_mornings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cb_mornings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.cb_mornings.FormattingEnabled = true;
            this.cb_mornings.Items.AddRange(new object[] {
            "Swimming",
            "Running",
            "Walking for a long distance",
            "Cycling"});
            this.cb_mornings.Location = new System.Drawing.Point(45, 157);
            this.cb_mornings.Name = "cb_mornings";
            this.cb_mornings.Size = new System.Drawing.Size(383, 33);
            this.cb_mornings.TabIndex = 1;
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
            // lblsm
            // 
            this.lblsm.AutoSize = true;
            this.lblsm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblsm.Location = new System.Drawing.Point(30, 37);
            this.lblsm.Name = "lblsm";
            this.lblsm.Size = new System.Drawing.Size(185, 20);
            this.lblsm.TabIndex = 5;
            this.lblsm.Text = "See the reson why here";
            this.lblsm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SportMorning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(733, 501);
            this.Controls.Add(this.gb_sm);
            this.Name = "SportMorning";
            this.Text = "Sportn the morning";
            this.gb_sm.ResumeLayout(false);
            this.gb_morningsport.ResumeLayout(false);
            this.gb_morningsport.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_sm;
        private System.Windows.Forms.GroupBox gb_morningsport;
        private System.Windows.Forms.Button btn_exit_mornings;
        private System.Windows.Forms.Button btn_why_mornings;
        private System.Windows.Forms.ComboBox cb_mornings;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblsm;
    }
}