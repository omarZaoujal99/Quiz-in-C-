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
    public partial class SportNoon : Form
    {
        public SportNoon()
        {
            InitializeComponent();
        }

        private void btn_why_noons_Click(object sender, EventArgs e)
        {
            if (cb_noons.SelectedItem.ToString() == "Soccer")
            {
                //Label lbl_ms_swimming = new Label();
                //lbl_ms_swimming.Name = "lbl_ms_swimming";
                //lbl_ms_swimming.Text = "Swimming is a great workout because you need \n" +
                //    "to move your whole body against \n" +
                //    "the resistance of the water. ... keeps your heart rate up \n" +
                //    " but takes some of the impact stress off\n" +
                //    " your body. builds endurance, muscle strength and\n " +
                //    "cardiovascular fitness. helps maintain a healthy weight,\n" +
                //    " healthy heart and lungs.29 août 2013";
                //lbl_ms_swimming.Location = new Point(80, 50);
                //lbl_ms_swimming.AutoSize = true;
                //lbl_ms_swimming.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                //lbl_ms_swimming.TextAlign = ContentAlignment.MiddleCenter;

                //gb_noonsport.Controls.Add(lbl_ms_swimming);
                lblsn.Text = "It is very hard to put into words all the benefits \n" +
                        "soccer has. Specially for me as a soccer player, that has\n" +
                        " learned everything in life with a soccer ball in his feet.\n" +
                        " Soccer players, coaches, and fans are the most passionate\n" +
                        " people for their sport in the whole planet. If you are going to\n" +
                        " read an article about this topic, surely, it has to be from \n" +
                        "someone who has lived, played, and sacrificed for this sport.";
            }
            else if (cb_noons.SelectedItem.ToString() == "BasketBall")
            {
                //Label lbl_ms_running = new Label();
                //lbl_ms_running.Name = "lbl_ms_running";
                //lbl_ms_running.Text = "Everyone knows that running is a great way to get \n" +
                //    "into shape, but it also can benefit almost every part of your bod\n " +
                //    "and lift your mood. Whether it's your favorite part of the day or \n" +
                //    " something you have to push yourself through, the benefits\n" +
                //    " are undeniable.";
                //lbl_ms_running.Location = new Point(80, 50);
                //lbl_ms_running.AutoSize = true;
                //lbl_ms_running.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                //lbl_ms_running.TextAlign = ContentAlignment.MiddleCenter;

                //gb_noonsport.Controls.Add(lbl_ms_running);
                lblsn.Text = "just because :\n" +
                        "Burns Calories. ...\n" +
                        "Builds Bone Strength. ...\n" +
                        "Develops Self-Discipline And Concentration.\n" +
                        "Boosts Mental Development.";
            }
            else if (cb_noons.SelectedItem.ToString() == "Tennis")
            {
                //Label lbl_ms_wfad = new Label();
                //lbl_ms_wfad.Name = "lbl_ms_wfad";
                //lbl_ms_wfad.Text = "Walking is a great way to improve or maintain \n" +
                //    "your overall health. Just 30 minutes every day can increase\n" +
                //    " cardiovascular fitness, strengthen bones,\n" +
                //    " reduce excess body fat, and boost muscle power and endurance.\n " +
                //    "It can also reduce your risk of developing conditions such\n" +
                //    " as heart disease, type 2 diabetes, osteoporosis and some cancers.\n" +
                //    " Unlike some other forms of exercise, walking is free and \n" +
                //    "doesn’t require any special equipment or training.";
                //lbl_ms_wfad.Location = new Point(80, 50);
                //lbl_ms_wfad.AutoSize = true;
                //lbl_ms_wfad.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                //lbl_ms_wfad.TextAlign = ContentAlignment.MiddleCenter;

                //gb_noonsport.Controls.Add(lbl_ms_wfad);
                lblsn.Text = "Tennis can be a great workout and lots of fun. Playing \n" +
                        "tennis has many health benefits including:\n" +
                        "lowering resting heart rate and blood pressure\n" +
                        "improving metabolic function\n" +
                        "improving muscle tone, strength and flexibility";
            }
            else if (cb_noons.SelectedItem.ToString() == "HandBall")
            {
                //Label lbl_ms_db = new Label();
                //lbl_ms_db.Name = "lbl_ms_db";
                //lbl_ms_db.Text = "The act of riding a bike is probably as simple\n" +
                //    " as walking itself, but the opportunities offered by\n" +
                //    " churning those pedals are extremely varied that the bike sports\n" +
                //    " available to us require equipment specificity.\n" +
                //    "while you move all you body when you drive a bike";
                //lbl_ms_db.Location = new Point(80, 50);
                //lbl_ms_db.AutoSize = true;
                //lbl_ms_db.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                //lbl_ms_db.TextAlign = ContentAlignment.MiddleCenter;

                //gb_noonsport.Controls.Add(lbl_ms_db);
                lblsn.Text = "Playing handball has a number of health and fitness benefits,\n" +
                        " including the following:\n" +
                        "Improves arm muscles and upper body strength.\n" +
                        "Develops agility of hands and feet, with sudden changes of pace\n" +
                        " and direction required.\n" +
                        "Boosts the body's flexibility.";
            }
            else
            {
                MessageBox.Show("You didn't choose");
            }
        }

        private void btn_exit_noons_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("are you want to close the app ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ans.ToString() == "Yes")
            {
                Application.Exit();
            }
        }
    }
}
