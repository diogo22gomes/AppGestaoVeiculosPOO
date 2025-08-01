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

using DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoPoo;

namespace BL
{
    [Serializable]
    public class UsaUtilizadores
    {

        /// <summary>
        /// Métodos da classe Utilizador na camada BL
        /// </summary>

        #region METODOS

        static public void ConsultaSaldoBL(Utilizador u)     //permite ao utilizador consultar o seu saldo
        {
            DL.DadosUtilizador.ConsultaSaldo(u);
        }

        static public void AdicionaSaldoBL(Utilizador u, int s)    //permite ao utilizador adcionar dinheiro ao seu saldo
        {
            DL.DadosUtilizador.AdicionaSaldo(u, s);
        }

        static public void HistoricoAlugueresUtilizadorBL(Utilizador u)     //Lista o historico de alugueres do utilizador 
        {
            DL.DadosUtilizador.HistoricoAlugueresUtilizador(u);
        }

        static public void MostraVeiculoUtilizadorBL(Utilizador u)      //Mostra qual o veiculo que o utilizador tem em posse
        {
            DL.DadosUtilizador.MostraVeiculoUtilizador(u);
        }


        static public void AlugaVeiculoBL(Veiculo v, Utilizador u, int tempoaluguer)   //permite ao utilizador alugar um veiculo
        {
            DL.DadosUtilizador.AlugaVeiculo(v, u, tempoaluguer);
        }

        static public void MostraVeiculosDisponiveisUserBL()    //mostra apenas os veiculos dentro que se encontram disponiveis
        {
            DadosBicibox.MostraVeiculosDisponiveis();
        }

        #endregion

    }
}
