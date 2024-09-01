using System.Drawing;

namespace _6ti_LoukaConstant_TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TRYPARSE");
            int num;
            bool TryParse;
            string texteNum;
            string repeatProg;

            do
            {
                Console.WriteLine("Veuillez entrer la suite chiffres '123' !");
                texteNum = Console.ReadLine();

                TryParse = int.TryParse(texteNum, out num);

                if (TryParse)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Vous avez rentré la combinaison demandée !");
                }

                else
                {
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine("Vous avez rentré la mauvaise combinaison. Veuillez recommencer !");
                }

                Console.WriteLine("Voulez-vous recommencer ? 'o' = oui, 'n' = non");
                repeatProg = Console.ReadLine();


            } while (repeatProg == "o");
        }
    }
}
