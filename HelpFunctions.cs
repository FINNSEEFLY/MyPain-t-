//
// Вспомогательный модуль
//
public static class HelpFunctions 
{
    // Процедура обмена переменных a и b значениями 
    public static void Swap<T>(ref T a, ref T b)
    {
        var temp = a;
        a = b;
        b = temp;
    }

    // Процедура подготовки координат по следующему формату:
    // Point(x1,y1) - верхний левый угол
    // Point(x2,y2) - нижний правый угол
    public static void SortCoord (ref int x1, ref int y1, ref int x2, ref int y2)
    {
        if (x2 < x1) Swap(ref x1, ref x2);
        if (y2 < y1) Swap(ref y1, ref y2);
    }
}
