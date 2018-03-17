using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Core;

namespace VirtualGirlfriend.Model
{
    public class GfProperties : INotifyPropertyChanged
    {
        private string name;
        private int propertyValue;
        private int increaseby;
        private int decreaseBy;

        public int PropertyValue
        {
            get { return propertyValue; }
            set { propertyValue = value; OnPropertyChanged("PropertyValue"); }
        }


        public string Name { get => name; set => name = value; }
        public int Increaseby { get => increaseby; set => increaseby = value; }
        public int DecreaseBy { get => decreaseBy; set => decreaseBy = value; }

        public event PropertyChangedEventHandler PropertyChanged;

        public GfProperties(string name, int propertyValue, int increaseBy, int decreaseBy)
        {
            Name = name;
            PropertyValue = propertyValue;
            Increaseby = increaseby;
            DecreaseBy = decreaseBy;
            Task DecreaseTask = new Task(delegate { Decrease(); });
            DecreaseTask.Start();
        }

        private async void Decrease()
        {
            while (true)
            {
                PropertyValue -= DecreaseBy;
                await Task.Delay(TimeSpan.FromSeconds(1));
            }
        }

        protected async void OnPropertyChanged(string propName)
        {
            await Windows.ApplicationModel.Core.CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
            });
        }
    }
}
