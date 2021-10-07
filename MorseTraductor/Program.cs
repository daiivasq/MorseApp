using System;

namespace MorseTraductor
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("######--TEXTO A MORSE--#####");
            Console.WriteLine("Este simbolo -> '|' indica la separacion de caracteres.\n Este simbolo -> '#' indica espacio entre caracteres.");
            MorseTranslate();
        }

        public static void MorseTranslate()
        {
            var text = "";
            while (text != "@")
            {
                Console.WriteLine("Pulse [@] si desea salir.\nDigite una cadena de texto:");
                text = Console.ReadLine();

                var parameter = MorseLibrary.Morse.Converter(text);
                foreach (var item in parameter)
                {
                    Console.Write($"{item}");
                }

            }
        }
    }
}