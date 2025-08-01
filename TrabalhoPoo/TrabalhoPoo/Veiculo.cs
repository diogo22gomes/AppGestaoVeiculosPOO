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
    /// Enumerados da classe Veiculo
    /// </summary>
    
    [Serializable]
    public enum TIPOVEICULO   //enumerado dos tipos de veiculo
    {
        Bicicleta,
    }

    [Serializable]
    public enum ESTADOVEICULO   //enumerado dos estados do veiculo
    {
        Disponivel,
        Ocupado,
        Avariado
    }

    /// <summary>
    /// Classe Veiculo
    /// irá armazenar informações dos Veiculos
    /// </summary>

    [Serializable]
    public class Veiculo
    {
        #region ATRIBUTOS

        /// <summary>
        /// Atributos da classe Veiculo
        /// </summary>

        int id ;           //numero de identificacao do veiculo
        double custo;     //valor do custo do veiculo
        static int idstatic = 0;    //id estatico da classe veiculo


        TIPOVEICULO tipoveiculo;           //tipo de veiculo
        ESTADOVEICULO estadoveiculo;       //estado do veiculo

        #endregion


        #region PROPRIEDADES

        /// <summary>
        /// Propriedades dos atributos da classe Veiculo
        /// Permitem aceder aos atributos privados atavés dos getters e setters (encapsulamento)
        /// </summary>

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public double Custo
        {
            get { return custo; }
            set { custo = value; }
        }

        public int Idstatic
        {
            get { return idstatic; }
            set { idstatic = value; }
        }

        public TIPOVEICULO Tipoveiculo
        {
            get { return tipoveiculo; }
            set { tipoveiculo = value; }
        }

        public ESTADOVEICULO Estadoveiculo
        {
            get { return estadoveiculo; }
            set { estadoveiculo = value; }
        }

        #endregion


        #region CONSTRUTORES

        /// <summary>
        /// Construtores da classe Veiculo
        /// Permitem criar um veiculo
        /// Um dos construtores recebe argumentos e o outro não recebe (Principio do Polimorfismo)
        /// </summary>

        public Veiculo()
        {
            idstatic++;
            Id = idstatic;
            Tipoveiculo = TIPOVEICULO.Bicicleta;
            Estadoveiculo = ESTADOVEICULO.Disponivel;
            Custo = 0.2;
        }

        public Veiculo(TIPOVEICULO tipo, ESTADOVEICULO estado, double custo)
        {
            idstatic++;
            Id = idstatic;
            Tipoveiculo = tipo;
            Estadoveiculo = estado;
            this.custo = custo;
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Overrides da classe Veiculo
        /// Permitem mostrar as informacoes dos veiculos na consola
        /// </summary>

        public override string ToString()  //permite mostrar na consola as informacoes dos veiculos
        {
            string outStr = String.Format("Id: {0}\t Tipo de Veiculo: {1}\t Estado: {2}\t Custo: {3}\n", id, Tipoveiculo, Estadoveiculo, Custo);
            return outStr;
        }

        #endregion

    }
}
