using System;

public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        bool confirmation = false;
        if (year % 400 == 0 || year % 4 == 0 && year % 100 != 0) confirmation = true;
        return confirmation;
    }
}