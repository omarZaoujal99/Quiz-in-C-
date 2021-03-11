using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class MovieAngry : Form
    {
        public MovieAngry()
        {
            InitializeComponent();
        }

            private void llbl_e_the_hours_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
                Process.Start("https://hear.egybest.com/movie/a-star-is-born-2018/");
            }

            private void llbl_e_melancholia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
                Process.Start("https://hear.egybest.com/movie/me-before-you-2016/");
            }

            private void llbl_e_its_a_wonderful_life_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
                Process.Start("https://hear.egybest.com/movie/hugo-2011/?ref=search-p1");
            }

            private void llbl_e_the_beaver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
                Process.Start("https://hear.egybest.com/movie/your-name-2016/?ref=search-p1");
            }

            private void llbl_e_a_single_man_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
                Process.Start("https://hear.egybest.com/movie/crazy-rich-asians-2018/");
            }

            private void llbl_e_the_bridge_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
                Process.Start("https://hear.egybest.com/movie/life-is-beautiful-1997/");
            }

            private void llbl_e_ordinary_people_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
                Process.Start("https://hear.egybest.com/movie/warm-bodies-2013/");
            }

            private void llbl_e_the_virgine_suisides_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
                Process.Start("https://hear.egybest.com/movie/up-in-the-air-2009/");
            }
        
    }
}
