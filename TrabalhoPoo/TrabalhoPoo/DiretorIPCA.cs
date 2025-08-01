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
    /// Classe DiretorIPCA 
    /// </summary>

    [Serializable]
    static public class DiretorIPCA
    {

        #region ATRIBUTOS

        /// <summary>
        /// Atributos da classe DiretorIPCA 
        /// </summary>

        static string nome;  //nome do diretor

        #endregion


        #region PROPERTIES

        /// <summary>
        /// Propriedades dos atributos da classe DiretorIPCA 
        /// Permitem aceder aos atributos privados atavés dos getters e setters (encapsulamento)
        /// </summary>

        static public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        #endregion

    }
}
