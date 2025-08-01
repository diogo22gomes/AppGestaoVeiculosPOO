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
    public class DadosMecanico
    {
        /// <summary>
        /// Métodos da classe Mecanico
        /// </summary>

        static public void AlteraEstadoVeiculo(int idv, Mecanico m)   //permite alterar o estado de um veiculo dentro da bicibox
        {

            foreach (Veiculo item in DadosBicibox.Veiculosbiciin)
            {
                if (item.Id == idv)
                {
                    if (item.Estadoveiculo == ESTADOVEICULO.Avariado)
                    {
                        item.Estadoveiculo = ESTADOVEICULO.Disponivel;

                        Console.WriteLine("Estado do Veiculo Alterado com Sucesso!");
                    }

                }
            }

            m.Numerorepar++;
        }

        static public void MostraNumeroReparacoesMecanico(Mecanico m)   //mostra o numero de reparacoes efetuadas pelo mecanico
        {
            Console.WriteLine("\nO Numero de colocacoes feitas pelo Funcionario é: " + m.Numerorepar);
        }


    }
}
