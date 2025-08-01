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
    /// Atributos da classe Mecanico
    /// </summary>

    [Serializable]
    public class Mecanico : Pessoa
    {
        #region ATRIBUTOS

        /// <summary>
        /// Propriedades dos atributos da classe Funcionario 
        /// Permitem aceder aos atributos privados atavés dos getters e setters (encapsulamento)
        /// </summary>

        int numerorepar = 0;

        #endregion


        #region PROPRIEDADES

        public int Numerorepar
        {
            get { return numerorepar; }
            set { numerorepar = value; }
        }

        #endregion


        #region CONSTRUTORES

        public Mecanico()
        {
            Idstatic++;
            Id = Idstatic;
            Nome = "Mecanico Indef";
            Tipopessoa = TIPOPESSOA.Mecanico;
        }

        public Mecanico(string nome)
        {
            Idstatic++;
            Id = Idstatic;
            this.Nome = nome;
            Tipopessoa = TIPOPESSOA.Mecanico;
        }

        #endregion


        #region Overrides

        /// <summary>
        /// Overrides da classe Mecanico
        /// Permitem mostrar as informacoes dos utilizadores na consola
        /// </summary>

        public override string ToString()    //permite mostrar na consola as informacoes dos Mecanicos
        {
            string outStr = String.Format("Id: {0}\t Nome: {1}\t Numero de Reparacoes: {2}\t Tipo: {3}\n", Id, Nome, Numerorepar, Tipopessoa);
            return outStr;
        }

        #endregion
    }
}
