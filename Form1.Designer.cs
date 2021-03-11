namespace Quiz
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pb_1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.tb_1 = new System.Windows.Forms.TextBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_quit = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_1
            // 
            this.pb_1.ForeColor = System.Drawing.Color.Red;
            this.pb_1.Location = new System.Drawing.Point(61, 353);
            this.pb_1.Name = "pb_1";
            this.pb_1.Size = new System.Drawing.Size(624, 23);
            this.pb_1.TabIndex = 4;
            this.pb_1.Click += new System.EventHandler(this.pb_1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 127);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome to our application !! \r\nwe gonna give you much opinions about the \r\ndaily" +
    " meals, sports and movies \r\nwe wish you can get you help from here \r\nenjoy...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::Quiz.Properties.Resources._1092716;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lbl_1);
            this.groupBox2.Controls.Add(this.tb_1);
            this.groupBox2.Controls.Add(this.btn_start);
            this.groupBox2.Controls.Add(this.btn_quit);
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(713, 394);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lbl_1.Location = new System.Drawing.Point(70, 190);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(188, 26);
            this.lbl_1.TabIndex = 0;
            this.lbl_1.Text = "enter your full name :";
            // 
            // tb_1
            // 
            this.tb_1.Location = new System.Drawing.Point(286, 195);
            this.tb_1.Name = "tb_1";
            this.tb_1.Size = new System.Drawing.Size(372, 20);
            this.tb_1.TabIndex = 1;
            // 
            // btn_start
            // 
            this.btn_start.BackgroundImage = global::Quiz.Properties.Resources._1092716;
            this.btn_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btn_start.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_start.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_start.Location = new System.Drawing.Point(338, 248);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(159, 61);
            this.btn_start.TabIndex = 3;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_quit
            // 
            this.btn_quit.BackgroundImage = global::Quiz.Properties.Resources._1092716;
            this.btn_quit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btn_quit.Location = new System.Drawing.Point(157, 248);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(157, 61);
            this.btn_quit.TabIndex = 2;
            this.btn_quit.Text = "Quit";
            this.btn_quit.UseVisualStyleBackColor = true;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(738, 419);
            this.Controls.Add(this.pb_1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "OZ-Guiding";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ProgressBar pb_1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.TextBox tb_1;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_quit;
    }
}

