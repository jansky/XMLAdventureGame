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
        AdventureGame Game;
       

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
            string[] args = Environment.GetCommandLineArgs();
            if(args == null || args.Length <= 1)
            {
                try
                {
                    if (openAdventureGameDialog.ShowDialog() == DialogResult.OK)
                    {
                        //Let's load an adventure game
                        var AGserializer = new XmlSerializer(typeof(AdventureGame));

                        var reader = XmlReader.Create(openAdventureGameDialog.FileName);
                        
                            var testGame = (AdventureGameReader.AdventureGame)AGserializer.Deserialize(reader);

                            //Load the first page
                            string firstPageId = testGame.FirstPage;
                            bool foundFirstPage = false;

                            foreach (Page p in testGame.Pages)
                            {
                                if (p.ID == firstPageId)
                                {
                                    //Load first page text
                                    pageText.Text = p.Text;

                                    //Populate action list box with actions from first page
                                    foreach (AGAction a in p.AGActions)
                                    {
                                        ListViewItem lvi = new ListViewItem(a.Text);
                                        lvi.Tag = a.ID;

                                        actionBox.Items.Add(lvi);
                                    }

                                    foundFirstPage = true;


                                }
                            }

                            //If the first page wasn't found, throw an exception.
                            if (foundFirstPage == false)
                            {
                                throw new Exception("Could not find a page with an ID of \'" + testGame.FirstPage + "\'. Could not display first page.");
                            }

                            Game = testGame;
                            this.Text = Game.Name;
                            //We're done.
                        

                    }
                }
                catch(Exception ex)
                {
                    Error er = new Error();
                    
                    er.doErrorMsg("There was an error loading the adventure game.", ex);
                    if(er.ShowDialog() == DialogResult.Abort)
                    {
                        Application.Exit();
                    }
                }
            }
            else
            {
                try
                {
                    
                        //Let's load an adventure game
                        var AGserializer = new XmlSerializer(typeof(AdventureGame));

                        var reader = XmlReader.Create(args[1]);

                        var testGame = (AdventureGameReader.AdventureGame)AGserializer.Deserialize(reader);

                        //Load the first page
                        string firstPageId = testGame.FirstPage;
                        bool foundFirstPage = false;

                        foreach (Page p in testGame.Pages)
                        {
                            if (p.ID == firstPageId)
                            {
                                //Load first page text
                                pageText.Text = p.Text;

                                //Populate action list box with actions from first page
                                foreach (AGAction a in p.AGActions)
                                {
                                    ListViewItem lvi = new ListViewItem(a.Text);
                                    lvi.Tag = a.ID;

                                    actionBox.Items.Add(lvi);
                                }

                                foundFirstPage = true;


                            }
                        }

                        //If the first page wasn't found, throw an exception.
                        if (foundFirstPage == false)
                        {
                            throw new Exception("Could not find a page with an ID of \'" + testGame.FirstPage + "\'. Could not display first page.");
                        }

                        Game = testGame;
                        this.Text = Game.Name;
                        //We're done.


                    }
                
                catch (Exception ex)
                {
                    Error er = new Error();

                    er.doErrorMsg("There was an error loading the adventure game.", ex);
                    if (er.ShowDialog() == DialogResult.Abort)
                    {
                        Application.Exit();
                    }
                }
            }
            

        }
    }
}
