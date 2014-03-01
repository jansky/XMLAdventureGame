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
    public partial class AlreadyHaveItem : Form
    {
        public AlreadyHaveItem()
        {
            InitializeComponent();
        }

        private void AlreadyHaveItem_Load(object sender, EventArgs e)
        {

        }

        public void doMessage(string ItemName)
        {
            messageText.Text += ItemName + " because you already have it.";
            this.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
