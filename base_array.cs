using System;

abstract class Base_array : IArray
{
    protected abstract void _Key_init();
    protected abstract void _Random_init();
    public abstract void Print();
    public abstract void Change(bool flag);
    public abstract void Create_array(bool flag);
    public abstract void Average();

}
