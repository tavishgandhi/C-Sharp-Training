using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Day4A1Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            ObservableCollection<string> list = new ObservableCollection<string>()
            {
                "Tavish",
                "Anmol",
                "Deevesh"
            };
            list.CollectionChanged += List_CollectionChanged;

            list.Add("Poonam");
            list.Add("Tanish");
            list.Remove("Poonam");
        }


        private static void List_CollectionChanged(object sender, 
            System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if(e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                if(e.NewItems != null)
                {
                    foreach (var item in e.NewItems)
                    {
                        Console.WriteLine($"Element {item} is added to collection.");
                    }
                }
                
            }

            if(e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
            {
                if (e.OldItems != null)
                {
                    foreach (var item in e.OldItems)
                    {
                        Console.WriteLine($"Element {item} is removed from collection.");
                    }
                }
            }
        }
    }
}
