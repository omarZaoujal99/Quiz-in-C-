using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class SportEvening : Form
    {
        public SportEvening()
        {
            InitializeComponent();
        }
        public void Actualiser()
        {
            
        }
        private void btn_why_evenings_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_evenings.SelectedItem.ToString() == "Soccer")
                {
                    //Label lbl_se_soccer = new Label();
                    //lbl_se_soccer.Name = "lbl_se_soccer";
                    //lbl_se_soccer.Text = "It is very hard to put into words all the benefits \n" +
                    //    "soccer has. Specially for me as a soccer player, that has\n" +
                    //    " learned everything in life with a soccer ball in his feet.\n" +
                    //    " Soccer players, coaches, and fans are the most passionate\n" +
                    //    " people for their sport in the whole planet. If you are going to\n" +
                    //    " read an article about this topic, surely, it has to be from \n" +
                    //    "someone who has lived, played, and sacrificed for this sport.";
                    //lbl_se_soccer.Location = new Point(80, 50);
                    //lbl_se_soccer.AutoSize = true;
                    //lbl_se_soccer.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                    //lbl_se_soccer.TextAlign = ContentAlignment.MiddleCenter;

                    //gb_eveningsport.Controls.Add(lbl_se_soccer);
                    lblse.Text = "It is very hard to put into words all the benefits \n" +
                        "soccer has. Specially for me as a soccer player, that has\n" +
                        " learned everything in life with a soccer ball in his feet.\n" +
                        " Soccer players, coaches, and fans are the most passionate\n" +
                        " people for their sport in the whole planet. If you are going to\n" +
                        " read an article about this topic, surely, it has to be from \n" +
                        "someone who has lived, played, and sacrificed for this sport.";
                }
                else if (cb_evenings.SelectedItem.ToString() == "BasketBall")
                {
                    //Label lbl_se_bb = new Label();
                    //lbl_se_bb.Name = "lbl_se_bb";
                    //lbl_se_bb.Text = "just because :\n" +
                    //    "Burns Calories. ...\n" +
                    //    "Builds Bone Strength. ...\n" +
                    //    "Develops Self-Discipline And Concentration.\n" +
                    //    "Boosts Mental Development. ...\n" +
                    //    "";
                    //lbl_se_bb.Location = new Point(80, 50);
                    //lbl_se_bb.AutoSize = true;
                    //lbl_se_bb.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                    //lbl_se_bb.TextAlign = ContentAlignment.MiddleCenter;

                    //gb_eveningsport.Controls.Add(lbl_se_bb);
                    lblse.Text = "just because :\n" +
                        "Burns Calories. ...\n" +
                        "Builds Bone Strength. ...\n" +
                        "Develops Self-Discipline And Concentration.\n" +
                        "Boosts Mental Development.";
                }
                else if (cb_evenings.SelectedItem.ToString() == "Tenis")
                {
                    //Label lbl_se_tenis = new Label();
                    //lbl_se_tenis.Name = "lbl_se_tenis";
                    //lbl_se_tenis.Text = "Tennis can be a great workout and lots of fun. Playing \n" +
                    //    "tennis has many health benefits including:\n" +
                    //    "lowering resting heart rate and blood pressure\n" +
                    //    "improving metabolic function\n" +
                    //    "improving muscle tone, strength and flexibility";
                    //lbl_se_tenis.Location = new Point(80, 50);
                    //lbl_se_tenis.AutoSize = true;
                    //lbl_se_tenis.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                    //lbl_se_tenis.TextAlign = ContentAlignment.MiddleCenter;

                    //this.Actualiser();
                    //gb_eveningsport.Controls.Add(lbl_se_tenis);
                    lblse.Text = "Tennis can be a great workout and lots of fun. Playing \n" +
                        "tennis has many health benefits including:\n" +
                        "lowering resting heart rate and blood pressure\n" +
                        "improving metabolic function\n" +
                        "improving muscle tone, strength and flexibility";
                }
                else if (cb_evenings.SelectedItem.ToString() == "HandBall")
                {
                    //Label lbl_se_hb = new Label();
                    //lbl_se_hb.Name = "lbl_se_hb";
                    //lbl_se_hb.Text = "Playing handball has a number of health and fitness benefits,\n" +
                    //    " including the following:\n" +
                    //    "Improves arm muscles and upper body strength.\n" +
                    //    "Develops agility of hands and feet, with sudden changes of pace\n" +
                    //    " and direction required.\n" +
                    //    "Boosts the body's flexibility.";
                    //lbl_se_hb.Location = new Point(80, 50);
                    //lbl_se_hb.AutoSize = true;
                    //lbl_se_hb.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                    //lbl_se_hb.TextAlign = ContentAlignment.MiddleCenter;

                    //this.Actualiser();
                    //gb_eveningsport.Controls.Add(lbl_se_hb);
                    lblse.Text = "Playing handball has a number of health and fitness benefits,\n" +
                        " including the following:\n" +
                        "Improves arm muscles and upper body strength.\n" +
                        "Develops agility of hands and feet, with sudden changes of pace\n" +
                        " and direction required.\n" +
                        "Boosts the body's flexibility.";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please ! choose from our list");
            }
        }

        private void btn_exit_evenings_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("are you want to close the app ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ans.ToString() == "Yes")
            {
                Application.Exit();
            }
        }
    }
}
