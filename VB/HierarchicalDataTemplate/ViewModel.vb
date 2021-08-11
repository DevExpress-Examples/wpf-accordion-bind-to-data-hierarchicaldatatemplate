Imports System.Collections.Generic
Imports System.Collections.ObjectModel

Namespace HierarchicalDataTemplate

	Public Class ViewModel
		Public Property MyData() As Data
		Public Property SelectedItem() As Object
		Public Sub New()
			MyData = New Data()
		End Sub
	End Class
	Public Class Data
		Public Property Categories() As ObservableCollection(Of Category)
		Public Sub New()
			Categories = New ObservableCollection(Of Category)()
			Dim subitems As New ObservableCollection(Of Item)()
			subitems.Add(New Item() With {
				.ItemName = "Chair",
				.Description = "A red chair."
			})
			subitems.Add(New Item() With {
				.ItemName = "Table",
				.Description = "An old table."
			})
			Categories.Add(New Category() With {
				.CategoryName = "Furniture",
				.Items = subitems
			})
			Dim books As New ObservableCollection(Of Item)()
			books.Add(New Item() With {
				.ItemName = "Dictionary",
				.Description = "My old French-English Dictionary"
			})
			Categories.Add(New Category() With {
				.CategoryName = "Books",
				.Items = books
			})
		End Sub
	End Class
	Public Class Category
		Public Property CategoryName() As String
		Public Property Description() As String
		Public Property Items() As ObservableCollection(Of Item)
	End Class
	Public Class Item
		Public Property ItemName() As String
		Public Property Description() As String
	End Class
End Namespace
