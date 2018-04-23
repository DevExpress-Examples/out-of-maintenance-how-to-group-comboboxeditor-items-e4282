' Developer Express Code Central Example:
' How to group ComboBoxEditor items
' 
' This example demonstrates how to group ComboBoxEditor items. DxEditors support
' binding to ICollectionView, so the main idea of this feature realization is the
' use of ListCollectionView. The basic logic is implemented in
' ComboBoxEditGroupingBehavior, which is attached to the editor.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E4282

Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Collections.ObjectModel
Imports System.Windows.Data
Imports System.ComponentModel

Namespace WpfApplication1
    Public Class MainViewModel
        Public Property Cities() As IList(Of City)
        Public Property GroupedCities() As ICollectionView

        Public Sub New()
            Cities = DataHelper.GetData()
            GroupedCities = CollectionViewSource.GetDefaultView(Cities)
            GroupedCities.GroupDescriptions.Add(New PropertyGroupDescription("Country"))
        End Sub
    End Class
End Namespace
