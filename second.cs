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
    public partial class second : Form
    {
        public second()
        {
            InitializeComponent();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            Form Morning = new Morning();
            Form Noon = new Noon();
            Form Evening = new Evening();
            Form Night = new Night();

            if (rb_morning.Checked)
            {
                Morning.Show();
                this.Hide(); 
            }
            else if (rb_noon.Checked)
            {
                Noon.Show();
                this.Hide();
            }
            else if (rb_evening.Checked)
            {
                Evening.Show();
                this.Hide(); 
            }
            else if (rb_night.Checked)
            {
                Night.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You didn't choose");
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("are you want to close the app ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ans.ToString() == "Yes")
            {
                Application.Exit();
            }
        }

        private void rb_noon_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
