using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulateItems
{
    //ViewModel.cs
    public class ViewModel : NotificationObject
    {
        private ObservableCollection<CardViewModel> cardViewItems;
        public ObservableCollection<CardViewModel> CardViewItems
        {
            get { return cardViewItems; }
            set
            {
                cardViewItems = value;
                this.RaisePropertyChanged(nameof(CardViewItems));
            }
        }
        public ViewModel()
        {
            CardViewItems = new ObservableCollection<CardViewModel>();
            populateItems();
        }
        private void populateItems()
        {
            CardViewItems.Add(new CardViewModel() { Item = "Item 1", Name = "Fruits" });
            CardViewItems.Add(new CardViewModel() { Item = "Item 2", Name = "Stationaries" });
            CardViewItems.Add(new CardViewModel() { Item = "Item 3", Name = "Dresses" });
        }
    }

}
