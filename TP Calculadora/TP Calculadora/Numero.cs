using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Calculadora
{
    class Numero
    {
        private double _numero;


        /// <summary>
        /// El constructor por defecto el inicializará el atributo numero en cero en 0 
        /// </summary>
        public Numero()
        {
            this._numero = 0;
        }

        /// <summary>
        /// recibirá un double y cargará en número
        /// </summary>
        /// <param name="numero"></param>
        public Numero(double numero)
            : this()
        {
            this._numero = numero;
        }

        /// <summary>
        /// String que validará y cargará en número 
        /// </summary>
        /// <param name="numero"></param>
        public Numero(string numero)
        {
            this._setNumero(numero);
        }

        public double getNumero()
        {
            return this._numero;
        }

        /// <summary>
        /// Contendrá un método privado del tipo setter. Este será el único lugar donde se podrá utilizar el método validarNumero.
        /// </summary>
        /// <param name="numero"></param>
        private void _setNumero(string numero)
        {
            this._numero = Numero._validarNumero(numero);
        }

        /// <summary>
        /// Generar un método privado y de clase llamado validarNumero(string): double. Validará que se trate de un double válido, caso contrarioretornará 0. 
        /// </summary>
        /// <param name="numeroString"></param>
        /// <returns></returns>
        private static double _validarNumero(string numeroString)
        {
            double numDouble;
            if (double.TryParse(numeroString, out numDouble))
            {
                return numDouble;
            }
            else
            {
                return 0;
            }


        }
    }
}
