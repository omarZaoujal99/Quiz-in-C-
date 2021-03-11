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
    public partial class MoviesGlad : Form
    {
        public MoviesGlad()
        {
            InitializeComponent();
        }

        private void llbl_e_the_hours_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://hear.egybest.com/movie/dumb-and-dumberer-when-harry-met-lloyd-2003/");
        }

        private void llbl_e_melancholia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://hear.egybest.com/movie/dumb-and-dumber-to-2014/");
        }

        private void llbl_e_its_a_wonderful_life_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://hear.egybest.com/movie/zootopia-2016/?ref=search-p1");
        }

        private void llbl_e_the_beaver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://hear.egybest.com/movie/inside-out-2015/");
        }

        private void llbl_e_a_single_man_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://hear.egybest.com/movie/up-2009/?ref=search-p1");
        }

        private void llbl_e_the_bridge_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://hear.egybest.com/movie/coco-2017/");
        }

        private void llbl_e_ordinary_people_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://hear.egybest.com/movie/the-hangover-2009/");
        }

        private void llbl_e_the_virgine_suisides_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://hear.egybest.com/movie/monsters-university-2013/");
        }
    }
}
