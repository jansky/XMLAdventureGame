using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGameReader
{
    public class AGHelper
    {
        public InvItem getInventoryItemById(string id, AdventureGame g)
        {
            Inventory i = g.Inventories[0];
            InvItem invitem = null;

            foreach(InvItem invi in i.InvItems)
            {
                if(invi.ID == id)
                {
                    invitem = invi;
                }
            }

            if(invitem == null)
            {
                throw new Exception("Inventory item with id \'" + id + "\' was not found.");
            }

            return invitem;
        }

        public Page getPageById(string id, AdventureGame g)
        {
            Page pa = null;
            foreach(Page p in g.Pages)
            {
                if(p.ID == id)
                {
                    pa = p;
                }
            }

            if(pa == null)
            {
                throw new Exception("Page with id \'" + id + "\' was not found.");
            }

            return pa;
        }
    }
}
