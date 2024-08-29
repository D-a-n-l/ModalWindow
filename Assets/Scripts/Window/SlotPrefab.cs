using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public abstract class SlotPrefab : MonoBehaviour
{
    [SerializeField]
    protected Image _icon;

    [SerializeField]
    protected TMP_Text _name;

    [SerializeField]
    protected TMP_Text _description;

    [Space(10)]
    [SerializeField]
    protected Button _buttonBuy;

    [SerializeField]
    protected Image _imageButtonBuy;

    [SerializeField]
    protected TMP_Text _priceText;

    protected Item _item;

    public Action OnDestroyed;

    public void Init()
    {
        _icon.sprite = _item.Icon;

        _name.text = _item.Name.ToString();

        _description.text = _item.Description.ToString();

        _priceText.text = _item.Price.ToString();

        _buttonBuy?.onClick.AddListener(Buy);
    }

    public void ChangeButtonInteractable()
    {
        _buttonBuy.interactable = CanBuy();

        if (CanBuy() == true)
        {
            _imageButtonBuy.sprite = _item.NormalButton;
        }
        else
        {
            _imageButtonBuy.sprite = _item.DisabledButton;
        }
    }

    public void Despawn()
    {
        OnDestroyed?.Invoke();

        Destroy(gameObject);
    }

    public void SetItem(Item item) => _item = item;

    public abstract void Buy();

    public abstract bool CanBuy();
}