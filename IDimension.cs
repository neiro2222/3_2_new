interface IOne_Dimension {
    void More_than_100();
    void Repeat();
}

interface ISecond_Dimension {
    void Print_even_strings();
}

interface IStep_Dimension {
    void Change_even_el();
}

interface IArray {
    public void Key_init();
    public void Random_init();
    public abstract void Print();
    public abstract void Change(bool flag);
    public abstract void create_array(bool flag);
    public abstract void Average();
}

