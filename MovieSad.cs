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
    public partial class MovieSad : Form
    {
        public MovieSad()
        {
            InitializeComponent();
        }

        private void llbl_e_the_hours_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://hear.egybest.com/movie/deadpool-2016/");
        }

        private void llbl_e_melancholia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://hear.egybest.com/movie/deadpool-2-2018/");
        }

        private void llbl_e_its_a_wonderful_life_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://hear.egybest.com/movie/toy-story-4-2019/");
        }

        private void llbl_e_the_beaver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://hear.egybest.com/movie/despicable-me-2010/");
        }

        private void llbl_e_a_single_man_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://hear.egybest.com/movie/this-is-the-end-2013/");
        }

        private void llbl_e_the_bridge_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://hear.egybest.com/movie/superbad-2007/");
        }

        private void llbl_e_ordinary_people_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://hear.egybest.com/movie/about-time-2013/");
        }

        private void llbl_e_the_virgine_suisides_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://hear.egybest.com/movie/yes-man-2008/");
        }
    }
}
