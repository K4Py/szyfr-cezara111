// See https://aka.ms/new-console-template for more information

// Szyfr Cezara - maszyna pomagająca w rozszyfrowaniu tekstu.

using System;
using static System.Array;
using static System.Char;
class MainClass
{
    static void Main(string[] args)
    {
        
        char[] alfabet = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            Console.WriteLine("Zaszyfruj wybrany przez Ciebie tekst:");
                string tekst = Console.ReadLine();

        char[] secretMessage = tekst.ToCharArray();

        Console.WriteLine("Ile ma wynosić przesuniecie?");
             int PRZESUWANIE = Convert.ToInt32(Console.ReadLine());

        char[] SZYFROWANIE = new char[secretMessage.Length];

        int i;
            for (i = 0; i < secretMessage.Length; i++)
         {
                char secretItem = secretMessage[i];
                int index = Array.IndexOf(alfabet, secretItem);
                int letterPosition = (index += PRZESUWANIE) % 26;
                char encryptedCharacter = alfabet[letterPosition];
                SZYFROWANIE[i] = encryptedCharacter;
        }

        string zakodowane = String.Join("", SZYFROWANIE);
            Console.WriteLine("SZYFROWANIE:");
            Console.Write(SZYFROWANIE);
    }
}
