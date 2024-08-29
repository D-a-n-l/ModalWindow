using UnityEngine;

public class CreateSlots : MonoBehaviour
{
    [SerializeField]
    private Window _window;

    [SerializeField]
    private Item[] _items;

    public void Create()
    {
        int randomItem = Random.Range(0, _items.Length);

        _window.SpawnItem(_items[randomItem]);
    }
}