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
    public class UsaFuncionarios
    {
        /// <summary>
        /// Métodos da classe Funcionario na camada BL
        /// </summary>

        static public void ColocaBiciboxBL(Veiculo v, Funcionario f)     //coloca veiculo dentro da bicibox
        {
            DadosFuncionario.ColocaBicibox(v, f);
        }


        static public void MostraNumeroColocacoesFuncionarioBL(Funcionario f)   //mostra o numero de colocacoes efetuadas pelo funcionario
        {
            DadosFuncionario.MostraNumeroColocacoesFuncionario(f);
        }

    }
}
