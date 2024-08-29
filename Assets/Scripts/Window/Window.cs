using System.Collections.Generic;
using UnityEngine;

public class Window : MonoBehaviour
{
    [SerializeField]
    private Transform _root;

    [SerializeField]
    private SlotPrefab _spawnPrefab;

    [SerializeField]
    private List<SlotPrefab> _items;

    public List<SlotPrefab> Items => _items;

    public void SpawnItem(Item item)
    {
        SlotPrefab newItem = Instantiate(_spawnPrefab, _root);

        newItem.SetItem(item);

        newItem.Init();

        newItem.OnDestroyed += (() => RemoveItem(newItem));

        AddItem(newItem);
    }

    public void AddItem(SlotPrefab item)
    {
        _items.Add(item);
    }

    public void RemoveItem(SlotPrefab item)
    {
        _items.Remove(item);
    }
}