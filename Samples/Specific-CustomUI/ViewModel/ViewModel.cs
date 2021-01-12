using Syncfusion.Windows.Shared;
using System.Collections.ObjectModel;

namespace Specific_CustomUI
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
            CardViewItems.Add(new CardViewModel() { FirstName = "John", LastName = "Paulin", Age = 23 });
            CardViewItems.Add(new CardViewModel() { FirstName = "Mark", LastName = "Paulin", Age = 26 });
            CardViewItems.Add(new CardViewModel() { FirstName = "Steven", LastName = "John", Age = 25 });
            CardViewItems.Add(new CardViewModel() { FirstName = "John", LastName = "Steven", Age = 23 });
            CardViewItems.Add(new CardViewModel() { FirstName = "Steven", LastName = "Smith", Age = 25 });
        }
    }
}
