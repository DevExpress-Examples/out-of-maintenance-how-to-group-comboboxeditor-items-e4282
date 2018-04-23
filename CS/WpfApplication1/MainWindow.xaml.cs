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
using System.Windows;

namespace WpfApplication1 {

    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
    }
}
