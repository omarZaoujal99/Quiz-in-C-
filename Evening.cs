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
    public partial class Evening : Form
    {
        public Evening()
        {
            InitializeComponent();
        }

        private void btn_eclose_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("are you want to close the app ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ans.ToString() == "Yes")
            {
                Application.Exit();
            }
        }

        private void btn_enext_Click(object sender, EventArgs e)
        {
            if (rb_edinner.Checked)
            {
                Form Dinnerev = new Dinnerev();
                Dinnerev.Show();
                this.Hide();
            }
            else if (rb_emovie.Checked)
            {
                Form efmovie = new efmovie();
                efmovie.Show();
                this.Hide();
            }
            else if (rb_esport.Checked)
            {
                Form SportEvening = new SportEvening();
                SportEvening.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You didn't choose");
            }
        }

        private void btn_eback_Click(object sender, EventArgs e)
        {
            if (rb_edinner.Checked)
            {
                Form second = new second();
                second.Show();
                this.Hide();
            }
            else if (rb_emovie.Checked)
            {
                Form second = new second();
                second.Show();
                this.Hide();
            }
            else if (rb_esport.Checked)
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
}
