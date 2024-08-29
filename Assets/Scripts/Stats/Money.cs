using System;

public class Money : Stat
{
    public Money(int max) : base(max) { }

    public override void Decrease(int value)
    {
        if (value < 0)
            throw new ArgumentOutOfRangeException(nameof(value), "value must be positive.");

        _current -= value;

        if (_current < 0)
            _current = 0;

        OnDecreased?.Invoke();
    }

    public override void Increase(int value)
    {
        if (value < 0)
            throw new ArgumentOutOfRangeException(nameof(value), "value must be positive.");

        _current += value;

        if (_current > _max)
            _current = _max;

        OnIncreased?.Invoke();
    }
}