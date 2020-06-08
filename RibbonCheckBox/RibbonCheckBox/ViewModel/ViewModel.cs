using System.Collections.ObjectModel;

namespace RibbonMenuMerging
{ 
    /// <summary>
    /// Represents the viewmodel.
    /// </summary>
    public class ViewModel
    {
        #region Fields
        /// <summary>
        ///  Maintains the collection of child1 ribbon tabs.
        /// </summary>
        private ObservableCollection<CustomRibbonTab> customChild1RibbonTabs;

        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the collection of child1 ribbon tabs.
        /// </summary>
        public ObservableCollection<CustomRibbonTab> CustomChild1RibbonTabs
        {
            get
            {
                return customChild1RibbonTabs;
            }
            set
            {
                if (customChild1RibbonTabs != value)
                    customChild1RibbonTabs = value;
            }
        }
        #endregion

        #region constructor
        /// <summary>
        ///  Initializes a new instance of the <see cref="ViewModel" /> class.
        /// </summary>
        public ViewModel()
        {
            CustomChild1RibbonTabs = new ObservableCollection<CustomRibbonTab>();
            PopulateChild1RibbonTabs();
        }
        #endregion

        #region Child Ribbon1
        /// <summary>
        /// Adding ribbon tabs to the control.
        /// </summary>
        private void PopulateChild1RibbonTabs()
        {
            CustomRibbonTab Tab1 = new CustomRibbonTab() { TabHeader = "Home" };
            PopulateDesignBar(Tab1);
            CustomChild1RibbonTabs.Add(Tab1);
        }

        /// <summary>
        /// Populating ribbon items to the ribbon bar.
        /// </summary>
        /// <param name="tab">Ribbontab.</param>
        private void PopulateDesignBar(CustomRibbonTab tab)
        {
            CustomRibbonBar Bar1 = new CustomRibbonBar() { BarHeader = "RibbonCheckBox" };
            CustomRibbonBar Bar2 = new CustomRibbonBar() { BarHeader = "Editing" };
            PopulateDesignItems(Bar1);
            tab.CustomChild1RibbonBars.Add(Bar1);
            PopulateEditingItems(Bar2);
            tab.CustomChild1RibbonBars.Add(Bar2);
        }

        /// <summary>
        /// Adding ribbon design items items to the ribbon bar.
        /// </summary>
        /// <param name="Bar">Ribbonbar.</param>
        private void PopulateDesignItems(CustomRibbonBar Bar)
        {
            CustomRibbonItem Item1 = new CustomRibbonItem() { ItemHeader = "Header Row", IsCheckBox=true, Checked=true};
            CustomRibbonItem Item2 = new CustomRibbonItem() { ItemHeader = "Total Row", IsCheckBox=true, Checked=false};
            CustomRibbonItem Item3 = new CustomRibbonItem() { ItemHeader = "Banded Row", IsCheckBox=true, Checked=true};
            CustomRibbonItem Item4 = new CustomRibbonItem() { ItemHeader = "First Column", IsCheckBox = true, Checked = true };
            CustomRibbonItem Item5 = new CustomRibbonItem() { ItemHeader = "Last Column", IsCheckBox = true, Checked = false };
            CustomRibbonItem Item6 = new CustomRibbonItem() { ItemHeader = "Banded Column", IsCheckBox = true, Checked = false };

            Bar.CustomRibbonItems.Add(Item1);
            Bar.CustomRibbonItems.Add(Item2);
            Bar.CustomRibbonItems.Add(Item3);
            Bar.CustomRibbonItems.Add(Item4);
            Bar.CustomRibbonItems.Add(Item5);
            Bar.CustomRibbonItems.Add(Item6);
        }

        /// <summary>
        /// Adding ribbon items to the child(Editing) ribbon bar.
        /// </summary>
        /// <param name="Bar">Child ribbon tab.</param>
        private void PopulateEditingItems(CustomRibbonBar Bar)
        {
            CustomRibbonItem Item1 = new CustomRibbonItem() { ItemHeader = "Find", Image = "Search.png" };
            CustomRibbonItem Item2 = new CustomRibbonItem() { ItemHeader = "Replace", Image = "replace_32.png" };
            CustomRibbonItem Item3 = new CustomRibbonItem() { ItemHeader = "Select", Image = "start2.png" };

            Bar.CustomRibbonItems.Add(Item1);
            Bar.CustomRibbonItems.Add(Item2);
            Bar.CustomRibbonItems.Add(Item3);
        }
        #endregion
    }
}
