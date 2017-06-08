using ExamenFinal.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal.Models
{
    abstract class Animal : IPesable
    {
        //atributos
        protected string Nombre;
        protected string FechaNacimiento;
        protected double Peso;
        protected string Comentarios;
        protected string Raza;
        protected string Microship;
        protected string Especie;

        //constructor
        public Animal(string nombre,string fechaNacimiento, double peso, string comentarios)
        {
            Nombre = nombre;
            FechaNacimiento = fechaNacimiento;
            Peso = peso;
            Comentarios = comentarios;
        }

        public Animal(string nombre, string raza, string fechaNacimiento, double peso,string comentarios , string microship)
        {
            Nombre = nombre;
            Raza = raza;
            FechaNacimiento = fechaNacimiento;
            Peso = peso;
            Comentarios = comentarios;
            Microship=microship;
        }


        //Getters and Setters
        public string Nombre1
        {
            get
            {
                return Nombre;
            }
            set
            {
                Nombre = value;
            }
        }

        public string FechaNacimiento1
        {
            get
            {
                return FechaNacimiento;
            }
            set
            {
                FechaNacimiento = value;
            }
        }

        public double Peso1
        {
            get
            {
                return Peso;
            }
            set
            {
                Peso = value;
            }
        }

        public string Comentarios1
        {
            get
            {
                return Comentarios;
            }
            set
            {
                Comentarios = value;
            }
        }


        //Metodos de la interfaz
        public void pesar(double peso)
        {
            throw new NotImplementedException();
        }

        public double peso()
        {
            throw new NotImplementedException();
        }
    }
}
