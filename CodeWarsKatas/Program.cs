int[] test = {1, 2, 3};

PartsSums(test);

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

/// <summary>
/// IP Validation.
/// </summary>
/// <param name="ipAddres"></param>
/// <returns></returns>
static bool IsValidIp(string ipAddress)
{
    var splitedString = ipAddress.Split('.');

    if (splitedString.Length != 4)
        return false;

    foreach (var s in splitedString)
        if (!(int.Parse(s) <= 255 && int.Parse(s) >= 0))
            return false;

    return true;
}

/// <summary>
/// Return time in milliseconds.
/// </summary>
/// <param name="h"></param>
/// <param name="m"></param>
/// <param name="s"></param>
/// <returns></returns>
static int Past(int h, int m, int s)
{
    return (int)(new TimeSpan(h, m, s)).TotalMilliseconds;
}

/// <summary>
/// Sum without highest and lowest number.
/// </summary>
/// <param name="numbers"></param>
/// <returns></returns>
static int Sum(int[] numbers)
{
    numbers.ToList().Sort();

    return 0;
}

/// <summary>
/// Rock Paper Scissors.
/// </summary>
/// <param name="p1"></param>
/// <param name="p2"></param>
/// <returns></returns>
string Rps(string p1, string p2)
{
    if (p1 == "scissors" && p2 == "paper")
        return "Player 1 won!";
    if (p1 == "scissors" && p2 == "rock")
        return "Player 2 won!";
    if (p1 == "paper" && p2 == "scissors")
        return "Player 2 won!";
    if (p1 == "paper" && p2 == "rock")
        return "Player 1 won!";
    if (p1 == "rock" && p2 == "scissors")
        return "Player 1 won!";
    if (p1 == "rock" && p2 == "paper")
        return "Player 2 won!";

    return "Draw!";
}

/// <summary>
/// Calculate average.
/// </summary>
/// <param name="array"></param>
/// <returns></returns>
static double FindAverage(double[] array) => array.Length == 0 ? 0 : array.Average();

/// <summary>
/// Sums of Parts (Slow version).
/// </summary>
/// <param name="ls"></param>
/// <returns></returns>
static int[] PartsSumsSlow(int[] ls)
{
    List<int> lsList = new List<int>(ls);
    List<int> result = new List<int>();

    foreach (int i in ls)
    {
        result.Add(lsList.Sum());
        lsList.RemoveAt(0);
    }

    result.Add(0);

    return result.ToArray();
}