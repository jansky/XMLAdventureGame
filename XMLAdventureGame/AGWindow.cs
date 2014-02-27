using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using AdventureGameReader;

namespace XMLAdventureGame
{
    public partial class AGWindow : Form
    {
        public AGWindow()
        {
            InitializeComponent();
        }

        private void inventoryButton_Click(object sender, EventArgs e)
        {
            
            InventoryWin.GetForm.Show();
            
        }

        private void AGWindow_Load(object sender, EventArgs e)
        {
            //Let's load a test adventure game
            var serializer = new XmlSerializer(typeof(AdventureGameReader.AdventureGame));
            using (var reader = XmlReader.Create("test.xmlag"))
            {
                var testGame = (AdventureGameReader.AdventureGame)serializer.Deserialize(reader);
               
                //Load the first page
                string firstPageId = testGame.FirstPage;

                foreach(Page p in testGame.Pages)
                {
                    if(p.ID == firstPageId)
                    {
                        //Load first page text
                        pageText.Text = p.Text;

                        //Populate action list box with actions from first page
                        foreach(AGAction a in p.AGActions)
                        {
                            ListViewItem lvi = new ListViewItem(a.Text);
                            lvi.Tag = a.ID;

                            actionBox.Items.Add(lvi);
                        }
                    }
                }
            }

        }
    }
}
