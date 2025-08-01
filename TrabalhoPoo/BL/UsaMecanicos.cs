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
    public class UsaMecanicos
    {
        /// <summary>
        /// Métodos da classe Mecanico na camada BL
        /// </summary>

        static public void AlteraEstadoVeiculoBL(int idv, Mecanico m)     //permite alterar o estado de um veiculo dentro da bicibox
        {
            DadosMecanico.AlteraEstadoVeiculo(idv, m);
        }


        static public void MostraNumeroReparacoesMecanicoBL(Mecanico m)   //mostra o numero de reparacoes efetuadas pelo mecanico
        {
            DadosMecanico.MostraNumeroReparacoesMecanico(m);
        }
    }
}
