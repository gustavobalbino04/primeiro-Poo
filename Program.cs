using System;

namespace PrimeiroPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem peter = new Personagem();
            peter.armadura = "novo trage feito pelo Homen de Ferro";

            Console.WriteLine(peter.nome);
            Console.WriteLine(peter.armadura);
            Console.WriteLine(peter.Atacar());
            Console.WriteLine("restam " + peter.CalcularDano(26.5f) + " de vida do Dr.Octopus");
        }
    }
}
