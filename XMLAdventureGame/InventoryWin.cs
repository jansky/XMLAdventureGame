using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdventureGameReader;

namespace XMLAdventureGame
{
    public partial class InventoryWin : Form
    {
        
        public InventoryWin()
        {
            InitializeComponent();
        }



        /*private static InventoryWin inst;
        public static InventoryWin GetForm
        {
            get
            {
                if (inst == null || inst.IsDisposed)
                    inst = new InventoryWin();
                inst.Focus();
                return inst;
            }
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InventoryWin_Load(object sender, EventArgs e)
        {

        }

        public void doInventoryShow(Inventory inv)
        {

            invList.Items.Clear();

            foreach(InvItem i in inv.InvItems)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = i.Name;
                if(i.HaveIt == "true")
                {
                    lvi.SubItems.Add("Yes");
                }
                else
                {
                    lvi.SubItems.Add("No");
                }

                invList.Items.Add(lvi);
                
                
            }

            this.ShowDialog();
        }
    }
}
