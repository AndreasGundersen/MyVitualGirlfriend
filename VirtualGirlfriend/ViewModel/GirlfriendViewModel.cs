using VirtualGirlfriend.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualGirlfriend.Model;
using Windows.UI.Xaml;
using Windows.UI.Core;
using System.Collections.ObjectModel;

namespace VirtualGirlfriend.ViewModel
{
    public class GirlfriendViewModel 
    {
        private static GirlfriendViewModel instance;

        public static GirlfriendViewModel Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GirlfriendViewModel();
                }
                return instance;
            }
        }

        private Girlfriend g;

        public Girlfriend G { get => g; set => g = value; }
        public GirlfriendViewModel()
        {
            G = new Girlfriend("Emma Watson");
        }

        public void IncreaseProperty(int i)
        {
            G.Properties[i].Increase();
            Debug.WriteLine(G.Properties[0].DecreaseBy);


        }







    }
}
