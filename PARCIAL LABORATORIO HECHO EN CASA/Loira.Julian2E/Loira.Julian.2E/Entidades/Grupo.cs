using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Grupo
    {
        #region Enumerado
        public enum TipoManada {Unica,Mixta }
        #endregion

        #region Atributos
        string _nombre;
        static TipoManada _tipo;
        List<Mascota> _manada;
        #endregion

        #region Constructores
        public Grupo()
        {
            this._manada = new List<Mascota>();
        }

        static Grupo()
        {
            _tipo = TipoManada.Unica;
        }

        public Grupo(string nombre) : this()
        {
            this._nombre = nombre;
        }

        public Grupo(string nombre, TipoManada tipo) : this(nombre)
        {

        }

        #endregion

        #region Propiedades
        public TipoManada Tipo
        {
            set
            {
                _tipo = value;
            }
        }
        #endregion

        #region Metodos
        public static implicit operator string(Grupo e)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("** {0} {1}**\n", e._nombre, Grupo._tipo);
            sb.AppendLine("Integrantes: ");
            foreach (Mascota v in e._manada)
            {
                sb.AppendLine(v.ToString());
            }
            return sb.ToString();
        }

        public static bool operator ==(Grupo e, Mascota j)
        {
            if (!object.ReferenceEquals(e, null) && !object.ReferenceEquals(j, null))
            {
                foreach (Mascota v in e._manada)
                {
                    if (v == j)
                        return true;
                }
            }
            return false;
        }

        public static bool operator !=(Grupo e, Mascota j)
        {
            return !(e == j);
        }

        public static Grupo operator +(Grupo e, Mascota j)
        {
            foreach (Mascota v in e._manada)
            {
                if (v == j)
                    return e;
            }
            e._manada.Add(j);
            return e;
        }

        public static Grupo operator -(Grupo e, Mascota j)
        {
            foreach (Mascota v in e._manada)
            {
                if (v == j)
                {
                    e._manada.Remove(j);
                    break;
                }
            }
            return e;
        }

        #endregion
    }
}
