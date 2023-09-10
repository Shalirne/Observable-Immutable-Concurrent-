using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Regular_Customer
{
    internal class Customer
    {
        public void OnItemChanged(string overview)
        {
            Console.WriteLine(overview);
        }

        public void ChangedItem(object changed, NotifyCollectionChangedEventArgs eventArgs)
        {
            ObservableCollection<Item> unboxnigObject = (ObservableCollection<Item>)changed;
            List<Item> oldItems = Shop.oldItems;

            switch (eventArgs.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    {
                        var lastItem = unboxnigObject.Last();
                        OnItemChanged($"Добавлен товар с названием {lastItem.name} и идентификатором {lastItem.id}");
                        break;
                    }
                case NotifyCollectionChangedAction.Remove:
                    {
                        for (int i = 0; i < oldItems.Count; i++)
                        {
                            if (oldItems[i].deleted == true)
                            {
                                OnItemChanged($"Удален товар с названием {oldItems[i].name} и идентификатором {oldItems[i].id}");
                                oldItems.RemoveAt(i);
                                break;
                            }
                        }
                        break;
                    }
            }
        }
    }
}
