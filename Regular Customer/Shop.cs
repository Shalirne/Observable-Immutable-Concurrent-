using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regular_Customer
{
    internal class Shop
    {
        public ObservableCollection<Item> changed = new ObservableCollection<Item>();
        public static List<Item> oldItems = new List<Item>();
        public void Add(Item item)
        {
            changed.Add(item);
            oldItems.Add(item);
        }
        public void Deleted(int item)
        {
            for (int i = 0; i < changed.Count; i++)
            {
                if (changed[i].id == item)
                {
                    oldItems[i].deleted = true;
                    changed.RemoveAt(i);
                }
            }
        }

    }
}
