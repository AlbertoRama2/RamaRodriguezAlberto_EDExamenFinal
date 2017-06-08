using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal.Models
{
    class Clinica
    {
        //Creamos Lista de animales para guardarlos dentro del programa
        private List<Animal> ListaAnimales = new List<Animal>();

        public string aux2 { get; private set; }

        //Constructor de la lista
        public List<Animal> getListaAnimales()
        {
            return ListaAnimales;
        }


        //Metodos
        //Añadir
        public void aniadir()
        {
            string Nombre;
            string FechaNacimiento;
            double Peso;
            string Comentarios;
            string Raza;
            string Microship;
            string Especie;
            string aux;
            bool esCorrecto;
            short n;

            do
            {
                Console.WriteLine("/**MENU**/");
                Console.WriteLine("1. Añadir animal");
                Console.WriteLine("2. Cambiar comentario");
                Console.WriteLine("3. Mostrar animal");
                Console.WriteLine("4. Salir");
                Console.WriteLine("¿Que desea hacer?");
                aux = Console.ReadLine();

                esCorrecto = short.TryParse(aux, out n);
                if (!esCorrecto)
                {
                    Console.WriteLine("No has introducido un numero");
                    esCorrecto = false;

                }
                else if (n < 1 || n > 4)
                {

                    Console.WriteLine("Por favor, introduzca una opcion valida del menu");
                    esCorrecto = false;
                }
                else
                {
                    esCorrecto = true;
                }


            switch (n)
            {
                case 1://Añadir animales
                    do
                    {
                        Console.WriteLine("/**MENU AÑADIR**/");
                        Console.WriteLine("1. Perro");
                        Console.WriteLine("2. Gato");
                        Console.WriteLine("3. Pajaro");
                        Console.WriteLine("4. Reptil");
                        Console.WriteLine("¿Que desea hacer?");
                        aux = Console.ReadLine();

                        esCorrecto = short.TryParse(aux, out n);
                        if (!esCorrecto)
                        {
                            Console.WriteLine("No has introducido un numero");
                            esCorrecto = false;

                        }
                        else if (n < 1 || n > 4)
                        {

                            Console.WriteLine("Por favor, introduzca una opcion valida del menu");
                            esCorrecto = false;
                        }
                        else
                        {
                            esCorrecto = true;
                        }
                    } while (n>4);

                    switch (n)
                    {
                        case 1://Añadimos perro
                            Console.Write("Nombre: ");
                            Nombre = Console.ReadLine();
                            Console.Write("Raza: ");
                            Raza = Console.ReadLine();
                            Console.Write("Fecha Nacimiento: ");
                            FechaNacimiento = Console.ReadLine();
                            Console.Write("Peso: ");
                            aux2 = Console.ReadLine();
                            esCorrecto = double.TryParse(aux, out Peso);
                            if (esCorrecto)
                            {
                                if (Peso <= 0)
                                {
                                    esCorrecto = false;
                                }
                            }
                            if (!esCorrecto)
                            {
                                Console.WriteLine("ERROR: Peso incorrecto");
                            };
                            Console.Write("Comentarios: ");
                            Comentarios = Console.ReadLine();
                            Console.Write("Microship: ");
                            Microship = Console.ReadLine();
                            ListaAnimales.Add(new Perro(Nombre, Raza, FechaNacimiento, Peso, Comentarios, Microship));

                            break;
                        case 2://añadimos gato
                            Console.Write("Nombre: ");
                            Nombre = Console.ReadLine();
                            Console.Write("Raza: ");
                            Raza = Console.ReadLine();
                            Console.Write("Fecha Nacimiento: ");
                            FechaNacimiento = Console.ReadLine();
                            Console.Write("Peso: ");
                            aux2 = Console.ReadLine();
                            esCorrecto = double.TryParse(aux, out Peso);
                            if (esCorrecto)
                            {
                                if (Peso <= 0)
                                {
                                    esCorrecto = false;
                                }
                            }
                            if (!esCorrecto)
                            {
                                Console.WriteLine("ERROR: Peso incorrecto");
                            };
                            Console.Write("Comentarios: ");
                            Comentarios = Console.ReadLine();
                            Console.Write("Microship: ");
                            Microship = Console.ReadLine();
                            ListaAnimales.Add(new Gato(Nombre, Raza, FechaNacimiento, Peso, Comentarios, Microship));

                            break;
                        case 3://Añadimos pajaro
                            Console.Write("Nombre: ");
                            Nombre = Console.ReadLine();
                            Console.Write("Especie: ");
                            Especie = Console.ReadLine();
                            Console.Write("Fecha Nacimiento: ");
                            FechaNacimiento = Console.ReadLine();
                            Console.Write("Peso: ");
                            aux2 = Console.ReadLine();
                            esCorrecto = double.TryParse(aux, out Peso);
                            if (esCorrecto)
                            {
                                if (Peso <= 0)
                                {
                                    esCorrecto = false;
                                }
                            }
                            if (!esCorrecto)
                            {
                                Console.WriteLine("ERROR: Peso incorrecto");
                            };
                            Console.Write("Comentarios: ");
                            Comentarios = Console.ReadLine();
                            Console.Write("Microship: ");
                            Microship = Console.ReadLine();
                            ListaAnimales.Add(new Pajaro(Nombre, Especie, FechaNacimiento, Peso, Comentarios, Microship));

                            break;
                        case 4://Añadimos reptil
                            Console.Write("Nombre: ");
                            Nombre = Console.ReadLine();
                            Console.Write("Especie: ");
                            Especie = Console.ReadLine();
                            Console.Write("Fecha Nacimiento: ");
                            FechaNacimiento = Console.ReadLine();
                            Console.Write("Peso: ");
                            aux2 = Console.ReadLine();
                            esCorrecto = double.TryParse(aux, out Peso);
                            if (esCorrecto)
                            {
                                if (Peso <= 0)
                                {
                                    esCorrecto = false;
                                }
                            }
                            if (!esCorrecto)
                            {
                                Console.WriteLine("ERROR: Peso incorrecto");
                            };
                            Console.Write("Comentarios: ");
                            Comentarios = Console.ReadLine();
                            Console.Write("Microship: ");
                            Microship = Console.ReadLine();
                            ListaAnimales.Add(new Reptil(Nombre, Especie, FechaNacimiento, Peso, Comentarios, Microship));

                            break;
                    }
                    break;
                case 2://Modificar Comentarios
                    Console.WriteLine("No me a dado tiempo profe");
                    break;
                case 3://Pesar animal
                    Console.WriteLine("No me a dado tiempo profe");
                    break;
                case 4://Salir del programa
                    Console.WriteLine("Hasta la proxima");
                    break;

            }
            } while (n !=4);
        }
        public string buscarAnimal()
        {
            Console.Write("Nombre del animal:");
            return Console.ReadLine();
        }

        public void cambiarPeso()
        {

        }
       
    }
    
}
