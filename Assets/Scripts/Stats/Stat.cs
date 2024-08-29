using System;

public abstract class Stat
{
    protected int _max = 100;

    public int Max => _max;

    protected int _current = 0;

    public int Current => _current;

    public Action OnDecreased;

    public Action OnIncreased;

    public Action OnZeroing;

    public Stat(int max)
    {
        SetMax(max);

        Increase(max);
    }

    public void SetMax(int max) => _max = max;

    public abstract void Decrease(int value);

    public abstract void Increase(int value);
}