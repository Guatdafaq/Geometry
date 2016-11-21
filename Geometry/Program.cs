using Geometry.Figures;
using Geometry.Points;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salirPrograma = false;
            bool salirMenu = false;
            int menu = 0;
            int submenu = 0;
            do
            {
                Console.WriteLine("------------Bienvenido al programa Geometry------------");
                Console.WriteLine("1- Trabajar en 2D");
                Console.WriteLine("2- Trabajar en 3D");
                Console.WriteLine("0- Salir del programa");
                menu = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (menu)
                {
                    case 1:
                        Console.WriteLine("------------Tipo de figura geométrica------------");

                        do
                        {
                            Console.WriteLine(" 1- Trabajar con Círculos");
                            Console.WriteLine(" 2- Trabajar con Cuadriláteros");
                            Console.WriteLine("-1- Salir al menú principal");
                            Console.WriteLine(" 0- Salir del programa");
                            submenu = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            switch (submenu)
                            {
                                case 1:
                                    Console.WriteLine("------------Círculos------------");
                                    Point2D centro = PedirCoordenadasPunto2D();
                                    Console.WriteLine("Introduce el radio: ");
                                    double radio = Convert.ToDouble(Console.ReadLine());
                                    Circle<Point2D> circulo = new Circle<Point2D>(centro, radio);
                                    Console.WriteLine("---------------------------------");
                                    Console.WriteLine($"Círculo: {circulo}");
                                    Console.WriteLine($"Área: {circulo.Area()}");
                                    Console.WriteLine($"Perímetro: {circulo.Perimeter()}");
                                    Console.WriteLine("---------------------------------");
                                    break;
                                case 2:   
                                    Console.WriteLine("------------Cuadriláteros------------");
                                    List<Point2D> puntos = new List<Point2D>();
                                    for(int i=0; i<4; i++)
                                    {
                                        puntos.Add(PedirCoordenadasPunto2D());
                                    }
                                    Quadrilateral<Point2D> cuadrilatero = new Quadrilateral<Point2D>(puntos[0], puntos[1], puntos[2], puntos[3]);
                                    Console.WriteLine("---------------------------------");
                                    Console.WriteLine($"Cuadrilátero: {cuadrilatero}");
                                    Console.WriteLine($"Área: {cuadrilatero.Area()}");
                                    Console.WriteLine($"Perímetro: {cuadrilatero.Perimeter()}");
                                    Console.WriteLine("---------------------------------");
                                    break;
                                case -1:
                                    salirMenu = true;
                                    break;
                                case 0:
                                    salirMenu = true;
                                    salirPrograma = true;
                                    break;
                                
                            }
                        } while (!salirMenu);
                        salirMenu = false;
                        Console.Clear();  
                        break;
                    case 2:
                        Console.WriteLine("------------Tipo de figura geométrica------------");

                        do
                        {
                            Console.WriteLine(" 1- Trabajar con Círculos");
                            Console.WriteLine(" 2- Trabajar con Cuadriláteros");
                            Console.WriteLine("-1- Salir al menú principal");
                            Console.WriteLine(" 0- Salir del programa");
                            submenu = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            switch (submenu)
                            {
                                case 1:
                                    Console.WriteLine("------------Círculos------------");
                                    Point3D centro = PedirCoordenadasPunto3D();
                                    Console.WriteLine("Introduce el radio: ");
                                    double radio = Convert.ToDouble(Console.ReadLine());
                                    Circle<Point3D> circulo = new Circle<Point3D>(centro, radio);
                                    Console.WriteLine("---------------------------------");
                                    Console.WriteLine($"Círculo: {circulo}");
                                    Console.WriteLine($"Área: {circulo.Area()}");
                                    Console.WriteLine($"Perímetro: {circulo.Perimeter()}");
                                    Console.WriteLine("---------------------------------");
                                    break;
                                case 2:
                                    Console.WriteLine("------------Cuadriláteros------------");
                                    List<Point3D> puntos = new List<Point3D>();
                                    for (int i = 0; i < 4; i++)
                                    {
                                        puntos.Add(PedirCoordenadasPunto3D());
                                    }
                                    Quadrilateral<Point3D> cuadrilatero = new Quadrilateral<Point3D>(puntos[0], puntos[1], puntos[2], puntos[3]);
                                    Console.WriteLine("---------------------------------");
                                    Console.WriteLine($"Cuadrilátero: {cuadrilatero}");
                                    Console.WriteLine($"Área: {cuadrilatero.Area()}");
                                    Console.WriteLine($"Perímetro: {cuadrilatero.Perimeter()}");
                                    Console.WriteLine("---------------------------------");
                                    break;
                                case -1:
                                    salirMenu = true;
                                    break;
                                case 0:
                                    salirMenu = true;
                                    salirPrograma = true;
                                    break;

                            }
                        } while (!salirMenu);
                        salirMenu = false;
                        Console.Clear();
                        break;
                    case 0:
                        salirPrograma = true;
                        break;
                }
            } while (!salirPrograma);
        }
        public static Point2D PedirCoordenadasPunto2D()
        {
            double pX, pY;
            Console.WriteLine("Introduce la coordenada X del punto: ");
            pX = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduce la coordenada Y del punto: ");
            pY = Convert.ToDouble(Console.ReadLine());
            return new Point2D(pX, pY);
        }

        public static Point3D PedirCoordenadasPunto3D()
        {
            double pX, pY, pZ;
            Console.WriteLine("Introduce la coordenada X del punto: ");
            pX = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduce la coordenada Y del punto: ");
            pY = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduce la coordenada Z del punto: ");
            pZ = Convert.ToDouble(Console.ReadLine());
            return new Point3D(pX, pY, pZ);
        }
    }
}
