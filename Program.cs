using System;

    public class Program
    {
        public static void Main(string[] args){
           
            int c1 = int.Parse(Console.WriteLine("Quantidade de calorias:"));
            int c2 = int.Parse(Console.WriteLine("Quantidade de calorias:"));
            int c3 = int.Parse(Console.WriteLine("Quantidade de calorias:"));
            int calorias = (c1 + c2 + c3);

            Console.WriteLine("Digite a quantidade de calorias:");
            int limite = Console.ReadLine();

            Console.WriteLine("Informe o primeiro alimento ingerido:");
            int PrimeroAlimento = Console.ReadLine();            

            Console.WriteLine("Informe o segundo alimento ingerido:");
            int SegundoAlimento = Console.ReadLine();            

            Console.WriteLine("Informe o terceiro alimento ingerido:");
            int TerceiroAlimento = Console.ReadLine();       
            
            if (calorias>limite)
            {
              Console.WriteLine("Você consumiu"+calorias+"e ficou acima da meta");
            }
            else if (calorias<limite)
            {
              Console.WriteLine("Você consumiu"+calorias+"e ficou abaixo da meta");
            }
            if (calorias==limite)
            {
              Console.WriteLine("Você consumiu"+calorias+"e atingiu a sua meta");
            }
            else 
             Console.WriteLine("Sair");
             break;
            }
  }