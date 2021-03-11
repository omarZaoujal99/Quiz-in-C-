namespace Quiz
{
    partial class second
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
            this.btn_next = new System.Windows.Forms.Button();
            this.rb_morning = new System.Windows.Forms.RadioButton();
            this.rb_evening = new System.Windows.Forms.RadioButton();
            this.rb_noon = new System.Windows.Forms.RadioButton();
            this.rb_night = new System.Windows.Forms.RadioButton();
            this.btn_close = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_next
            // 
            this.btn_next.BackgroundImage = global::Quiz.Properties.Resources._1092716;
            this.btn_next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btn_next.Location = new System.Drawing.Point(522, 339);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(125, 54);
            this.btn_next.TabIndex = 0;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // rb_morning
            // 
            this.rb_morning.AutoSize = true;
            this.rb_morning.BackgroundImage = global::Quiz.Properties.Resources._1092716;
            this.rb_morning.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.rb_morning.Location = new System.Drawing.Point(218, 121);
            this.rb_morning.Name = "rb_morning";
            this.rb_morning.Size = new System.Drawing.Size(98, 28);
            this.rb_morning.TabIndex = 1;
            this.rb_morning.TabStop = true;
            this.rb_morning.Text = "Morning";
            this.rb_morning.UseVisualStyleBackColor = true;
            // 
            // rb_evening
            // 
            this.rb_evening.AutoSize = true;
            this.rb_evening.BackgroundImage = global::Quiz.Properties.Resources._1092716;
            this.rb_evening.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.rb_evening.Location = new System.Drawing.Point(218, 216);
            this.rb_evening.Name = "rb_evening";
            this.rb_evening.Size = new System.Drawing.Size(98, 28);
            this.rb_evening.TabIndex = 2;
            this.rb_evening.TabStop = true;
            this.rb_evening.Text = "Evening";
            this.rb_evening.UseVisualStyleBackColor = true;
            // 
            // rb_noon
            // 
            this.rb_noon.AutoSize = true;
            this.rb_noon.BackgroundImage = global::Quiz.Properties.Resources._1092716;
            this.rb_noon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.rb_noon.Location = new System.Drawing.Point(218, 170);
            this.rb_noon.Name = "rb_noon";
            this.rb_noon.Size = new System.Drawing.Size(75, 28);
            this.rb_noon.TabIndex = 3;
            this.rb_noon.TabStop = true;
            this.rb_noon.Text = "Noon";
            this.rb_noon.UseVisualStyleBackColor = true;
            this.rb_noon.CheckedChanged += new System.EventHandler(this.rb_noon_CheckedChanged);
            // 
            // rb_night
            // 
            this.rb_night.AutoSize = true;
            this.rb_night.BackgroundImage = global::Quiz.Properties.Resources._1092716;
            this.rb_night.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.rb_night.Location = new System.Drawing.Point(218, 259);
            this.rb_night.Name = "rb_night";
            this.rb_night.Size = new System.Drawing.Size(72, 28);
            this.rb_night.TabIndex = 4;
            this.rb_night.TabStop = true;
            this.rb_night.Text = "Night";
            this.rb_night.UseVisualStyleBackColor = true;
            // 
            // btn_close
            // 
            this.btn_close.BackgroundImage = global::Quiz.Properties.Resources._1092716;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btn_close.Location = new System.Drawing.Point(356, 339);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(132, 54);
            this.btn_close.TabIndex = 5;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::Quiz.Properties.Resources._1092716;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rb_morning);
            this.groupBox1.Controls.Add(this.rb_noon);
            this.groupBox1.Controls.Add(this.rb_night);
            this.groupBox1.Controls.Add(this.rb_evening);
            this.groupBox1.Location = new System.Drawing.Point(34, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 396);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "we need to know what\'s the time now :";
            // 
            // second
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Quiz.Properties.Resources._1092716;
            this.ClientSize = new System.Drawing.Size(734, 450);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.groupBox1);
            this.Name = "second";
            this.Text = "second";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.RadioButton rb_morning;
        private System.Windows.Forms.RadioButton rb_evening;
        private System.Windows.Forms.RadioButton rb_noon;
        private System.Windows.Forms.RadioButton rb_night;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}