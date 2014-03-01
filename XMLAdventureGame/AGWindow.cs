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
        string CurrentPage = "";
       

        public AGWindow()
        {
            InitializeComponent();
        }

        private void inventoryButton_Click(object sender, EventArgs e)
        {
            try
            {
                new InventoryWin().doInventoryShow(Game.Inventories[0]);
            }
            catch(Exception ex)
            {
                Error er = new Error();

                er.doErrorMsg("There was an error showing the inventory.", ex);
                if (er.ShowDialog() == DialogResult.Abort)
                {
                    Application.Exit();
                }
            }
            
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
                                    actionBox.Items.Clear();

                                    //Populate action list box with actions from first page
                                    foreach (AGAction a in p.AGActions)
                                    {
                                        ListViewItem lvi = new ListViewItem(a.Text);
                                        lvi.Tag = a.ID;

                                        actionBox.Items.Add(lvi);
                                    }

                                    foundFirstPage = true;
                                    CurrentPage = firstPageId;
                                    


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
                                actionBox.Items.Clear();
                                //Populate action list box with actions from first page
                                foreach (AGAction a in p.AGActions)
                                {
                                    ListViewItem lvi = new ListViewItem(a.Text);
                                    lvi.Tag = a.ID;

                                    actionBox.Items.Add(lvi);
                                }

                                foundFirstPage = true;
                                CurrentPage = firstPageId;


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

        private void doActionButton_Click(object sender, EventArgs e)
        {
            string actionTEID = "";
            AGHelper aHelper = new AGHelper();
            try
            {
                //Get the id of the action we want to execute
                actionTEID = actionBox.SelectedItems[0].Tag.ToString();
            }
            catch(Exception)
            {
                return;
            }


            try
            {
                //Find the action we need to execute through a foreach loop
                foreach (AGAction a in aHelper.getPageById(CurrentPage, Game).AGActions)
                {
                    //We've found our action
                    if (a.ID == actionTEID)
                    {
                        //Do we have the required inventory item to complete the action.
                        if (a.Required != "" && aHelper.getInventoryItemById(a.Required, Game).HaveIt != "true")
                        {
                            //No, we don't. Show error dialog
                            new MissingInvItem().doMessage(aHelper.getInventoryItemById(a.Required, Game).Name);

                        }
                        else
                        {
                            //We can do it.

                            //Do we take away an inventory item?
                            if (a.ItemToUse != "")
                            {
                                //Do we have it in the first place?
                                if (aHelper.getInventoryItemById(a.ItemToUse, Game).HaveIt != "true")
                                {
                                    //No. That's an error
                                    throw new Exception("Cannot take away an item (name=" + aHelper.getInventoryItemById(a.ItemToUse, Game).Name + ", id=" + a.ItemToUse + ") that the user doesn't have.");
                                }
                                else
                                {
                                    //Yes. Set HaveIt to false
                                    aHelper.getInventoryItemById(a.ItemToUse, Game).HaveIt = "false";

                                    //Notify the user
                                    new UseInvItem().doMessage(aHelper.getInventoryItemById(a.ItemToUse, Game).Name);
                                }

                            }

                            //Do we give an inventory item to a user?
                            if (a.ItemToGet != "")
                            {
                                //Check if we already have it
                                if (aHelper.getInventoryItemById(a.ItemToGet, Game).HaveIt == "true")
                                {
                                    //Yes. Inform the user
                                    new AlreadyHaveItem().doMessage(aHelper.getInventoryItemById(a.ItemToGet, Game).Name);
                                }
                                else
                                {

                                    //We don't already have it. Set HaveIt to true
                                    aHelper.getInventoryItemById(a.ItemToGet, Game).HaveIt = "true";

                                    //Notify the user
                                    new GetInvItem().doMessage(aHelper.getInventoryItemById(a.ItemToGet, Game).Name);
                                }

                            }

                            //Do we need to navigate to another page?
                            if (a.To != "")
                            {
                                //Yes. Let's get the page.
                                Page ToNavigateTo = aHelper.getPageById(a.To, Game);
                                LoadPage(ToNavigateTo);
                            }

                        }
                    }
                }
            }
            catch(Exception ex)
            {
                Error er = new Error();
                er.doErrorMsg("Could not perform the action because of an error within the game.", ex);

                //The user chose quit
                if(er.ShowDialog() == DialogResult.Abort)
                {
                    Application.Exit();
                }
            }
        }

        private void LoadPage(Page p)
        {
           
            //Load  page text
            pageText.Text = p.Text;
            actionBox.Items.Clear();
            //Populate action list box with actions from first page
            foreach (AGAction a in p.AGActions)
            {
                
                ListViewItem lvi = new ListViewItem(a.Text);
                lvi.Tag = a.ID;

                actionBox.Items.Add(lvi);
            }


            CurrentPage = p.ID;
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            try
            {
                new About().doAbout(Game);
            }
            catch(Exception ex)
            {
                Error er = new Error();

                er.doErrorMsg("There was an error showing the about dialog.", ex);
                if (er.ShowDialog() == DialogResult.Abort)
                {
                    Application.Exit();
                }
            }
        }
    }
}
