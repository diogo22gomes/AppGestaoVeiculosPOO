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
    public class Utilizador : Pessoa
    {
        #region ATRIBUTOS

        double saldo;    //saldo do utilizador

        Veiculo veiculouser;   //armazena o veiculo que o utilizador alugou

        #endregion


        #region PROPRIEDADES

        /// <summary>
        /// Propriedades dos atributos da classe Utilizador
        /// Permitem aceder aos atributos privados atavés dos getters e setters (encapsulamento)
        /// </summary>

        public double Saldo { get { return saldo; } set { saldo = value; } }

        public Veiculo Veiculouser
        {
            get { return veiculouser; }
            set { veiculouser = value; }
        }

        #endregion


        #region CONSTRUTORES

        /// <summary>
        /// Construtores da classe Utilizador
        /// Permitem criar um utilizador
        /// Um dos construtores recebe argumentos e o outro não recebe (Principio do Polimorfismo)
        /// </summary>

        public Utilizador()
        {
            Idstatic++;
            Id = Idstatic;
            Nome = "Utilizador Indef";
            Saldo = 0;
            Tipopessoa = TIPOPESSOA.Utilizador;
        }

        public Utilizador(string nome, int saldo)
        {
            Idstatic++;
            Id = Idstatic;
            this.Nome = nome;
            this.saldo = saldo;
            Tipopessoa = TIPOPESSOA.Utilizador;
        }

        #endregion


        #region Overrides

        /// <summary>
        /// Overrides da classe Pessoa
        /// Permitem mostrar as informacoes dos utilizadores na consola
        /// </summary>

        public override string ToString()    //permite mostrar na consola as informacoes das Pessoas
        {
            string outStr = String.Format("Id: {0}\t Nome: {1}\t Saldo: {2}\t Tipo: {3}\n", Id, Nome, saldo, Tipopessoa);
            return outStr;
        }

        #endregion
    }
}
