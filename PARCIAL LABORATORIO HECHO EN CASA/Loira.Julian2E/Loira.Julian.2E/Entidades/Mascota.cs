using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Mascota
    {

        #region Atributos
        private string _nombre;
        private string _raza;
        #endregion

        #region Propiedades
        public string Nombre
        { 
            get{    return this._nombre; }
        }

        public string Raza
        {
            get{    return this._raza; }
        }
        #endregion

        #region Constructores
        public Mascota(string nombre,string raza)
        {
            this._nombre = nombre;
            this._raza = raza;
        }
        #endregion

        #region Metodos
        protected abstract string Ficha();

        protected virtual string DatosCompletos()
        {
            string sMascota = string.Format("{0} {1} ", this._nombre, this._raza);
            return sMascota;
        }
        #endregion
    }
}
