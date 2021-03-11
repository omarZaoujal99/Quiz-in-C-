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
    public partial class Lunch : Form
    {
        public Lunch()
        {
            InitializeComponent();
        }

        private void btn_lunch_why_Click(object sender, EventArgs e)
        {
            foreach (var item in lb_lunch.SelectedItems)
            {
                if (item.ToString() == "Chocolates")
                {
                    MessageBox.Show("Chocolates are considered to be a contributing factor in raising a person’s happiness, due to the caffeine that helps blood flow to the brain and stimulate it");
                }
                else if (item.ToString() == "Coconut")
                {
                    MessageBox.Show("There is no problem eating coconuts with breakfast, as it contains fats that help keep a person happy");
                }
                else if (item.ToString() == "Honey")
                {
                    MessageBox.Show("all we know how much honey is healthy, due to the honey have a lot of Vitamin B, and Folic acid that make peoples feel good");
                }
                else if (item.ToString() == "Bananas")
                {
                    MessageBox.Show("Banana contains tryptophan, it change to gladness hormone, In addition to that, it contains a lot of Potassium which make you feel glad");
                }
                else if (item.ToString() == "Eggs")
                {
                    MessageBox.Show("you want to be happy ? then eat the egg, it will give you a lot of happiness due to the serotunine hormone and dobamine hormone");
                }
                else if (item.ToString() == "Yogurts")
                {
                    MessageBox.Show("if you feel nervous or you are angry, the yogurt is from the best meals for you, why ? because it give you a lot of gladness and helping you to get your relaxing ");
                }
                else if(item.ToString() == "Spinaches")
                {
                    MessageBox.Show("why spinach ? because it help you to feel good due to the spinachs have a Folic acid which make you feel happy, not just that !! when you eat the spinaches you won't be nervous or depressed");
                }
                else if(item.ToString() == "Garlic")
                {
                    MessageBox.Show("Garlic fights depression and brings happiness, bcs it have a Crom, which Affecting the serotonin hormone, and this hormone is called by the Happiness substance");
                }
                else if(item.ToString() == "Chili pepper")
                {
                    MessageBox.Show("contains a serotonin hormone and andorfine hormone wich make you feel happy. further more, the chili pepper soothes the nerves in human bodies ");
                }
                else if(item.ToString() == "Fishes")
                {
                    MessageBox.Show("all fishes have omage 3 and any fish have a lot of vitamines that help you to do as best you can in your day ");
                }
                else if(item.ToString()=="The nuts")
                {
                    MessageBox.Show("Magnesium, vitamine B, omega 3 ... so the nuts driving you to calm down");
                }
                else
                {
                    MessageBox.Show("You didn't Choose");
                }
            }
            }

        private void btn_lunch_exit_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("are you want to close the app ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ans.ToString() == "Yes")
            {
                Application.Exit();
            }
        }
    }
}
