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

interface IArray : IPrinter{
    void Change(bool flag);
    void Create_array(bool flag);
    void Average();
}

