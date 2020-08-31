using System;
using System.Runtime.CompilerServices;

public static class TwoFer
{
    public static string Speak()
    {
        string frase = "One for you, one for me.";
        return frase;
    }
    public static string Speak(string who)
    {      
        string frase = "One for " + who + ", one for me.";
        return frase;
    }
}
