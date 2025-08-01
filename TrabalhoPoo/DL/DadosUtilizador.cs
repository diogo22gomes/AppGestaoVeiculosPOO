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
using System.Xml.Linq;
using TrabalhoPoo;

namespace DL
{
    [Serializable]
    public class DadosUtilizador
    {

        #region LISTAS

        /// <summary>
        /// Listas da classe Utilizador 
        /// </summary>

        static List<Utilizador> listautilizadores = new List<Utilizador>();   // Lista de Utilizadores

        #endregion



        #region METODOS

        /// <summary>
        /// Métodos da classe Utilizador
        /// </summary>

        static public void ConsultaSaldo(Utilizador u)   //permite ao utilizador consultar o seu saldo
        {
            Console.WriteLine("\nO saldo de " + u.Nome + " é: " + u.Saldo + " Euros\n");
        }

        static public void AdicionaSaldo(Utilizador u, int s)    //permite ao utilizador adcionar dinheiro ao seu saldo
        {
            u.Saldo = u.Saldo + s;

            Console.WriteLine("\nForam Adicionados " + s + " euros à conta de " + u.Nome);

            Console.WriteLine("\nO saldo de " + u.Nome + " é: " + u.Saldo + " Euros\n");
        }

        static public void HistoricoAlugueresUtilizador(Utilizador u)   //Lista o historico de alugueres do utilizador 
        {
            Console.WriteLine("\nHISTORICO DE ALUGUERES DO UTILIZADOR:");

            foreach (Aluguer item in DadosBicibox.Historicobici)
            {
                if (item.User == u)
                {
                    Console.WriteLine(item);
                }
            }
        }

        static public void MostraVeiculoUtilizador(Utilizador u)   //Mostra qual o veiculo que o utilizador tem em posse
        {
            Console.WriteLine("\nVEIUCLO DO UTILIZADOR:");

            foreach (Aluguer item in DadosBicibox.Alugueresativos)
            {
                if (item.User == u)
                {
                    Console.WriteLine("\nO Utilizador: \n" + u + "\n Tem em posse o veiculo: \n" +  item.Vehicle);
                }
  
            }

        }


        static public void AlugaVeiculo(Veiculo v, Utilizador u, int tempo)   //permite ao utilizador alugar um veiculo
        {
            DadosAluguer.AluguerVeiculo(v, u, tempo);
        }

        #endregion

    }
}
