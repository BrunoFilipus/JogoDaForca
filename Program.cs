namespace Frete
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// </summary>
            /// <param name="posicaoInical"></param>
            /// <param name="distancia"></param>
            /// <param name="peso"></param>
            /// <returns></returns>
            Console.Write("Digite a distância da entrega (em quilômetros): ");
            int posicaoInicial = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o peso do produto a ser transportado: ");
            int peso = Convert.ToInt32(Console.ReadLine());
            double valorFrete;
            CalcularFrete(posicaoInicial, peso, out valorFrete);
            Console.WriteLine($"O valor final do frete é: {valorFrete.ToString("C")}.");
        }
        public static double CalcularFrete(int distancia, int peso, out double valorFrete)
        {
            valorFrete = 0;

            for (int i = 1; i <= distancia; i++)
            {
                valorFrete += 0.1;
                
                if (i % 200 == 0)
                {
                    valorFrete += 1;
                }
                if (i % 1000 == 0)
                {
                    valorFrete += 10;
                }
            }
            if (peso > 25)
            {
                valorFrete *= 5;
            }
            if (peso >= 5 && peso < 25)
            {
                valorFrete *= 3;
            }
            return valorFrete;
        }
    }
}
