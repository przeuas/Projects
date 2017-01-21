using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Collections.ObjectModel;

namespace przyklad11
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new ObservableCollection<string>();

            data.CollectionChanged += Data_CollectionChanged;
            data.Add("Jeden");
            data.Add("Dwa");
            data.Add("xxx");
            data.Insert(1, "trzy");
            data.Remove("Dwa");

            Read();
        }
        static void Data_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            WriteLine("akcja: {0}", e.Action.ToString());
            if(e.OldItems != null)
            {
                WriteLine("indeks poczatku starych elementow: {0}", e.OldStartingIndex);
                WriteLine("stare elementy: ");
                foreach(var item in e.OldItems)
                {
                    WriteLine(item);
                }
            }

            if (e.NewItems != null)
            {
                WriteLine("indeks poczatku nowych elementow: {0}", e.NewStartingIndex);
                WriteLine("nowe elementy: ");
                foreach (var item in e.NewItems)
                {
                    WriteLine(item);
                }
            }
        }
    }
}
