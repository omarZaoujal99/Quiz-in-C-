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
    public partial class Night : Form
    {
        public Night()
        {
            InitializeComponent();
        }

        private void btn_niclose_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("are you want to close the app ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ans.ToString() == "Yes")
            {
                Application.Exit();
            }
        }

        private void btn_niback_Click(object sender, EventArgs e)
        {
            {
                if (rb_nidinner.Checked)
                {
                    Form second = new second();
                    second.Show();
                    this.Hide();
                }
                else if (rb_nimovie.Checked)
                {
                    Form second = new second();
                    second.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("You didn't choose");
                }
            }
        }

        private void btn_ninext_Click(object sender, EventArgs e)
        {

            if (rb_nidinner.Checked)
            {
                Form Dinnernight = new Dinnernight();
                Dinnernight.Show();
                this.Hide();
            }
            else if (rb_nimovie.Checked)
            {
                Form nifmovies = new nifmovies();
                nifmovies.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You didn't choose");
            }
        }
    }
}
