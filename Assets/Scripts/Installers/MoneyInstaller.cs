using Zenject;
using UnityEngine;

public class MoneyInstaller : MonoInstaller
{
    [Min(1)]
    [SerializeField]
    private int _startMoney = 100;

    private Money _money;

    public override void InstallBindings()
    {
        _money = new Money(_startMoney);

        Container.Bind<Money>().FromInstance(_money);
    }

    //просто добавлю это сюда для симуляции получения денег
    public void DecreaseMoney(int value)
    {
        _money.Decrease(value);

        Debug.Log(_money.Current);
    }

    public void IncreseMoney(int value)
    {
        _money.Increase(value);

        Debug.Log(_money.Current);
    }
}