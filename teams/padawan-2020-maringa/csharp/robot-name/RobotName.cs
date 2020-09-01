using System;
using System.Collections.Generic;

public class Robot
{
    public string Name { get; private set; }
    private static HashSet<string> names = new HashSet<string>();

    public Robot()
    {
        Reset();
    }


    public void Reset()
    {
        string name = "";
        do
        {
            Random rdm = new Random();
            for (int i = 0; i < 5; i++)
            {
                if (i < 2) name += ((char)rdm.Next('A', 'Z')).ToString();
                else name += (rdm.Next(0, 9)).ToString();
            }
        } while (!UniqueName(name));

        Name = name;

    }

    public bool UniqueName(string name)
    {
        return names.Add(name);
    }
}