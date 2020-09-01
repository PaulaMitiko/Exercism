using System;
using System.Collections.Generic;
using System.Linq;

public enum Allergen
{
    Eggs = 1,
    Peanuts = 2,
    Shellfish = 4,
    Strawberries = 8,
    Tomatoes = 16,
    Chocolate = 32,
    Pollen = 64,
    Cats = 128
}

public class Allergies
{
    private readonly int auxMask; //Vari�vel interna que pode ser acessada por todo mundo
    public Allergies(int mask)
    {
        auxMask = mask; //Estou passando o valor informado para um vari�vel interna
    }

    public bool IsAllergicTo(Allergen allergen)
    {
        return List().Contains(allergen); //Verifica se a lista de alerg�nicos da pessoa cont�m a alergia informada 
    }

    public Allergen[] List()
    {
        List<Allergen> individualAllergens = new List<Allergen>(); //Crio uma lista para os alerg�nicos do indiv�duo
        foreach (var allergy in Enum.GetValues(typeof(Allergen)))  //Para cada alerg�nico poss�vel verifico se o valor em
        {                                                          //bin�rio, pertence ao valor informado. 
            if ((auxMask & (int)allergy) > 0) individualAllergens.Add((Allergen)allergy); //Se pertencer, armazenar na 
        }                                                                                 //lista de alerg�nicos da pessoa          
        return individualAllergens.ToArray(); //Retorna a lista do indiv�duo, a qual ser� utilizada no IsAllergicTo
    }
}