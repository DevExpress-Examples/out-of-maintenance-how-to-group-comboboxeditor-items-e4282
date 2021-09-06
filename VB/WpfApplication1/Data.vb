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

Namespace WpfApplication1
	Public Module DataHelper
		Public Function GetData() As IList(Of City)

			Dim cities As New ObservableCollection(Of City)()
			cities.Add(New City(1, "London", "UK"))
			cities.Add(New City(1, "Glasgow", "UK"))
			cities.Add(New City(1, "Edinburgh", "UK"))
			cities.Add(New City(1, "Aberdeen Dundee", "UK"))

			cities.Add(New City(2, "Washington", "USA"))
			cities.Add(New City(2, "Chicago", "USA"))
			cities.Add(New City(2, "Los Angeles", "USA"))
			cities.Add(New City(2, "New York", "USA"))

			cities.Add(New City(3, "Hong Kong", "China"))
			cities.Add(New City(3, "Shanghai", "China"))
			cities.Add(New City(3, "Beijing", "China"))
			cities.Add(New City(3, "Tianjin", "China"))

			Return cities
		End Function
	End Module

	Public Class City
		Public Sub New()
		End Sub

		Public Sub New(ByVal id As Integer, ByVal cityName As String, ByVal country As String)
			Me.ID = id
			Me.CityName = cityName
			Me.Country = country
		End Sub

		Public Property ID() As Integer
		Public Property CityName() As String
		Public Property Country() As String
	End Class
End Namespace
