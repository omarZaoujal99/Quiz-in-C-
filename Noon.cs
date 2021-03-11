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
    public partial class Noon : Form
    {
        public Noon()
        {
            InitializeComponent();
        }

        private void btn_nclose_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("are you want to close the app ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ans.ToString() == "Yes")
            {
                Application.Exit();
            }
        }

        private void btn_nback_Click(object sender, EventArgs e)
        {
            {
                if (rb_nlunch.Checked)
                {
                    Form second = new second();
                    second.Show();
                    this.Hide();
                }

                else if (rb_nsport.Checked)
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

        private void btn_nnext_Click(object sender, EventArgs e)
        {
            if (rb_nlunch.Checked)
            {
                Form Lunch = new Lunch();
                Lunch.Show();
                this.Hide();
            }

            else if (rb_nsport.Checked)
            {
                Form SportNoon = new SportNoon();
                SportNoon.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You didn't choose");
            }
        }
    }
}
