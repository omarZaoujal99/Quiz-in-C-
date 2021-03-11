namespace Quiz
{
    partial class Evening
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Evening));
            this.rb_edinner = new System.Windows.Forms.RadioButton();
            this.rb_emovie = new System.Windows.Forms.RadioButton();
            this.rb_esport = new System.Windows.Forms.RadioButton();
            this.btn_eclose = new System.Windows.Forms.Button();
            this.btn_eback = new System.Windows.Forms.Button();
            this.btn_enext = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rb_edinner
            // 
            this.rb_edinner.AutoSize = true;
            this.rb_edinner.BackgroundImage = global::Quiz.Properties.Resources._1092716;
            this.rb_edinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.rb_edinner.Location = new System.Drawing.Point(184, 267);
            this.rb_edinner.Name = "rb_edinner";
            this.rb_edinner.Size = new System.Drawing.Size(93, 29);
            this.rb_edinner.TabIndex = 0;
            this.rb_edinner.TabStop = true;
            this.rb_edinner.Text = "Dinner";
            this.rb_edinner.UseVisualStyleBackColor = true;
            // 
            // rb_emovie
            // 
            this.rb_emovie.AutoSize = true;
            this.rb_emovie.BackgroundImage = global::Quiz.Properties.Resources._1092716;
            this.rb_emovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.rb_emovie.Location = new System.Drawing.Point(462, 267);
            this.rb_emovie.Name = "rb_emovie";
            this.rb_emovie.Size = new System.Drawing.Size(88, 29);
            this.rb_emovie.TabIndex = 1;
            this.rb_emovie.TabStop = true;
            this.rb_emovie.Text = "Movie";
            this.rb_emovie.UseVisualStyleBackColor = true;
            // 
            // rb_esport
            // 
            this.rb_esport.AutoSize = true;
            this.rb_esport.BackgroundImage = global::Quiz.Properties.Resources._1092716;
            this.rb_esport.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.rb_esport.Location = new System.Drawing.Point(337, 267);
            this.rb_esport.Name = "rb_esport";
            this.rb_esport.Size = new System.Drawing.Size(81, 29);
            this.rb_esport.TabIndex = 2;
            this.rb_esport.TabStop = true;
            this.rb_esport.Text = "Sport";
            this.rb_esport.UseVisualStyleBackColor = true;
            // 
            // btn_eclose
            // 
            this.btn_eclose.BackgroundImage = global::Quiz.Properties.Resources._1092716;
            this.btn_eclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_eclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btn_eclose.Location = new System.Drawing.Point(220, 325);
            this.btn_eclose.Name = "btn_eclose";
            this.btn_eclose.Size = new System.Drawing.Size(117, 56);
            this.btn_eclose.TabIndex = 3;
            this.btn_eclose.Text = "Close";
            this.btn_eclose.UseVisualStyleBackColor = true;
            this.btn_eclose.Click += new System.EventHandler(this.btn_eclose_Click);
            // 
            // btn_eback
            // 
            this.btn_eback.BackgroundImage = global::Quiz.Properties.Resources._1092716;
            this.btn_eback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_eback.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btn_eback.Location = new System.Drawing.Point(367, 325);
            this.btn_eback.Name = "btn_eback";
            this.btn_eback.Size = new System.Drawing.Size(117, 56);
            this.btn_eback.TabIndex = 4;
            this.btn_eback.Text = "Back";
            this.btn_eback.UseVisualStyleBackColor = true;
            this.btn_eback.Click += new System.EventHandler(this.btn_eback_Click);
            // 
            // btn_enext
            // 
            this.btn_enext.BackgroundImage = global::Quiz.Properties.Resources._1092716;
            this.btn_enext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_enext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btn_enext.Location = new System.Drawing.Point(505, 325);
            this.btn_enext.Name = "btn_enext";
            this.btn_enext.Size = new System.Drawing.Size(117, 56);
            this.btn_enext.TabIndex = 5;
            this.btn_enext.Text = "Next";
            this.btn_enext.UseVisualStyleBackColor = true;
            this.btn_enext.Click += new System.EventHandler(this.btn_enext_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::Quiz.Properties.Resources._1092716;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rb_edinner);
            this.groupBox1.Controls.Add(this.rb_emovie);
            this.groupBox1.Controls.Add(this.rb_esport);
            this.groupBox1.Controls.Add(this.btn_eclose);
            this.groupBox1.Controls.Add(this.btn_eback);
            this.groupBox1.Controls.Add(this.btn_enext);
            this.groupBox1.Location = new System.Drawing.Point(28, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(677, 423);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::Quiz.Properties.Resources._1092716;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(17, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(642, 144);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(580, 102);
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
            this.label2.Location = new System.Drawing.Point(41, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "→ So you wanna help from :";
            // 
            // Evening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Quiz.Properties.Resources._1092716;
            this.ClientSize = new System.Drawing.Size(735, 473);
            this.Controls.Add(this.groupBox1);
            this.Name = "Evening";
            this.Text = "Evening";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_edinner;
        private System.Windows.Forms.RadioButton rb_emovie;
        private System.Windows.Forms.RadioButton rb_esport;
        private System.Windows.Forms.Button btn_eclose;
        private System.Windows.Forms.Button btn_eback;
        private System.Windows.Forms.Button btn_enext;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
    }
}