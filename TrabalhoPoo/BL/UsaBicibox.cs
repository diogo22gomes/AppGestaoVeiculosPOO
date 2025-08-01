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
    public class UsaBicibox
    {
        /// <summary>
        /// Métodos da classe Bicibox na camada BL
        /// </summary>

        static public void AdicionaVeiculoBL(Veiculo a)   //adiciona veiculo na bicibox
        {
            DadosBicibox.AdicionaVeiculo(a);
        }

        static public void RemoveVeiculoBL(Veiculo a)     //remove veiculo da bicibox
        {
            DadosBicibox.RemoveVeiculo(a);
        }

        static public void ListaVeiculosDentroBL()    //lista todos os veiculos dentro da bicibox (independentemente do estado)
        {
            DadosBicibox.ListaVeiculosDentro();
        }

        static public void ListaVeiculosForaBL()    //lista todos os veiculos dentro da bicibox (independentemente do estado)
        {
            DadosBicibox.ListaVeiculosFora();
        }

        static public void HistoricoAlugueresBiciboxBL()    //lista o historico de alugueres da bicibox
        {
            DadosBicibox.HistoricoAlugueresBicibox();
        }

        static public void ListaAlugueresAtivosBL()    //lista os alugueres ativos 
        {
            DadosBicibox.ListaAlugueresAtivos();
        }

        static public void MostraVeiculosDisponiveisBL()    //mostra apenas os veiculos dentro que se encontram disponiveis
        {
            DadosBicibox.MostraVeiculosDisponiveis();
        }

        static public void EditarVeiculoBL(int idv, TIPOVEICULO tiponovo, ESTADOVEICULO estadonovo, double custonovo)       //permite editar um veiculo
        {
            DadosBicibox.EditarVeiculo(idv, tiponovo, estadonovo, custonovo);
        }  
    }
}
