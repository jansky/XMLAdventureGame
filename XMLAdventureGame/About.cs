using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using AdventureGameReader;

namespace XMLAdventureGame
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://jansky.informatick.net/xmladventuregame/about");
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gameName_Click(object sender, EventArgs e)
        {

        }

        private void About_Load(object sender, EventArgs e)
        {

        }

        public void doAbout(AdventureGame g)
        {
            gameName.Text += g.Name;
            gameAuthor.Text += g.Author;
            descriptionTextBox.Text = g.Description;
            this.ShowDialog();
        }
    }
}
