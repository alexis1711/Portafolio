using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo_CS
{
    public class Paciente
    {
        private string codigopaciente, primernombre, segundonombre, primerapellido, segundoapellido, direccion, genero, telefono;
        private string nombreacompañante, parentesco, lugarincidente, diagnostico, codigohospital;
        private int edad;

        public string CodigoPaciente
        {
            get { return codigopaciente; }
            set { codigopaciente = value; }
        }

        public string PrimerNombre
        {
            get { return primernombre; }
            set { primernombre = value; }
        }

        public string SegundoNombre
        {
            get { return segundonombre; }
            set { segundonombre = value; }
        }

        public string PrimerApellido
        {
            get { return primerapellido; }
            set { primerapellido = value; }
        }

        public string SegundoApellido
        {
            get { return segundoapellido; }
            set { segundoapellido = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string NombreAcompañante
        {
            get { return nombreacompañante; }
            set { nombreacompañante = value; }
        }

        public string Parentesco
        {
            get { return parentesco; }
            set { parentesco = value; }
        }

        public string LugarIncidente
        {
            get { return lugarincidente; }
            set { lugarincidente = value; }
        }

        public string Diagnostico
        {
            get { return diagnostico; }
            set { diagnostico = value; }
        }

        public string CodigoHospital
        {
            get { return codigohospital; }
            set { codigohospital = value; }
        }
    }
}

