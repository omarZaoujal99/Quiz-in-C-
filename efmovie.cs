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
    public partial class efmovie : Form
    {
        public efmovie()
        {
            InitializeComponent();
        }

        private void btn_efm_close_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("are you want to close the app ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ans.ToString() == "Yes")
            {
                Application.Exit();
            }
        }

        private void btn_efm_back_Click(object sender, EventArgs e)
        {
            if (rb_efm_angry.Checked)
            {
                Form Evening = new Evening();
                Evening.Show();
                this.Hide();
            }
            else if (rb_efm_depressed.Checked)
            {
                Form Evening = new Evening();
                Evening.Show();
                this.Hide();
            }
            else if (rb_efm_glad.Checked)
            {
                Form Evening = new Evening();
                Evening.Show();
                this.Hide();
            }
            else if (rb_efm_normal.Checked)
            {
                Form Evening = new Evening();
                Evening.Show();
                this.Hide();
            }
           
            else if (rb_efm_sad.Checked)
            {
                Form Evening = new Evening();
                Evening.Show();
                this.Hide();
            }
            else if (rb_efm_sick.Checked)
            {
                Form Evening = new Evening();
                Evening.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You didn't choose");
            }
        }

        private void btn_efm_next_Click(object sender, EventArgs e)
        {
            if (rb_efm_angry.Checked)
            {
                Form MovieAngry = new MovieAngry();
                MovieAngry.Show();
                this.Hide();
            }
            else if (rb_efm_depressed.Checked)
            {
                Form dp = new depressed_evening_movie();
                dp.Show();
                this.Hide();
            }
            else if (rb_efm_glad.Checked)
            {
                Form MovieGlad = new MoviesGlad();
                MovieGlad.Show();
                this.Hide();
            }
            else if (rb_efm_normal.Checked)
            {
                Form MovieNormal = new MovieNormal();
                MovieNormal.Show();
                this.Hide(); 
            }
            else if (rb_efm_sad.Checked)
            {
                Form MovieSad = new MovieSad();
                MovieSad.Show();
                this.Hide();
            }
            else if (rb_efm_sick.Checked)
            {
                Form MovieTired = new MovieTired();
                MovieTired.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You didn't choose");
            }
        }
    }
}
