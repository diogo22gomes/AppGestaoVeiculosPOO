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
    [Serializable]
    public enum TIPOPESSOA   //enumerado tipos de pessoas
    {
        Utilizador,
        Funcionario,
        Mecanico
    }


    /// <summary>
    /// Classe Pessoa
    /// irá armazenar informações das Pessoas
    /// </summary>

    [Serializable]
    public class Pessoa
    {
        #region ATRIBUTOS

        /// <summary>
        /// Atributos da classe Pessoa
        /// </summary>

        string nome;  //nome da pessoa
        int id = 0;       //id da pessoa
        static int idstatic = 0 ;   //id static da classe pessoas

        TIPOPESSOA tipopessoa;

        #endregion


        #region PROPRIEDADES

        /// <summary>
        /// Propriedades dos atributos da classe Pessoa
        /// Permitem aceder aos atributos privados atavés dos getters e setters (encapsulamento)
        /// </summary>

        public string Nome { get { return nome; } set { nome = value; } }

        public int Id { get { return id; } set { id = value; } }

        public int Idstatic { get { return idstatic; } set { idstatic = value; } }

        public TIPOPESSOA Tipopessoa
        {
            get { return tipopessoa; }
            set { tipopessoa = value; }
        }

        #endregion

    }
}
