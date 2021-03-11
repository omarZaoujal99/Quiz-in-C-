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
    public partial class MovieTired : Form
    {
        public MovieTired()
        {
            InitializeComponent();
        }

        private void llbl_e_the_hours_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://hear.egybest.com/movie/last-holiday-2006/");
        }

        private void llbl_e_melancholia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://hear.egybest.com/movie/clueless-1995/");
        }

        private void llbl_e_its_a_wonderful_life_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://hear.egybest.com/movie/before-sunrise-1995/");
        }

        private void llbl_e_the_beaver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://hear.egybest.com/movie/finding-dory-2016/");
        }

        private void llbl_e_a_single_man_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://hear.egybest.com/movie/antz-1998/");
        }

        private void llbl_e_the_bridge_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://hear.egybest.com/movie/annie-2014/");
        }

        private void llbl_e_ordinary_people_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://hear.egybest.com/movie/twilight-2008/");
        }

        private void llbl_e_the_virgine_suisides_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://hear.egybest.com/movie/think-like-a-man-2012/");
        }
    }
}
