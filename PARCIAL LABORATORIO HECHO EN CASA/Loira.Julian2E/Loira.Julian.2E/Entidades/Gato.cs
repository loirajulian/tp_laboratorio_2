using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gato:Mascota
    {
        #region Constructores

        public Gato(string nombre, string raza) : base(nombre, raza)
        {

        }
        #endregion

        #region Metodos

        public override bool Equals(object obj)
        {
            if (obj is Gato)
            {
                return (this == (Gato)obj);
            }
            return false;
        }

        protected override string Ficha()
        {
            StringBuilder sbFicha = new StringBuilder();
            sbFicha.Append(base.DatosCompletos());
            return sbFicha.ToString();
        }

        public static bool operator ==(Gato obj1, Gato obj2)
        {
            if (!object.ReferenceEquals(obj1, null) && !object.ReferenceEquals(obj2, null))
            {
                if (obj1.Nombre == obj2.Nombre && obj1.Raza == obj2.Raza)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Gato obj1, Gato obj2)
        {
            return !(obj1 == obj2);
        }

        public override string ToString()
        {
            return this.Ficha();
        }
        #endregion
    }
}
