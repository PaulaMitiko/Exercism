using System;
using System.Collections.Generic;

using Microsoft.VisualBasic.CompilerServices;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        IDictionary<char, int> counting = new Dictionary<char, int>();

        int countA = 0, countC = 0, countG = 0, countT = 0;

        foreach (var item in sequence) 
        {
            if (item == 'A') countA += 1;
            else if (item == 'C') countC += 1;
            else if (item == 'G') countG += 1;
            else if (item == 'T') countT += 1;
            else throw new ArgumentException();
        }

        counting.Add('A', countA);
        counting.Add('C', countC);
        counting.Add('G', countG);
        counting.Add('T', countT);

        return counting;
    }
}