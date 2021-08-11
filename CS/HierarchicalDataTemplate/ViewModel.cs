using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace HierarchicalDataTemplate {

    public class ViewModel {
        public Data MyData { get; set; }
        public object SelectedItem { get; set; }
        public ViewModel() {
            MyData = new Data();
        }
    }
    public class Data {
        public ObservableCollection<Category> Categories { get; set; }
        public Data() {
            Categories = new ObservableCollection<Category>();
            ObservableCollection<Item> subitems = new ObservableCollection<Item>();
            subitems.Add(new Item() { ItemName = "Chair", Description = "A red chair." });
            subitems.Add(new Item() { ItemName = "Table", Description = "An old table." });
            Categories.Add(new Category() { CategoryName = "Furniture", Items = subitems });
            ObservableCollection<Item> books = new ObservableCollection<Item>();
            books.Add(new Item() { ItemName = "Dictionary", Description = "My old French-English Dictionary" });
            Categories.Add(new Category() { CategoryName = "Books", Items = books });
        }
    }
    public class Category {
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public ObservableCollection<Item> Items { get; set; }
    }
    public class Item {
        public string ItemName { get; set; }
        public string Description { get; set; }
    }
}
