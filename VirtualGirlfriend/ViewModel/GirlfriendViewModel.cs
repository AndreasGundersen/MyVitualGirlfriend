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
        //private static GirlfriendViewModel instance;

        //public static GirlfriendViewModel Instance
        //{
        //    get
        //    {
        //        if (instance == null)
        //        {
        //            instance = new GirlfriendViewModel();
        //        }
        //        return instance;
        //    }
        //}

        private Girlfriend g;

        public Girlfriend G { get => g; set => g = value; }
        public GirlfriendViewModel()
        {
            G = new Girlfriend("Emma Watson");
        }

        

        //public void GiveFood()
        //{

        //    GfProperties.().Hunger = girlfriends.First().Hunger + 10;


        //}

        //public void GiveGift()
        //{
        //    girlfriends.First().Happiness = girlfriends.First().Happiness + 10;
        //}

        //public void GiveDrink()
        //{
        //    girlfriends.First().Thirst = girlfriends.First().Thirst + 10;
        //}





    }
}
