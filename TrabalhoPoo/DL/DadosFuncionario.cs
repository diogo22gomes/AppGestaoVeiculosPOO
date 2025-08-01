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
    public class DadosFuncionario
    {
        /// <summary>
        /// Métodos da classe Funcionario
        /// </summary>

        static public void ColocaBicibox(Veiculo v, Funcionario f)  //coloca veiculo dentro da bicibox
        {
            DadosBicibox.AdicionaVeiculo(v);

            f.Numerocol++;

            Console.WriteLine("Veiculo Colocado com Sucesso!");
        }

        static public void MostraNumeroColocacoesFuncionario(Funcionario f)   //mostra o numero de colocacoes efetuadas pelo funcionario
        {
            Console.WriteLine("\nO Numero de colocacoes feitas pelo Funcionario é: " + f.Numerocol);
        }

    }
}
