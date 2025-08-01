/*  
 *  Trabalho Prático POO
 *  Programação Orientada a Objetos
 *  LESI-PL 2022/23
 *  
 *  2ª FASE DO TRABALHO
 * 
 * DIOGO GOMES SILVA - 23893
 * 
 * a23893@alunos.ipca.pt
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPoo
{
    /// <summary>
    /// Classe Bicibox
    /// irá armazenar informações da Bicibox
    /// A Bicibox irá armezenar um determinado numero de veiculos
    /// </summary>

    [Serializable]
    public static class Bicibox
    {
        #region ATRIBUTOS

        /// <summary>
        /// Atributos da classe Bicibox
        /// </summary>

        static int totveiculos;   //numero total de veiculos dentro da bicibox

        static int totveiculosout;   //numero total de veiculos fora da bicibox

        #endregion

        #region PROPRIEDADES

        /// <summary>
        /// Propriedades dos atributos da classe Bicibox
        /// Permitem aceder aos atributos privados atavés dos getters e setters (encapsulamento)
        /// </summary>

        static public int Totveiculos
        {
            get { return totveiculos; }
            set { totveiculos = value; }
        }

        static public int Totveiculosout
        {
            get { return totveiculosout; }
            set { totveiculosout = value; }
        }

        #endregion
    }
}
