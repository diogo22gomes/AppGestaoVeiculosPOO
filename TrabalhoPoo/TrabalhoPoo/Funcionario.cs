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
    /// Classe Funcionario
    /// </summary>


    [Serializable]
    public class Funcionario : Pessoa
    {
        /// <summary>
        /// Atributos da classe Funcionario
        /// </summary>

        #region ATRIBUTOS

        int numerocol = 0;    //numero de veiculos colocados pelo funcionario na bicibox

        #endregion


        #region PROPRIEDADES


        /// <summary>
        /// Propriedades dos atributos da classe Funcionario 
        /// Permitem aceder aos atributos privados atavés dos getters e setters (encapsulamento)
        /// </summary>
        
        public int Numerocol
        {
            get { return numerocol; }
            set { numerocol = value; }
        }

        #endregion


        #region CONSTRUTORES

        public Funcionario()
        {
            Idstatic++;
            Id = Idstatic;
            Nome = "Funcionario Indef";
            Tipopessoa = TIPOPESSOA.Funcionario;
        }

        public Funcionario(string nome)
        {
            Idstatic++;
            Id = Idstatic;
            this.Nome = nome;
            Tipopessoa = TIPOPESSOA.Funcionario;
        }

        #endregion


        #region Overrides

        /// <summary>
        /// Overrides da classe Mecanico
        /// Permitem mostrar as informacoes dos funcionarios na consola
        /// </summary>

        public override string ToString()    //permite mostrar na consola as informacoes dos funcionarios
        {
            string outStr = String.Format("Id: {0}\t Nome: {1}\t Numero de Colocacoes: {2}\t Tipo: {3}\n", Id, Nome, Numerocol, Tipopessoa);
            return outStr;
        }

        #endregion

    }
}
