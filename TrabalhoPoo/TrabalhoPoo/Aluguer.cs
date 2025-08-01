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
    /// Classe Aluguer
    /// irá armazenar informações dos Alugueres
    /// </summary>
   
    [Serializable]
    public class Aluguer
    {
        #region ATRIBUTOS

        int id = 0;                 //numero de identificacao do aluguer
        static int idalu = 0;      //id estatico dos alugueres
        static int totalug = 0;              //total de alugueres
        double custoalug = 0;         //custo do aluguer

        int tempoalug;

        DateTime datainicio;     //data de inicio do aluguer
        DateTime datafim;        //data de fim do aluguer


        Utilizador user;   //armazena o utilizador que alugou o veiculo

        Veiculo vehicle;   //armazena o veiculo alugado pelo utilizador

        #endregion


        #region PROPRIEDADES

        /// <summary>
        /// Propriedades dos atributos da classe Aluguer
        /// Permitem aceder aos atributos privados atavés dos getters e setters (encapsulamento)
        /// </summary>

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Idalu
        {
            get { return idalu; }
            set { idalu = value; }
        }

        public int Totalug
        {
            get { return totalug; }
            set { totalug = value; }
        }

        public double Custoalug
        {
            get { return custoalug; }
            set { custoalug = value; }
        }

        public DateTime Datainicio
        {
            get { return datainicio; }
            set { datainicio = value; }
        }

        public DateTime Datafim
        {
            get { return datafim; }
            set { datafim = value; }
        }

        public int Tempoalug
        {
            get { return tempoalug; }
            set { tempoalug = value; }
        } 

        public Veiculo Vehicle
        {
            get { return vehicle; }
            set { vehicle = value; }
        }

        public Utilizador User
        {
            get { return user; }
            set { user = value; }
        }

        #endregion


        #region CONSTRUTORES

        /// <summary>
        /// Construtores da classe Aluguer
        /// Permitem criar um Aluguer
        /// Um dos construtores recebe argumentos e o outro não recebe (Principio do Polimorfismo)
        /// </summary>

        public Aluguer()
        {
            Idalu++;
            Id = Idalu;
            Totalug++;
            Datainicio = DateTime.Now;
            Datafim = DateTime.Now.AddHours(1);
            Tempoalug = 0;
        }

        public Aluguer(DateTime now, DateTime then, int tempo)
        {
            Idalu++;
            Id = Idalu;
            Totalug++;
            Datainicio = now;
            Datafim = then;

            Tempoalug = tempo;
        }

        #endregion


        #region Overrides

        /// <summary>
        /// Overrides da classe Aluguer
        /// Permitem mostrar as informacoes dos alugueres na consola
        /// </summary>

        public override string ToString()    //permite mostrar na consola as informacoes dos alugueres
        {
            Console.WriteLine("\nInfo do Aluguer: ");
            string outStr = String.Format("Id Aluguer: {0}\t Data Inicio: {1}\t Data Fim: {2}\t Tempo do Aluguer: {3}\t Custo do Aluguer: {4}\n" +
                "\nUtilizador que Alugou: \nUtilizador: {5}\nVeiculo Alugado: \nVeiculo: {6}\n", Id, datainicio, datafim, Tempoalug, Custoalug, User, Vehicle);
            return outStr;
            Console.WriteLine("------------");
        }

        #endregion
    }
}
