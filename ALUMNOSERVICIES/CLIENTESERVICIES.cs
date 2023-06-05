using Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TienditaDoñaYoli;

namespace TienditaDoñaYoli
{
    public class ClienteServices
    {
        public ClienteComprador AgregarDatos()
        {
            try
            {
                ClienteComprador datos = new ClienteComprador();

                Console.Write("Ingresar su Nombre: ");
                datos.Nombre = Console.ReadLine();

                Console.WriteLine("Ingrese su Apellido");
                datos.Apellido = Console.ReadLine();

                Console.Write("Ingrese su Telefono: ");
                datos.Telefono = Console.ReadLine();

                Console.Write("Ingrese su Correo: ");
                datos.Correo = Console.ReadLine();

                return datos;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }



        public int SumaDelProducto()
        {
            try
            {
                int PuntosTotal = 0;
                Console.WriteLine("Ingrese los puntos del articulo: ");

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Articulo: ", i);
                    int numero = Convert.ToInt32(Console.ReadLine());
                    PuntosTotal += numero;
                }

                Console.Clear();
                Console.Write("Suma Total:");
                Console.WriteLine(PuntosTotal);

                if (PuntosTotal >= 10000)
                {
                    Console.WriteLine("Tienes la opción de elegir entre 3 o 6 meses sin intereses");
                    Console.WriteLine("¿Cuántos meses sin intereses deseas? (3 o 6):");
                    int MesesSinIntereses = Convert.ToInt32(Console.ReadLine());
                    double descuento;
                    if (MesesSinIntereses == 3)
                    {
                        Console.Clear();
                        Console.WriteLine("Total Sin Descuento: " + PuntosTotal);
                        Console.WriteLine("¡Elegiste 3 meses sin intereses!");
                        Console.WriteLine();
                        PuntosTotal = PuntosTotal / 3;
                        Console.WriteLine("Total Con Descuento: " + PuntosTotal);
                    }
                    else if (MesesSinIntereses == 6)
                    {
                        Console.Clear();
                        Console.WriteLine("Total Sin Descuento: " + PuntosTotal);
                        Console.WriteLine("Elegiste 6 meses sin intereses");
                        Console.WriteLine();
                        PuntosTotal = PuntosTotal / 6;
                        Console.WriteLine("Total Con Descuento Aplicado: " + PuntosTotal);
                    }
                    else
                    {
                        throw new Exception("Debes elegir entre 3 o 6 meses sin intereses.");
                    }
                }
                else if (PuntosTotal >= 8000)
                {
                    Console.Clear();
                    Console.WriteLine("Total Sin Descuento: " + PuntosTotal);
                    Console.WriteLine("Tienes 3 meses sin intereses");
                    Console.WriteLine();
                    PuntosTotal = PuntosTotal / 3;
                    Console.WriteLine("Total Con Descuento Aplicado: " + PuntosTotal);
                }
                else if (PuntosTotal >= 5000)
                {
                    Console.Clear();
                    Console.WriteLine("Total Sin Descuento: " + PuntosTotal);
                    Console.WriteLine("Tienes un descuento del 10%");
                    Console.WriteLine();
                    double descuento = PuntosTotal * 0.1;
                    PuntosTotal -= (int)descuento;
                    Console.WriteLine("Total Con Descuento: " + PuntosTotal);
                }

                return PuntosTotal;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }


        public void ImprimirDatosCliente(Clientes request)
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("Datos Del Cliente:");
                Console.WriteLine("Nombre: " + request.Nombre);
                Console.WriteLine("Apellidos: " + request.Apellido);
                Console.WriteLine("Telefono: " + request.Telefono);
                Console.WriteLine("Correo: " + request.Correo);
            }
            catch (Exception ex)
            {
                throw new Exception("Error " + ex.Message);
            }
        }
    }
}
