using System;

namespace InverseNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Programa();
            Console.ReadKey();
        }
        public static void Programa()
        {
            int valor;
            bool validar;
            Console.Clear();
            Console.WriteLine("INVERTIR NÚMERO DE DOS CIFRAS");
            Console.Write("Ingrese un numero de dos cifras: ");
            validar = int.TryParse(Console.ReadLine(), out valor);
            if (validar == true)
            {
                if (valor.ToString().Length == 2)
                {
                    Invertir(valor.ToString());
                }
                else
                {
                    Programa();
                }
            }
            else
            {
                Console.WriteLine("Ingrese numeros solamente");
                Programa();
            }
            
        }
         public static void Invertir(string n)
        {
            char[] digitos = n.ToCharArray();
            Array.Reverse(digitos);
            Console.WriteLine(new string(digitos));
        }
    }
}
