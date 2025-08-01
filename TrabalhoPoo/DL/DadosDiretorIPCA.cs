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
using TrabalhoPoo;

namespace DL
{

    [Serializable]
    public class DadosDiretorIPCA
    {

        #region METODOS

        /// <summary>
        /// Métodos da classe DiretorIPCA 
        /// </summary>

        public static void GetAll()   //Mostra as listas de veiculos dentro da bicibox, fora, alugueres ativos e historico de alugueres da bicibox
        {
            DadosBicibox.ListaVeiculosDentro();
            Console.WriteLine();
            DadosBicibox.ListaVeiculosFora();
            Console.WriteLine();
            DadosBicibox.ListaAlugueresAtivos();
            Console.WriteLine();
            DadosBicibox.HistoricoAlugueresBicibox();
            Console.WriteLine();
        }


        public static void AlteraNome(string novo)   //permite alterar o nome do DiretorIPCA
        {
            DiretorIPCA.Nome = novo;

            Console.WriteLine("Nome do Diretor Alterado com Sucesso!");
        }

        #endregion

    }
}
