using System;

namespace CarritoDeCompras
{
    public class Menu
    {
        private int _option;
        private int _amount;

        public void ShowMenu(Camisa camisa, Carrito carrito)
        {
            do
            {
                carrito.CalculateTotal(camisa.GetUnitPrice());
                carrito.ApplyDiscount();

                Console.WriteLine("MENÚ PRINCIPAL:");
                Console.WriteLine("1- Añadir camisas al carro de compras.");
                Console.WriteLine("2- Eliminar camisas del carro de compras.");
                Console.WriteLine("3- Salir.");
                if (carrito.Quantity > 0)
                {
                    Console.WriteLine("4- Comprar.");
                }

                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("'     '- Cantidad de camisas en el carro de compras: " + carrito.Quantity);
                Console.WriteLine("'     '- Precio unitario: " + camisa.GetUnitPrice());
                Console.WriteLine("'     '- Precio total sin descuento: $" + carrito.Total);
                Console.WriteLine("'     '- Descuento del: " + (carrito.Discount * 100) + "%");
                Console.WriteLine("'     '- Precio final con descuento: $" + carrito.TotalFinal);
                Console.WriteLine("Ingrese segun corresponda: ");

                try
                {
                    _option = Convert.ToInt32(Console.ReadLine());
                    switch (_option)
                    {
                        case 1:
                            Console.WriteLine("* * * Introduzca cantidad de camisas a añadir: ");
                            _amount = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("* * * Se agregaron " + _amount + " camisas.");
                            carrito.Quantity = carrito.Quantity + _amount;
                            break;
                        case 2:
                            if (_amount > 0)
                            {
                                Console.WriteLine("* * * Introduzca cantidad de camisas a eliminar: ");
                                try
                                {
                                    int aux = Convert.ToInt32(Console.ReadLine());
                                    if (aux <= _amount && aux > 0)
                                    {
                                        _amount = _amount - aux;
                                        carrito.Quantity = _amount;
                                    }
                                    else
                                    {
                                        Console.WriteLine("* * * Error: Fuera de rango.");
                                    }
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("* * * Error: Debe ingresar un numero positivo.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("* * * No hay ninguna camisa para eliminar.");
                            }
                            break;
                        case 3:
                            char confirm;
                            Console.WriteLine("* * * Seguro que desea salir? S/N");
                            try
                            {
                                confirm = Convert.ToChar(Console.ReadLine()[0]);
                                confirm = Char.ToUpper(confirm);

                                if (confirm == 'S')
                                {
                                    Console.WriteLine("Saliendo...");
                                    Environment.Exit(0);
                                }
                                else if (confirm == 'N')
                                {
                                    _option = 0;
                                }
                                else
                                {
                                    Console.WriteLine("* * * No se reconoció opción.");
                                    _option = 0;
                                }
                            }
                            catch (NullReferenceException)
                            {
                                Console.WriteLine("* * * Debe ingresar S para Si, N para No.");
                            }
                            break;
                        case 4:
                            char complete;
                            if (carrito.Quantity != 0)
                            {
                                Console.WriteLine("* * * Seguro que desea realizar la compra? S/N");
                                try
                                {
                                    complete = Convert.ToChar(Console.ReadLine()[0]);
                                    complete = Char.ToUpper(complete);

                                    if (complete == 'S')
                                    {
                                        Console.WriteLine("* * * Compra realizada con exito!");
                                        Console.WriteLine("Saliendo del programa...");
                                        Environment.Exit(0);
                                    }
                                    else if (complete == 'N')
                                    {
                                        _option = 0;
                                    }
                                    else
                                    {
                                        Console.WriteLine("* * * No se reconoció opción.");
                                        _option = 0;
                                    }
                                }
                                catch (NullReferenceException)
                                {
                                    Console.WriteLine("* * * Debe ingresar S para Si, N para No.");
                                }
                            }
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("* * * Error: Debe ingresar un numero positivo.");
                }
            } while (_option != 3);
        }
    }
}