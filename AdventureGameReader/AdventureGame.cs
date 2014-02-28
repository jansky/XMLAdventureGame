using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AdventureGameReader
{
    [XmlRoot("adventure")]
    public class AdventureGame
    {
        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("author")]
        public string Author { get; set; }

        [XmlAttribute("description")]
        public string Description { get; set; }

        //We'll convert this to a boolean value later
        [XmlAttribute("images")]
        public string Images { get; set; }

        //First page's id (so we can display it)
        [XmlAttribute("firstpage")]
        public string FirstPage { get; set; }

        [XmlElement("page")]
        public Page[] Pages { get; set; }

        [XmlElement("inventory")]
        public Inventory[] Inventories { get; set; }


        
    }

    public class Page
    {
        [XmlAttribute("id")]
        public string ID { get; set; }

        //Optional
        [XmlAttribute("image")]
        public string Image { get; set; }

        [XmlElement("action")]
        public AGAction[] AGActions { get; set; }

        //Description of current page scene
        [XmlText]
        public string Text { get; set; }
    }

    public class AGAction
    {
        //The id of the page we want to go to
        //Optional
        [XmlAttribute("to")]
        public string To { get; set; }

        [XmlAttribute("id")]
        public string ID { get; set; }
       
        //The id of the inventory item to receive
        //Optional
        [XmlAttribute("get")]
        public string ItemToGet { get; set; }

        //The id of the inventory item to "use" (i.e. remove from user)
        //Optional
        [XmlAttribute("use")]
        public string ItemToUse { get; set; }

        //The id of the inventory item required
        //Optional
        [XmlAttribute("required")]
        public string Required { get; set; }

        //The text to be displayed identifying the action
        [XmlAttribute("text")]
        public string Text { get; set; }
    }

    public class Inventory
    {
        [XmlElement("item")]
        public InvItem[] InvItems { get; set; }
    }

    public class InvItem
    {
        [XmlAttribute("id")]
        public string ID { get; set; }

        [XmlAttribute("name")]
        public string Name { get; set; }

        //We'll convert this to boolean later
        [XmlAttribute("haveit")]
        public string HaveIt { get; set; }
    }
}
