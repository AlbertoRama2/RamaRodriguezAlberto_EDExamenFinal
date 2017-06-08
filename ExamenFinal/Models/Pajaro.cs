using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal.Models
{
    class Pajaro : Animal
    {
        //atributos
        private string Especie;
        private bool Cantor;

        //constructor
        public Pajaro(string nombre, string especie, string fechaNacimiento, double peso, string comentarios, string microship) : base(nombre,especie,fechaNacimiento,peso,comentarios,microship)
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
        public String getEspecie()
        {//metodos de solo lectura
            return Especie;
        }
        public void setEspecie(String especie)//metodos para cambiar el valor
        {
            Especie = especie;
        }

        public bool isCantor()
        {
            return Cantor;
        }

        public void setCantor(bool cantor) //metodos para cambiar el valor
        {
            Cantor = cantor;
        }


        //ToString
        public override string ToString()
        {
            return "Ficha del Pajaro \nNombre :" + Nombre + "\nRaza:" + Raza + "\nFechaNacimiento: " + FechaNacimiento + "\nPeso: " + Peso +
                "\nMicroship:" + Microship + "\nComentarios: " + Comentarios + "\nEs cantor??"+Cantor;
        }
    }
}

