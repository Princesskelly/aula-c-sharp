using System;

namespace teste_de_variavel_e_constante
{
    class Program
    {
        static void Main(string[] argumentos)
        {
            const string constante = "uma constante que não muda";

            if(argumentos.Length == 0)
            {
                Console.WriteLine("Favor informar um número inteiro");
                return;
            }

            int inteiro;
            bool test = int.TryParse(argumentos[0], out inteiro);

            if(test == false)
            {
                Console.WriteLine("O argumento informado não é um número inteiro");
                return;
            }

            Console.WriteLine(constante);
            Console.WriteLine("O número informado foi: " + inteiro);
        }
    }
}
