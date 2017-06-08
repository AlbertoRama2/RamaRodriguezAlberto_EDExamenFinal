using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal.Models
{
    class Gato : Animal
    {
        //atributos
        private string Raza;
        private string Microship;

        //constructor
        public Gato(string nombre, string raza, string fechaNacimiento, double peso, string comentarios, string microship) : base(nombre,raza,fechaNacimiento,peso,comentarios,microship)
        {

        }

        //Getters and Setters
        public string Raza1
        {
            get
            {
                return Raza;
            }
        }

        public string Microship1
        {
            get
            {
                return Microship;
            }
        }

        //Metodos
        public String getRaza()//metodos de solo lectura
        {
            return Raza;
        }
        public void setRaza(String raza)//metodos para cambiar el valor
        {
            Raza = raza;
        }
        public String getMicroship()
        {
            return Microship;
        }
        public void setMicrochip(String microship)
        {
            Microship = microship;
        }


        //ToString
        public override string ToString()
        {
            return "Ficha del Gato \nNombre :" + Nombre + "\nRaza:" + Raza + "\nFechaNacimiento: " + FechaNacimiento + "\nPeso: " + Peso +
                "\nMicroship:" + Microship + "\nComentarios: " + Comentarios;
        }
    }
}
