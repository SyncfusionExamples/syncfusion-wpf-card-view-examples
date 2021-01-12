using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Specific_CustomUI
{
    public class CardViewItemContainerStyleSelector : StyleSelector
    {
        public Style Style1 { get; set; }
        public Style Style2 { get; set; }
        public override Style SelectStyle(object item, DependencyObject container)
        {
            string LastName = (item as CardViewModel).LastName;
            if (LastName == "Paulin")
            {
                return Style1;
            }
            else
            {
                return Style2;
            }
        }
    }
}