
Console.WriteLine("Hello, World!");

/// <summary>
/// The Func returns true if str ends with ending.
/// </summary>
/// <param name="str"></param>
/// <param name="ending"></param>
/// <returns></returns>
static bool Solution(string str, string ending) => str.EndsWith(ending);


/// <summary>
/// Write a function that will take the number of petals of each flower and return true if they are in love and false if they aren't.
/// </summary>
/// <param name="flower1"></param>
/// <param name="flower2"></param>
/// <returns></returns>
static bool lovefunc(int flower1, int flower2) => flower1 % 2 != flower2 % 2;
//{
//    return (flower1 + flower2) % 2 == 1;            
//}

/// <summary>
/// Cocatenate strings n times.
/// </summary>
/// <param name="n"></param>
/// <param name="s"></param>
/// <returns></returns>
static string RepeatStr(int n, string s)
{
    StringBuilder sb = new StringBuilder();
    for (int i = 0; i < n; i++)
    {
        sb.Append(s);
    }
    return sb.ToString();
}

/// <summary>
/// 
/// </summary>
/// <param name="distanceToPump"></param>
/// <param name="mpg"></param>
/// <param name="fuelLeft"></param>
/// <returns></returns>
static bool ZeroFuel(uint distanceToPump, uint mpg, uint fuelLeft) => fuelLeft * mpg >= distanceToPump;