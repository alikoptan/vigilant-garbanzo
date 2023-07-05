namespace noodles;

public static class BadFile
{
    public static void UnusedMethod()
    {
        int whatareyoudoing = 0;
    }

    public static string bAdNaMiNG()
    {
        string badStr = "";
        for (var i = 0; i < 99; i++)
        {
            badStr += "screw";
            badStr += " you ";
            badStr += " sonar!";
        }
        return badStr;
    }
}