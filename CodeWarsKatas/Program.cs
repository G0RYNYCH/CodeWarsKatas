string[] names = {"a", "b", "c", "d" };

Console.WriteLine(Likes(names));

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
/// Weather got to pump or not.
/// </summary>
/// <param name="distanceToPump"></param>
/// <param name="mpg"></param>
/// <param name="fuelLeft"></param>
/// <returns></returns>
static bool ZeroFuel(uint distanceToPump, uint mpg, uint fuelLeft) => fuelLeft * mpg >= distanceToPump;

/// <summary>
/// Who liked a post.
/// </summary>
/// <param name="name"></param>
/// <returns></returns>
static string Likes(string[] name)
{
    switch (name.Length)
    {
        case 0: return "no one likes this";
        case 1: return $"{name[0]} likes this";
        case 2: return $"{name[0]} and {name[1]} like this";
        case 3: return $"{name[0]}, {name[1]} and {name[2]} like this";
        default: return $"{name[0]}, {name[1]} and {name.Length - 2} others like this";
    }
}
