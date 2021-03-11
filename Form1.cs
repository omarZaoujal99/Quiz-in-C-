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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if(tb_1.Text.Length > 3)
            {
                btn_start.Enabled = true;
                string player = tb_1.Text;
                MessageBox.Show("Welcome " + player +", let's start !!");

                this.timer1.Start();
            }
            else
            {
                MessageBox.Show("Your name is short, please enter a name more than 4 latters");
            }
        }

        private void pb_1_Click(object sender, EventArgs e)
        {
            pb_1.Maximum = 100;
            pb_1.Minimum =0;
            pb_1.Step = 1;
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.pb_1.Increment(1);
            pb_1.PerformStep(); 
            if(pb_1.Value == 100)
            {
                timer1.Enabled = false;
                Form second = new second();
                second.Show();
                this.Hide();
            }
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("are you want to close the app ?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(ans.ToString()== "Yes")
            {
                Application.Exit();
            }

        }
    }
}
