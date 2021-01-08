using System.Collections.Generic;
using System.Linq;

namespace itemsrepeaterissue.ViewModels {
    public class MainWindowViewModel : ViewModelBase {
        public class ItemGroup {
            public string Title { get; }
            public IEnumerable<string> Items { get; }

            public ItemGroup(string title, IEnumerable<string> items) {
                Title = title;
                Items = items;
            }
        }

        public IEnumerable<ItemGroup> ItemGroups =>
            new[] { 20, 20, 5, 2, 2, 2 }.Select(n => {
                return new ItemGroup(
                    $"Group with {n} items",
                    Enumerable.Range(0, n).Select(i => $"Item {i}")
                );
            });
    }
}
