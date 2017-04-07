using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Calculadora
{
    class Calculadora
    {
        /// <summary>
        /// Generar un método de clase llamado operar que reciba dos objetos del tipo Numero llamador numero1 y numero2, y un String llamado operador.Su valor de retorno será del tipo double. Si no puede operar (división por 0), retornará 0.
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns></returns>

        public static double Operar(Numero numero1, Numero numero2, string operador)
        {
            switch (Calculadora.validarOperador(operador))//Valido mi operador con el metodo requerido
            {
                case "+":
                    return numero1.getNumero() + numero2.getNumero(); //Utilizo los get para traer el valor de numero
                    break;
                case "-":
                    return numero1.getNumero() - numero2.getNumero();
                    break;
                case "*":
                    return numero1.getNumero() * numero2.getNumero();
                    break;
                case "/":
                    if (numero2.getNumero() == 0) //Condiciono que si el segundo numero es 0 el valor de retorno sea 0
                    {
                        return 0;
                    }
                    else
                    {
                        return numero1.getNumero() / numero2.getNumero();
                    }

                default: //Entiendo que no deberia entrar al default ya que los operadores del switch son las unicas opciones de eleccion en el combo box
                    return 0;
                    break;
            }
        }

        /// <summary>
        /// Codificar un método de clase llamado validarOperador(string) : string. Validará que el operador sea un caracter válido, caso contrario retornará “+”. 
        /// </summary>
        /// <param name="operador"></param>
        /// <returns></returns>

        public static string validarOperador(string operador)
        {
            switch (operador)
            {
                case "-":
                    return "-";
                    break;
                case "*":
                    return "*";
                    break;
                case "/":
                    return "/";
                    break;
                default:
                    return "+";
                    break;
            }
        }
    }
}
