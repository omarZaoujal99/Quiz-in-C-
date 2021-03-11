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
    public partial class nifmovies : Form
    {
        public nifmovies()
        {
            InitializeComponent();
        }

        private void btn_nifm_close_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("are you want to close the app ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ans.ToString() == "Yes")
            {
                Application.Exit();
            }
        }

        private void btn_nifm_back_Click(object sender, EventArgs e)
        {
            if (rb_nifm_angry.Checked)
            {
                Form Night = new Night();
                Night.Show();
                this.Hide();
            }
            else if (rb_nifm_depressed.Checked)
            {
                Form Night = new Night();
                Night.Show();
                this.Hide();
            }
            else if (rb_nifm_glad.Checked)
            {
                Form Night = new Night();
                Night.Show();
                this.Hide();
            }
            else if (rb_nifm_normal.Checked)
            {
                Form Night = new Night();
                Night.Show();
                this.Hide();
            }
            else if (rb_nifm_optimistic.Checked)
            {
                Form Night = new Night();
                Night.Show();
                this.Hide();
            }
            else if (rb_nifm_sad.Checked)
            {
                Form Night = new Night();
                Night.Show();
                this.Hide();
            }
            else MessageBox.Show("You didn't choose");
        }

        private void btn_nifm_next_Click(object sender, EventArgs e)
        {
            if (rb_nifm_angry.Checked)
            {
                Form MovieAngry = new MovieAngry();
                MovieAngry.Show();
                this.Hide();
            }
            else if (rb_nifm_depressed.Checked)
            {
                Form dp = new depressed_evening_movie();
                dp.Show();
                this.Hide();
            }
            else if (rb_nifm_glad.Checked)
            {
                Form MovieGlad = new MoviesGlad();
                MovieGlad.Show();
                this.Hide();
            }
            else if (rb_nifm_normal.Checked)
            {
                Form MovieNormal = new MovieNormal();
                MovieNormal.Show();
                this.Hide();
            }
            else if (rb_nifm_sad.Checked)
            {
                Form MovieSad = new MovieSad();
                MovieSad.Show();
                this.Hide();
            }
            else if (rb_nifm_optimistic.Checked)
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

        private void nifmovies_Load(object sender, EventArgs e)
        {

        }
    }
}
