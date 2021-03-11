namespace Quiz
{
    partial class Noon
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
            this.rb_nlunch = new System.Windows.Forms.RadioButton();
            this.rb_nsport = new System.Windows.Forms.RadioButton();
            this.btn_nclose = new System.Windows.Forms.Button();
            this.btn_nback = new System.Windows.Forms.Button();
            this.btn_nnext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rb_nlunch
            // 
            this.rb_nlunch.AutoSize = true;
            this.rb_nlunch.BackgroundImage = global::Quiz.Properties.Resources._1092716;
            this.rb_nlunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.rb_nlunch.Location = new System.Drawing.Point(212, 225);
            this.rb_nlunch.Name = "rb_nlunch";
            this.rb_nlunch.Size = new System.Drawing.Size(89, 29);
            this.rb_nlunch.TabIndex = 0;
            this.rb_nlunch.TabStop = true;
            this.rb_nlunch.Text = "Lunch";
            this.rb_nlunch.UseVisualStyleBackColor = true;
            // 
            // rb_nsport
            // 
            this.rb_nsport.AutoSize = true;
            this.rb_nsport.BackgroundImage = global::Quiz.Properties.Resources._1092716;
            this.rb_nsport.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.rb_nsport.Location = new System.Drawing.Point(349, 225);
            this.rb_nsport.Name = "rb_nsport";
            this.rb_nsport.Size = new System.Drawing.Size(81, 29);
            this.rb_nsport.TabIndex = 2;
            this.rb_nsport.TabStop = true;
            this.rb_nsport.Text = "Sport";
            this.rb_nsport.UseVisualStyleBackColor = true;
            // 
            // btn_nclose
            // 
            this.btn_nclose.BackgroundImage = global::Quiz.Properties.Resources._1092716;
            this.btn_nclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btn_nclose.Location = new System.Drawing.Point(235, 315);
            this.btn_nclose.Name = "btn_nclose";
            this.btn_nclose.Size = new System.Drawing.Size(87, 41);
            this.btn_nclose.TabIndex = 3;
            this.btn_nclose.Text = "Close";
            this.btn_nclose.UseVisualStyleBackColor = true;
            this.btn_nclose.Click += new System.EventHandler(this.btn_nclose_Click);
            // 
            // btn_nback
            // 
            this.btn_nback.BackgroundImage = global::Quiz.Properties.Resources._1092716;
            this.btn_nback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nback.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btn_nback.Location = new System.Drawing.Point(359, 315);
            this.btn_nback.Name = "btn_nback";
            this.btn_nback.Size = new System.Drawing.Size(87, 41);
            this.btn_nback.TabIndex = 4;
            this.btn_nback.Text = "Back";
            this.btn_nback.UseVisualStyleBackColor = true;
            this.btn_nback.Click += new System.EventHandler(this.btn_nback_Click);
            // 
            // btn_nnext
            // 
            this.btn_nnext.BackgroundImage = global::Quiz.Properties.Resources._1092716;
            this.btn_nnext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nnext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btn_nnext.Location = new System.Drawing.Point(478, 315);
            this.btn_nnext.Name = "btn_nnext";
            this.btn_nnext.Size = new System.Drawing.Size(87, 41);
            this.btn_nnext.TabIndex = 5;
            this.btn_nnext.Text = "Next";
            this.btn_nnext.UseVisualStyleBackColor = true;
            this.btn_nnext.Click += new System.EventHandler(this.btn_nnext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(605, 77);
            this.label1.TabIndex = 6;
            this.label1.Text = "Noon is important time on the day, Maybe you have a much\r\nworks to do, or busy ab" +
    "out somethings, but maybe you want a\r\nhelp from us, we wish that we can  give yo" +
    "u this help";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::Quiz.Properties.Resources._1092716;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btn_nclose);
            this.groupBox1.Controls.Add(this.btn_nback);
            this.groupBox1.Controls.Add(this.btn_nnext);
            this.groupBox1.Controls.Add(this.rb_nsport);
            this.groupBox1.Controls.Add(this.rb_nlunch);
            this.groupBox1.Location = new System.Drawing.Point(33, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(666, 420);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label2.Location = new System.Drawing.Point(55, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "→ So you wanna help from :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::Quiz.Properties.Resources._1092716;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(24, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(626, 113);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // Noon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Quiz.Properties.Resources._1092716;
            this.ClientSize = new System.Drawing.Size(735, 476);
            this.Controls.Add(this.groupBox1);
            this.Name = "Noon";
            this.Text = "Noon";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_nlunch;
        private System.Windows.Forms.RadioButton rb_nsport;
        private System.Windows.Forms.Button btn_nclose;
        private System.Windows.Forms.Button btn_nback;
        private System.Windows.Forms.Button btn_nnext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}