namespace Quiz
{
    partial class SportEvening
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SportEvening));
            this.gb_sm = new System.Windows.Forms.GroupBox();
            this.gb_eveningsport = new System.Windows.Forms.GroupBox();
            this.btn_exit_evenings = new System.Windows.Forms.Button();
            this.btn_why_evenings = new System.Windows.Forms.Button();
            this.cb_evenings = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblse = new System.Windows.Forms.Label();
            this.gb_sm.SuspendLayout();
            this.gb_eveningsport.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_sm
            // 
            this.gb_sm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gb_sm.BackgroundImage")));
            this.gb_sm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gb_sm.Controls.Add(this.gb_eveningsport);
            this.gb_sm.Controls.Add(this.btn_exit_evenings);
            this.gb_sm.Controls.Add(this.btn_why_evenings);
            this.gb_sm.Controls.Add(this.cb_evenings);
            this.gb_sm.Controls.Add(this.groupBox1);
            this.gb_sm.Location = new System.Drawing.Point(15, 11);
            this.gb_sm.Name = "gb_sm";
            this.gb_sm.Size = new System.Drawing.Size(706, 480);
            this.gb_sm.TabIndex = 1;
            this.gb_sm.TabStop = false;
            // 
            // gb_eveningsport
            // 
            this.gb_eveningsport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gb_eveningsport.BackgroundImage")));
            this.gb_eveningsport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gb_eveningsport.Controls.Add(this.lblse);
            this.gb_eveningsport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.gb_eveningsport.Location = new System.Drawing.Point(31, 222);
            this.gb_eveningsport.Name = "gb_eveningsport";
            this.gb_eveningsport.Size = new System.Drawing.Size(663, 237);
            this.gb_eveningsport.TabIndex = 4;
            this.gb_eveningsport.TabStop = false;
            this.gb_eveningsport.Text = "The reason why";
            // 
            // btn_exit_evenings
            // 
            this.btn_exit_evenings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_exit_evenings.BackgroundImage")));
            this.btn_exit_evenings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exit_evenings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btn_exit_evenings.Location = new System.Drawing.Point(582, 157);
            this.btn_exit_evenings.Name = "btn_exit_evenings";
            this.btn_exit_evenings.Size = new System.Drawing.Size(82, 33);
            this.btn_exit_evenings.TabIndex = 3;
            this.btn_exit_evenings.Text = "Exit";
            this.btn_exit_evenings.UseVisualStyleBackColor = true;
            this.btn_exit_evenings.Click += new System.EventHandler(this.btn_exit_evenings_Click);
            // 
            // btn_why_evenings
            // 
            this.btn_why_evenings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_why_evenings.BackgroundImage")));
            this.btn_why_evenings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_why_evenings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btn_why_evenings.Location = new System.Drawing.Point(472, 158);
            this.btn_why_evenings.Name = "btn_why_evenings";
            this.btn_why_evenings.Size = new System.Drawing.Size(82, 32);
            this.btn_why_evenings.TabIndex = 2;
            this.btn_why_evenings.Text = "Why";
            this.btn_why_evenings.UseVisualStyleBackColor = true;
            this.btn_why_evenings.Click += new System.EventHandler(this.btn_why_evenings_Click);
            // 
            // cb_evenings
            // 
            this.cb_evenings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cb_evenings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.cb_evenings.FormattingEnabled = true;
            this.cb_evenings.Items.AddRange(new object[] {
            "Soccer",
            "BasketBall",
            "Tenis",
            "HandBall"});
            this.cb_evenings.Location = new System.Drawing.Point(45, 157);
            this.cb_evenings.Name = "cb_evenings";
            this.cb_evenings.Size = new System.Drawing.Size(383, 33);
            this.cb_evenings.TabIndex = 1;
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(623, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exercising early in the morning offers both physical and mental gratification.\r\n " +
    "Training exercises\r\n can boost metabolism, ensuring that calories are being burn" +
    "t during the day.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblse
            // 
            this.lblse.AutoSize = true;
            this.lblse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblse.Location = new System.Drawing.Point(26, 36);
            this.lblse.Name = "lblse";
            this.lblse.Size = new System.Drawing.Size(185, 20);
            this.lblse.TabIndex = 1;
            this.lblse.Text = "See the reson why here";
            this.lblse.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SportEvening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(736, 503);
            this.Controls.Add(this.gb_sm);
            this.Name = "SportEvening";
            this.Text = "SportEvening";
            this.gb_sm.ResumeLayout(false);
            this.gb_eveningsport.ResumeLayout(false);
            this.gb_eveningsport.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_sm;
        private System.Windows.Forms.GroupBox gb_eveningsport;
        private System.Windows.Forms.Button btn_exit_evenings;
        private System.Windows.Forms.Button btn_why_evenings;
        private System.Windows.Forms.ComboBox cb_evenings;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblse;
    }
}