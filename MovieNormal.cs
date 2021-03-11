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
    public partial class MovieNormal : Form
    {
        public MovieNormal()
        {
            InitializeComponent();
        }

        private void llbl_e_the_hours_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://hear.egybest.com/movie/the-imitation-game-2014/");
        }

        private void llbl_e_melancholia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://hear.egybest.com/movie/la-la-land-2016/?ref=search-p1");
        }

        private void llbl_e_its_a_wonderful_life_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://hear.egybest.com/movie/the-greatest-showman-2017/");
        }

        private void llbl_e_the_beaver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://hear.egybest.com/movie/gravity-2013/?ref=search-p1");
        }

        private void llbl_e_a_single_man_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://hear.egybest.com/movie/baby-driver-2017/");
        }

        private void llbl_e_the_bridge_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://hear.egybest.com/movie/suicide-squad-2016/");
        }

        private void llbl_e_ordinary_people_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://hear.egybest.com/movie/the-hunger-games-2012/");
        }

        private void llbl_e_the_virgine_suisides_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://hear.egybest.com/movie/edge-of-tomorrow-2014/");
        }
    }
}
