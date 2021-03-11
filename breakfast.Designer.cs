namespace Quiz
{
    partial class breakfast
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(breakfast));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_efd_glad_exit = new System.Windows.Forms.Button();
            this.btn_efd_glad_why = new System.Windows.Forms.Button();
            this.lb_efd_glad = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_efd2glad1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.btn_efd_glad_exit);
            this.groupBox1.Controls.Add(this.btn_efd_glad_why);
            this.groupBox1.Controls.Add(this.lb_efd_glad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl_efd2glad1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(10, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(733, 471);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btn_efd_glad_exit
            // 
            this.btn_efd_glad_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_efd_glad_exit.BackgroundImage")));
            this.btn_efd_glad_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_efd_glad_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btn_efd_glad_exit.Location = new System.Drawing.Point(593, 352);
            this.btn_efd_glad_exit.Name = "btn_efd_glad_exit";
            this.btn_efd_glad_exit.Size = new System.Drawing.Size(98, 49);
            this.btn_efd_glad_exit.TabIndex = 5;
            this.btn_efd_glad_exit.Text = "Exit";
            this.btn_efd_glad_exit.UseVisualStyleBackColor = true;
            this.btn_efd_glad_exit.Click += new System.EventHandler(this.btn_efd_glad_exit_Click);
            // 
            // btn_efd_glad_why
            // 
            this.btn_efd_glad_why.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_efd_glad_why.BackgroundImage")));
            this.btn_efd_glad_why.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_efd_glad_why.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btn_efd_glad_why.Location = new System.Drawing.Point(593, 294);
            this.btn_efd_glad_why.Name = "btn_efd_glad_why";
            this.btn_efd_glad_why.Size = new System.Drawing.Size(98, 52);
            this.btn_efd_glad_why.TabIndex = 4;
            this.btn_efd_glad_why.Text = "Why";
            this.btn_efd_glad_why.UseVisualStyleBackColor = true;
            this.btn_efd_glad_why.Click += new System.EventHandler(this.btn_efd_glad_why_Click);
            // 
            // lb_efd_glad
            // 
            this.lb_efd_glad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lb_efd_glad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lb_efd_glad.FormattingEnabled = true;
            this.lb_efd_glad.ItemHeight = 20;
            this.lb_efd_glad.Items.AddRange(new object[] {
            "Starches",
            "Chocolates",
            "Coconut",
            "Honey",
            "Bananas",
            "Eggs",
            "Yogurt",
            "Oats",
            "Avocado",
            "Coffee"});
            this.lb_efd_glad.Location = new System.Drawing.Point(74, 237);
            this.lb_efd_glad.Name = "lb_efd_glad";
            this.lb_efd_glad.Size = new System.Drawing.Size(478, 164);
            this.lb_efd_glad.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(13, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(493, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "→ Please ! check one item to see the reason why ";
            // 
            // lbl_efd2glad1
            // 
            this.lbl_efd2glad1.AutoSize = true;
            this.lbl_efd2glad1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_efd2glad1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_efd2glad1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_efd2glad1.Location = new System.Drawing.Point(42, 35);
            this.lbl_efd2glad1.Name = "lbl_efd2glad1";
            this.lbl_efd2glad1.Size = new System.Drawing.Size(641, 42);
            this.lbl_efd2glad1.TabIndex = 0;
            this.lbl_efd2glad1.Text = "Dear Mr or Ms, the breakfast is th eimportant meal in the day, we are taking\r\n ca" +
    "re about this thing so we found you much foods that enhance your gladness";
            this.lbl_efd2glad1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Location = new System.Drawing.Point(18, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(696, 73);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // breakfast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(753, 487);
            this.Controls.Add(this.groupBox1);
            this.Name = "breakfast";
            this.Text = "breakfast";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_efd_glad_exit;
        private System.Windows.Forms.Button btn_efd_glad_why;
        private System.Windows.Forms.ListBox lb_efd_glad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_efd2glad1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}