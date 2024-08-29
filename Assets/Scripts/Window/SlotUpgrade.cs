using UnityEngine;
using Zenject;

public class SlotUpgrade : SlotPrefab
{
    private Money _moneyPlayer;

    [Inject]
    public void Construct(Money money)
    {
        _moneyPlayer = money;

        ChangeButtonInteractable();

        _moneyPlayer.OnIncreased += ChangeButtonInteractable;

        _moneyPlayer.OnDecreased += ChangeButtonInteractable;
    }

    private void OnDisable()
    {
        _moneyPlayer.OnIncreased -= ChangeButtonInteractable;

        _moneyPlayer.OnDecreased -= ChangeButtonInteractable;
    }

    public override void Buy()
    {
        if (_moneyPlayer.Current < _item.Price)
            return;

        _moneyPlayer.Decrease(_item.Price);

        Debug.Log("Money:" + _moneyPlayer.Current);

        Despawn();
    }

    public override bool CanBuy()
    {
        if (_moneyPlayer.Current >= _item.Price)
            return true;
        else
            return false;
    }
}