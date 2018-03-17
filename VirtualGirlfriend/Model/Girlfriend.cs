using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Core;

namespace VirtualGirlfriend.Model
{
    public class Girlfriend 
    {
        string name;
        private ObservableCollection<GfProperties> properties = new ObservableCollection<GfProperties>();




        public string Name { get => name; set => name = value; }
        public ObservableCollection<GfProperties> Properties { get => properties; set => properties = value; }

        public Girlfriend(string name)
        {
            Name = name;
            Properties.Add(new GfProperties("Hunger", 50, 10, 5));
            Properties.Add(new GfProperties("Thirst", 50, 10, 5));
            Properties.Add(new GfProperties("Happiness", 50, 10, 5));
            Properties.Add(new GfProperties("Energy", 100, 10, 5));

        }

        

    }
}
