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
    /// Enumerados da classe VeiculoEletrico
    /// </summary>

    [Serializable]
    public enum TIPOVEICULOELET    //enumerado dos tipos de veiculo
    {
        BicicletaElet,
        TrotineteElet
    }

    /// <summary>
    /// Classe VeiculoEletrico (Herança)
    /// irá armazenar informações dos Veiculos elétricos
    /// </summary>

    [Serializable]
    public class VeiculoEletrico : Veiculo
    {
        #region ATRIBUTOS

        /// <summary>
        /// Atributos da classe VeiculoEletrico
        /// </summary>

        int autonomia;  //autonomia do veiculo
        int carga;   //carga eletrica do veiculo

        TIPOVEICULOELET tipoveiculoelet;   //tipo de veiculo eletrico

        #endregion


        #region PROPRIEDADES

        /// <summary>
        /// Propriedades dos atributos da classe VeiculoEletrico
        /// Permitem aceder aos atributos privados atavés dos getters e setters (encapsulamento)
        /// </summary>

        public int Autonomia
        {
            get { return autonomia; }
            set { autonomia = value; }
        }

        public int Carga
        {
            get { return carga; }
            set { carga = value; }
        }

        public TIPOVEICULOELET Tipoveiculoelet
        {
            get { return tipoveiculoelet; }
            set { tipoveiculoelet = value; }
        }

        #endregion


        #region CONSTRUTORES

        /// <summary>
        /// Construtores da classe VeiculoEletrico
        /// Permitem criar um veiculo eletrico
        /// Um dos construtores recebe argumentos e o outro não recebe (Principio do Polimorfismo)
        /// </summary>

        public VeiculoEletrico()
        {
            Idstatic++;
            Id = Idstatic;
            Tipoveiculoelet = TIPOVEICULOELET.TrotineteElet;
            Estadoveiculo = ESTADOVEICULO.Disponivel;
            Autonomia = 200;
        }

        public VeiculoEletrico(TIPOVEICULOELET tipo, ESTADOVEICULO estado, double custo, int auton)
        {
            //Idstatic++;
            Id = Idstatic;
            Tipoveiculoelet = tipo;
            Estadoveiculo = estado;
            Autonomia = auton;
            Custo = custo;

        }

        #endregion

        #region Overrides

        /// <summary>
        /// Overrides da classe VeiculoEletrico
        /// Permitem mostrar as informacoes dos veiculos eletricos na consola
        /// </summary>

        public override string ToString()  //permite mostrar na consola as informacoes dos veiculos eletricos
        {
            string outStr = String.Format("Id: {0}\t Tipo de Veiculo: {1}\t Estado: {2}\t Custo: {3}\t Autonomia: {4}\n", Id, Tipoveiculoelet, Estadoveiculo, Custo, Autonomia);
            return outStr;
        }
        #endregion
    }
}
