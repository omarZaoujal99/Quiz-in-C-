namespace Quiz
{
    partial class Lunch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lunch));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_lunch_exit = new System.Windows.Forms.Button();
            this.btn_lunch_why = new System.Windows.Forms.Button();
            this.lb_lunch = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_lunch = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.btn_lunch_exit);
            this.groupBox1.Controls.Add(this.btn_lunch_why);
            this.groupBox1.Controls.Add(this.lb_lunch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(724, 471);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btn_lunch_exit
            // 
            this.btn_lunch_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_lunch_exit.BackgroundImage")));
            this.btn_lunch_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_lunch_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btn_lunch_exit.Location = new System.Drawing.Point(593, 352);
            this.btn_lunch_exit.Name = "btn_lunch_exit";
            this.btn_lunch_exit.Size = new System.Drawing.Size(98, 49);
            this.btn_lunch_exit.TabIndex = 5;
            this.btn_lunch_exit.Text = "Exit";
            this.btn_lunch_exit.UseVisualStyleBackColor = true;
            this.btn_lunch_exit.Click += new System.EventHandler(this.btn_lunch_exit_Click);
            // 
            // btn_lunch_why
            // 
            this.btn_lunch_why.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_lunch_why.BackgroundImage")));
            this.btn_lunch_why.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_lunch_why.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btn_lunch_why.Location = new System.Drawing.Point(593, 294);
            this.btn_lunch_why.Name = "btn_lunch_why";
            this.btn_lunch_why.Size = new System.Drawing.Size(98, 52);
            this.btn_lunch_why.TabIndex = 4;
            this.btn_lunch_why.Text = "Why";
            this.btn_lunch_why.UseVisualStyleBackColor = true;
            this.btn_lunch_why.Click += new System.EventHandler(this.btn_lunch_why_Click);
            // 
            // lb_lunch
            // 
            this.lb_lunch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lb_lunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lb_lunch.FormattingEnabled = true;
            this.lb_lunch.ItemHeight = 20;
            this.lb_lunch.Items.AddRange(new object[] {
            "Chocolate",
            "Coconut",
            "Honey",
            "Spinaches",
            "Garlic",
            "Bananas",
            "Chili pepper",
            "Eggs",
            "Yogurt",
            "Fishes",
            "The nuts"});
            this.lb_lunch.Location = new System.Drawing.Point(75, 237);
            this.lb_lunch.Name = "lb_lunch";
            this.lb_lunch.Size = new System.Drawing.Size(478, 164);
            this.lb_lunch.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(13, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(493, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "→ Please ! check one item to see the reason why ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.lbl_lunch);
            this.groupBox2.Location = new System.Drawing.Point(6, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(708, 73);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // lbl_lunch
            // 
            this.lbl_lunch.AutoSize = true;
            this.lbl_lunch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_lunch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_lunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lunch.Location = new System.Drawing.Point(8, 10);
            this.lbl_lunch.Name = "lbl_lunch";
            this.lbl_lunch.Size = new System.Drawing.Size(692, 62);
            this.lbl_lunch.TabIndex = 0;
            this.lbl_lunch.Text = "Lunch is an important meal of a day, Food is what give you energy. Lunch raises y" +
    "our\r\nblood sugar level in the middle of the day, making you be able to focus for" +
    " the rest of \r\nafternoon";
            this.lbl_lunch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Lunch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(747, 504);
            this.Controls.Add(this.groupBox1);
            this.Name = "Lunch";
            this.Text = "Lunch";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_lunch_exit;
        private System.Windows.Forms.Button btn_lunch_why;
        private System.Windows.Forms.ListBox lb_lunch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_lunch;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}