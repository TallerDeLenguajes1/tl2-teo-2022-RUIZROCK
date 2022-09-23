using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaBancaria
{
    internal class tipoDeCuenta
    {
        public void tramiteExtraccion(int tramite)
        {
            int opcion = 0;
            switch (tramite)
            {
                case 1:
                    Console.WriteLine("Tramite que desea realizar:");
                    Console.WriteLine("1_ Cuenta corriente en pesos");
                    Console.WriteLine("2_ Cuenta corriente en dolares");
                    Console.WriteLine("3_ Caja de ahorrro en pesos");
                    opcion = Convert.ToInt32(Console.ReadLine());
                        switch (opcion)
                        {
                            case 1:
                                corrienteEnPesos(1);
                                break;
                            case 2:
                                corrienteEnDolares(1);
                                break;
                            case 3:
                                cajaAhorroEnPesos(1);
                                break;

                        }
                    break;
                case 2:
                    Console.WriteLine("Tramite que desea realizar:");
                    Console.WriteLine("1_ Cuenta corriente en pesos");
                    Console.WriteLine("2_ Cuenta corriente en dolares");
                    Console.WriteLine("3_ Caja de ahorrro en pesos");
                    opcion = Convert.ToInt32(Console.ReadLine());
                        switch (opcion)
                        {
                            case 1:
                                corrienteEnPesos(2);
                                break;
                            case 2:
                                corrienteEnDolares(2);
                                break;
                            case 3:
                                cajaAhorroEnPesos(2);
                                break;
                        }
                    break;
                default:
                    return;
            }
        }

        public void corrienteEnPesos(int i)
        {
            if (i == 1)
            {
                Console.WriteLine("Usted puede extraer hasta $200.000");
            }
            else
            {
                if (i == 2)
                {
                    Console.WriteLine("Usted puede extraer todo el monto");
                }
            }
        }

        public void corrienteEnDolares(int i)
        {
            if (i == 1)
            {
                Console.WriteLine("Usted puede extraer hasta $200 por dia");
            }
            else
            {
                if (i == 2)
                {
                    Console.WriteLine("Usted puede extraer todo el monto");
                }
            }
        }

        public void cajaAhorroEnPesos(int i)
        {
            if (i == 1)
            {
                Console.WriteLine("Usted puede extraer hasta $10.000");
            }
            else
            {
                if (i == 2)
                {
                    Console.WriteLine("Usted puede extraer todo el monto");
                }
            }
        }
    }
}
