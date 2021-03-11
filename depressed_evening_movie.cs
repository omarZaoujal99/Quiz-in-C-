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
    public partial class depressed_evening_movie : Form
    {
        public depressed_evening_movie()
        {
            InitializeComponent();
        }

        private void llbl_e_the_hours_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://hear.egybest.com/movie/the-hours-2002/?ref=search-p1"); 
        }

        private void llbl_e_melancholia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://hear.egybest.com/movie/melancholia-2011/");
        }

        private void llbl_e_its_a_wonderful_life_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://hear.egybest.com/movie/its-a-wonderful-life-1946/");
        }

        private void llbl_e_the_beaver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://hear.egybest.com/movie/the-beaver-2011/?ref=search-p1");
        }

        private void llbl_e_a_single_man_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://hear.egybest.com/movie/a-single-man-2009/");
        }

        private void llbl_e_the_bridge_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://hear.egybest.com/series/the-bridge-2011/");
        }

        private void llbl_e_ordinary_people_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://hear.egybest.com/movie/ordinary-people-1980/?ref=search-p1");
        }

        private void llbl_e_the_virgine_suisides_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://hear.egybest.com/movie/the-virgin-suicides-1999/");
        }
    }
}
