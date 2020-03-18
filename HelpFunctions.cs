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
    public static void SortCoord (ref System.Drawing.Point[] pointarray)
    {
        if (pointarray[1].X < pointarray[0].X) {
            var tmpX = pointarray[0].X;
            pointarray[0].X = pointarray[1].X;
            pointarray[1].X = tmpX;
        }
        if (pointarray[1].Y < pointarray[0].Y)
        {
            var tmpY = pointarray[0].Y;
            pointarray[0].Y = pointarray[1].Y;
            pointarray[1].Y = tmpY;
        }
    }
}
