Imports System.Collections.Generic
Imports System.Collections.ObjectModel;

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
            subitems.Add(New Item() With { _
                .ItemName = "Chair", _
                .Description = "A red chair." _
            })
            subitems.Add(New Item() With { _
                .ItemName = "Table", _
                .Description = "An old table." _
            })
            Categories.Add(New Category() With { _
                .CategoryName = "Furniture", _
                .Items = subitems _
            })
            Dim books As New ObservableCollection(Of Item)()
            books.Add(New Item() With { _
                .ItemName = "Dictionary", _
                .Description = "My old French-English Dictionary" _
            })
            Categories.Add(New Category() With { _
                .CategoryName = "Books", _
                .Items = books _
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
