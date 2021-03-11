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
    public partial class Dinnernight : Form
    {
        public Dinnernight()
        {
            InitializeComponent();
        }

        private void btn_efd_glad_why_Click(object sender, EventArgs e)
        {
            foreach (var item in lb_dinnernight.SelectedItems)
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
                else if (item.ToString() == "Starches")
                {
                    MessageBox.Show("Starches being from the meals which help humans feel happy, the reason is increases Serotonin in the blood, it help you to feel calm and to get your relaxing ");
                }
                else if (item.ToString() == "Oats")
                {
                    MessageBox.Show("all we know how much the Oats is great for humans right ? due to the Oats have Complex fiber rich in carbohydrates Which helps to stabilize the sugar in the blood, and that make you calm and relaxing ");
                }
                else if (item.ToString() == "Avocado")
                {
                    MessageBox.Show("Increases concentration and awareness, which is why it is very useful before exams");
                }
                else if (item.ToString() == "Coffee")
                {
                    MessageBox.Show("it help you to start you day as a best you can, because the coffee have a lot of cafeine and antioxidants ");
                }
                else
                {
                    MessageBox.Show("You didn't Choose");
                }
            }
        }

        private void btn_dinnernight_exit_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("are you want to close the app ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ans.ToString() == "Yes")
            {
                Application.Exit();
            }
        }
    }
}
