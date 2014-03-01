using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMLAdventureGame
{
    public partial class MissingInvItem : Form
    {
        public MissingInvItem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MissingInvItem_Load(object sender, EventArgs e)
        {

        }

        public void doMessage(string ItemName)
        {
            messageText.Text += ItemName + ".";
            this.ShowDialog();
        }
    }
}
