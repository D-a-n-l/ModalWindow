using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Item/New Item")]
public class Item : ScriptableObject
{
    [field: SerializeField] 
    public Sprite Icon {  get; private set; }

    [field: SerializeField] 
    public string Name { get; private set; }

    [field: TextArea]
    [field: SerializeField] 
    public string Description { get; private set; }

    [field: Space(5)]
    [field: Min(0)]
    [field: SerializeField] 
    public int Price { get; private set; }

    [field: Header("Button Buy")]
    [field: SerializeField]
    public Sprite NormalButton { get; private set; }

    [field: SerializeField]
    public Sprite DisabledButton { get; private set; }
}