namespace Prom01_sem05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static int Multiplicar(int num1, int num2)
            {
                int resultado = 0;
                bool num2Negativo = false;
                if (num2 < 0)
                {
                    num2 = -num2;
                    num2Negativo = true;
                }
                for (int i = 0; i < num2; i++)
                {
                    resultado += num1;
                }
                return num2Negativo ? -resultado : resultado;
            }
            static void Main()
            {
                int numero1 = 5;
                int numero2 = 3;
                int resultado = Multiplicar(numero1, numero2);
                Console.WriteLine($"{numero1} x {numero2} = {resultado}");
            }
        }
        
        }
    }
