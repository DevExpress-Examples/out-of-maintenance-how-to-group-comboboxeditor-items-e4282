// Developer Express Code Central Example:
// How to group ComboBoxEditor items
// 
// This example demonstrates how to group ComboBoxEditor items. DxEditors support
// binding to ICollectionView, so the main idea of this feature realization is the
// use of ListCollectionView. The basic logic is implemented in
// ComboBoxEditGroupingBehavior, which is attached to the editor.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E4282

using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Windows.Data;
using System.ComponentModel;

namespace WpfApplication1 {
    public class MainViewModel {
        public IList<City> Cities { get; set; }
        public ICollectionView GroupedCities { get; set; }

        public MainViewModel() {
            Cities = DataHelper.GetData();
            GroupedCities = CollectionViewSource.GetDefaultView(Cities);
            GroupedCities.GroupDescriptions.Add(new PropertyGroupDescription("Country"));
        }
    }
}
