using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Editing
{
    //ViewModel.cs
    public class ViewModel : NotificationObject
    {
        private ObservableCollection<CardViewModel> cardViewItems;
        private bool canGroup = true;
        private bool canSort = true;
        private bool canEdit = true;
        private bool showHeader = true;
        private Orientation orientation =  Orientation.Vertical;
        private FlowDirection flowDirection = FlowDirection.LeftToRight;

        public Orientation Orientation
        {
            get { return orientation; }
            set
            {
                orientation = value;
                this.RaisePropertyChanged(nameof(Orientation));
            }
        }
        public FlowDirection FlowDirection
        {
            get { return flowDirection; }
            set
            {
                flowDirection = value;
                this.RaisePropertyChanged(nameof(FlowDirection));
            }
        }
        
        public bool CanGroup
        {
            get { return canGroup; }
            set
            {
                canGroup = value;
                this.RaisePropertyChanged(nameof(CanGroup));
            }
        }
        
        public bool CanSort
        {
            get { return canSort; }
            set
            {
                canGroup = value;
                this.RaisePropertyChanged(nameof(CanSort));
            }
        }

        public bool CanEdit
        {
            get { return canEdit; }
            set
            {
                canEdit = value;
                this.RaisePropertyChanged(nameof(CanEdit));
            }
        }

        public bool ShowHeader
        {
            get { return showHeader; }
            set
            {
                showHeader = value;
                this.RaisePropertyChanged(nameof(ShowHeader));
            }
        }
        
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
