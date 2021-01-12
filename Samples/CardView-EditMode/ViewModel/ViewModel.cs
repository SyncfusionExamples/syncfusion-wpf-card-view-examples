using Syncfusion.Windows.Shared;
using Syncfusion.Windows.Tools.Controls;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace CardView_EditMode
{
    public class ViewModel : NotificationObject
    {
        private ObservableCollection<CardViewModel> cardViewItems;
        public ICommand BeginEditCommand { get; }
        public ICommand EndEditCommand { get; }
        public ObservableCollection<CardViewModel> CardViewItems
        {
            get { return cardViewItems; }
            set
            {
                cardViewItems = value;
                this.RaisePropertyChanged("CardViewItems");
            }
        }

        private void EndEditCommandMethod(object obj)
        {
            (obj as CardView).EndEdit();
        }

        private void BeginEditCommandMethod(object obj)
        {
            (obj as CardView).BeginEdit();

        }
        private void populateItems()
        {
            CardViewItems.Add(new CardViewModel() { Name = "John", Age = 23 });
            CardViewItems.Add(new CardViewModel() { Name = "Mark", Age = 26 });
            CardViewItems.Add(new CardViewModel() { Name = "Steven", Age = 25 });
            CardViewItems.Add(new CardViewModel() { Name = "Smith", Age = 23 });
            CardViewItems.Add(new CardViewModel() { Name = "Cena", Age = 26 });
        }
        public ViewModel()
        {
            CardViewItems = new ObservableCollection<CardViewModel>();
            populateItems();
            BeginEditCommand = new DelegateCommand(BeginEditCommandMethod);
            EndEditCommand = new DelegateCommand(EndEditCommandMethod);
        }
    }
}
