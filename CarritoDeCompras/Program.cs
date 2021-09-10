using System;

namespace CarritoDeCompras
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Camisa miCamisa = new Camisa();
            Carrito miCarrito = new Carrito();
            Menu miMenu = new Menu();
            
            Console.WriteLine("SHOPPING ONLINE DE CAMISAS – Ventas minoristas y mayoristas.");
            Console.WriteLine("---------------------------------------------");
            miMenu.ShowMenu(miCamisa, miCarrito);
        }
    }
}