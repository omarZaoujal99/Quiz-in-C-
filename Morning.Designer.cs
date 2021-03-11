namespace Quiz
{
    partial class Morning
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Morning));
            this.rb_morning_breakfast = new System.Windows.Forms.RadioButton();
            this.rb_morning_sport = new System.Windows.Forms.RadioButton();
            this.btn_mnext = new System.Windows.Forms.Button();
            this.btn_mclose = new System.Windows.Forms.Button();
            this.btn_mback = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rb_morning_breakfast
            // 
            this.rb_morning_breakfast.AutoSize = true;
            this.rb_morning_breakfast.BackgroundImage = global::Quiz.Properties.Resources._1092716;
            this.rb_morning_breakfast.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.rb_morning_breakfast.Location = new System.Drawing.Point(198, 254);
            this.rb_morning_breakfast.Name = "rb_morning_breakfast";
            this.rb_morning_breakfast.Size = new System.Drawing.Size(121, 29);
            this.rb_morning_breakfast.TabIndex = 0;
            this.rb_morning_breakfast.TabStop = true;
            this.rb_morning_breakfast.Text = "Breakfast";
            this.rb_morning_breakfast.UseVisualStyleBackColor = true;
            // 
            // rb_morning_sport
            // 
            this.rb_morning_sport.AutoSize = true;
            this.rb_morning_sport.BackgroundImage = global::Quiz.Properties.Resources._1092716;
            this.rb_morning_sport.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.rb_morning_sport.Location = new System.Drawing.Point(369, 254);
            this.rb_morning_sport.Name = "rb_morning_sport";
            this.rb_morning_sport.Size = new System.Drawing.Size(81, 29);
            this.rb_morning_sport.TabIndex = 2;
            this.rb_morning_sport.TabStop = true;
            this.rb_morning_sport.Text = "Sport";
            this.rb_morning_sport.UseVisualStyleBackColor = true;
            // 
            // btn_mnext
            // 
            this.btn_mnext.BackgroundImage = global::Quiz.Properties.Resources._1092716;
            this.btn_mnext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_mnext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btn_mnext.Location = new System.Drawing.Point(513, 327);
            this.btn_mnext.Name = "btn_mnext";
            this.btn_mnext.Size = new System.Drawing.Size(97, 51);
            this.btn_mnext.TabIndex = 3;
            this.btn_mnext.Text = "Next";
            this.btn_mnext.UseVisualStyleBackColor = true;
            this.btn_mnext.Click += new System.EventHandler(this.btn_next_morning_1_Click);
            // 
            // btn_mclose
            // 
            this.btn_mclose.BackgroundImage = global::Quiz.Properties.Resources._1092716;
            this.btn_mclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_mclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btn_mclose.Location = new System.Drawing.Point(248, 327);
            this.btn_mclose.Name = "btn_mclose";
            this.btn_mclose.Size = new System.Drawing.Size(99, 51);
            this.btn_mclose.TabIndex = 4;
            this.btn_mclose.Text = "Close";
            this.btn_mclose.UseVisualStyleBackColor = true;
            this.btn_mclose.Click += new System.EventHandler(this.btn_mclose_Click);
            // 
            // btn_mback
            // 
            this.btn_mback.BackgroundImage = global::Quiz.Properties.Resources._1092716;
            this.btn_mback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_mback.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btn_mback.Location = new System.Drawing.Point(386, 327);
            this.btn_mback.Name = "btn_mback";
            this.btn_mback.Size = new System.Drawing.Size(97, 51);
            this.btn_mback.TabIndex = 5;
            this.btn_mback.Text = "Back";
            this.btn_mback.UseVisualStyleBackColor = true;
            this.btn_mback.Click += new System.EventHandler(this.btn_mback_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::Quiz.Properties.Resources._1092716;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rb_morning_breakfast);
            this.groupBox1.Controls.Add(this.rb_morning_sport);
            this.groupBox1.Controls.Add(this.btn_mclose);
            this.groupBox1.Controls.Add(this.btn_mback);
            this.groupBox1.Controls.Add(this.btn_mnext);
            this.groupBox1.Location = new System.Drawing.Point(33, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(674, 418);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupBox2.BackgroundImage = global::Quiz.Properties.Resources._1092716;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(649, 144);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(636, 102);
            this.label1.TabIndex = 8;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label2.Location = new System.Drawing.Point(69, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "→ So you wanna help from :";
            // 
            // Morning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Quiz.Properties.Resources._1092716;
            this.ClientSize = new System.Drawing.Size(741, 478);
            this.Controls.Add(this.groupBox1);
            this.Name = "Morning";
            this.Text = "Morning";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_morning_breakfast;
        private System.Windows.Forms.RadioButton rb_morning_sport;
        private System.Windows.Forms.Button btn_mnext;
        private System.Windows.Forms.Button btn_mclose;
        private System.Windows.Forms.Button btn_mback;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
    }
}