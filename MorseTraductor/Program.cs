using System;

namespace MorseTraductor
{
   public class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in args)
            {
                Console.WriteLine("######--TEXTO A MORSE--#####");
                Console.WriteLine("Este simbolo -> '|' indica la separacion de caracteres.\n Este simbolo -> '#' indica espacio entre caracteres.");
                MorseTranslate(item);
            }
           
        }

        public static void MorseTranslate(string text)
        {
                Console.WriteLine("Pulse [@] si desea salir.\nDigite una cadena de texto:");
                var parameter = MorseLibrary.Morse.Converter(text);
                foreach (var item in parameter) Console.Write($"{item}");
            
        }
    }
}