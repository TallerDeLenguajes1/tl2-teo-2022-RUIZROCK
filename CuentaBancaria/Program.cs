using CuentaBancaria;
using static CuentaBancaria.tipoDeCuenta;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Tipo de extraccion");
        Console.WriteLine("1_ cajero humano");
        Console.WriteLine("2_ cajero automatico");
        int opcion = Convert.ToInt32(Console.ReadLine());

        tipoExtraccion(opcion);
    }
    public static void tipoExtraccion(int opcion)
    {
        tipoDeCuenta tc = new tipoDeCuenta();
        switch (opcion){
            case 1:
                tc.tramiteExtraccion(1);
                break;
            case 2:
                tc.tramiteExtraccion(2);
                break;
            default:
                return;
        }
    }
}