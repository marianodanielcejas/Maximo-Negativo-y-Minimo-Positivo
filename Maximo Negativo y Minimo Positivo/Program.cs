using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximo_Negativo_y_Minimo_Positivo
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num;
            int BanderaPositivos = 0;
            int BanderaNegativos = 0;
            int MinimoPositivo = 0;
            int MaximoNegativo = 0;
           
            Console.Write("Ingrese un Número por favor: ");
            Num = int.Parse(Console.ReadLine());

            while(Num != 0)
            {
                if(Num >= 0)
                {
                    if (BanderaPositivos == 0)
                    {
                        MinimoPositivo = Num;
                        BanderaPositivos = 1;
                    }
                    else
                    {
                        if (Num < MinimoPositivo)
                        {
                            MinimoPositivo = Num;
                        }
                    }  
                }
                else
                {
                    if (BanderaNegativos == 0)
                    {
                        MaximoNegativo = Num;
                        BanderaNegativos = 1;
                    }
                    else
                    {
                        if(Num > MaximoNegativo)
                        {
                            MaximoNegativo = Num;
                        }
                    }
                }
                Console.Write("Ingrese un Número por favor: ");
                Num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("El minimo positivo es: {0} ", MinimoPositivo);
            Console.WriteLine("El maximo negativo es: {0} ", MaximoNegativo);
            Console.Read();
        }
    }
}
