using System.Collections.Generic;
using System;

public class SuggestedList
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    private readonly List<SuggestedListItem> _items = new List<SuggestedListItem>();
    public IReadOnlyCollection<SuggestedListItem> Items => _items.AsReadOnly();

    public SuggestedList(string name)
    {
        Id = Guid.NewGuid();
        Name = name;
    }

    public void AddItem(SuggestedListItem item)
    {
        _items.Add(item);
    }
}
