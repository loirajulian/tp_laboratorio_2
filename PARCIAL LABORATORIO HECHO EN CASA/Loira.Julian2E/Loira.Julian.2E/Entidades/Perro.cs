using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Perro:Mascota
    {
        #region Atributos
        private int _edad;
        private bool _esAlfa;
        #endregion

        #region Propiedades
        public int Edad
        {
            get
            {   return this._edad;  }
            set 
            {   this._edad = value; }
        }

        public bool EsAlfa
        {
            get
            { return this._esAlfa; }
            set
            { this._esAlfa = value; }
        }
        #endregion

        #region Constructores
        public Perro(string nombre, string raza, int edad, bool esAlfa): base(nombre, raza)
        {
            this.Edad = edad;
            this.EsAlfa = esAlfa;
        }

        public Perro(string nombre, string raza): this(nombre,raza,0,false)
        {
            
        }
        #endregion

        #region Metodos
        public static explicit operator int(Perro perro)
        {
            int returneExplicit = perro._edad;
            return returneExplicit;
        }

        protected override string Ficha()
        {
            StringBuilder sbFicha = new StringBuilder();

            if (this._esAlfa == true)
            {
                sbFicha.Append(base.DatosCompletos() +",alfa de la manada, " +"edad "+this._edad);
            }
            else
            {
                sbFicha.Append(base.DatosCompletos() + "edad " + this._edad);
            }

            return sbFicha.ToString();
        }

        public static bool operator ==(Perro j1, Perro j2)
        {
            if (!object.ReferenceEquals(j1, null) && !object.ReferenceEquals(j2, null))
            {
                if (j1.Nombre == j2.Nombre && j1.Raza == j2.Raza && j1._edad == j2._edad)
                    return true;
            } return false;
        }

        public static bool operator !=(Perro j1, Perro j2)
        {
            return !(j1 == j2);
        }

        public override bool Equals(object obj)
        {
            if (obj is Perro)
            {
                return (this == (Perro)obj);
            }
            return false;
        } 

        public override string ToString()
        {
            return this.Ficha();
        }
        #endregion
    }
}
