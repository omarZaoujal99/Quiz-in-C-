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
    public partial class Morning : Form
    {
        public Morning()
        {
            InitializeComponent();
        }

        private void btn_next_morning_1_Click(object sender, EventArgs e)
        {
            if (rb_morning_sport.Checked)
            {
                Form SportMorning = new SportMorning();
                SportMorning.Show();
                this.Hide(); 
            }

            else if (rb_morning_breakfast.Checked)
            {
                Form Breakfast = new breakfast();
                Breakfast.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You didn't choose");
            }
        }

        private void btn_mback_Click(object sender, EventArgs e)
        {
            if (rb_morning_sport.Checked)
            {
                Form second = new second();
                second.Show();
                this.Hide();
            }

            else if (rb_morning_breakfast.Checked)
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

        private void btn_mclose_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("are you want to close the app ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ans.ToString() == "Yes")
            {
                Application.Exit();
            }
        }
    }
}
