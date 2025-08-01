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
    public class UsaAlugueres
    {
        /// <summary>
        /// Métodos da classe Aluguer na camada BL
        /// </summary>


        static public void AluguerVeiculoBL(Veiculo v, Utilizador u, int t)   //metodo que cria um aluguer 
        {
            DadosAluguer.AluguerVeiculo(v, u, t);
        }


        static public void CancelarAluguerBL(int ida)  //metodo que cancela um aluguer
        {
            DadosAluguer.CancelarAluguer(ida);
        }

        static public void PararAluguerBL(int ida)     //metodo que para um aluguer
        {
            DadosAluguer.PararAluguer(ida);
        }
    }
}
