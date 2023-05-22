using System.Collections.ObjectModel;

namespace MauiApp4;
public class MainPageViewModel
{
    public MainPageViewModel()
    {
        AddItems();
    }

    public ObservableCollection<Model> Items { get; set; } = new();

    public Command AddItemsCommand => new(AddItems);
    private void AddItems()
    {
        Items.Add(new("Bob", "the Builder"));
        Items.Add(new("William", "the Conqueror"));
        Items.Add(new("Attila", "the Hun"));
    }
}
