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
Imports System.Windows

Namespace WpfApplication1

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub
    End Class
End Namespace
