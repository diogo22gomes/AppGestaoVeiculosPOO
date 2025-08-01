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
    public class DadosAluguer
    {

        #region METODOS

        /// <summary>
        /// Métodos da classe Aluguer
        /// </summary>

        static public void AluguerVeiculo(Veiculo v, Utilizador u, int tempo)   //metodo que cria um aluguer 
        {
            if (v.Estadoveiculo == ESTADOVEICULO.Disponivel)
            {
                if (u.Saldo > 0)
                {
                    Aluguer a = new Aluguer();

                    a.Tempoalug = tempo;

                    a.Custoalug = v.Custo * a.Tempoalug;

                    u.Saldo = u.Saldo - a.Custoalug;

                    a.Datainicio = DateTime.Now;
                    a.Datafim = DateTime.Now.AddMinutes(tempo);

                    a.Vehicle = v;
                    a.User = u;

                    DadosBicibox.Historicobici.Add(a);

                    DadosBicibox.Alugueresativos.Add(a);

                    u.Veiculouser = v;

                    DadosBicibox.RemoveVeiculo(v);

                    v.Estadoveiculo = ESTADOVEICULO.Ocupado;
                    Console.WriteLine("\nAluguer Efetuado com Sucesso!");

                }
                else
                {
                    Console.WriteLine("\nFalha no Aluguer! Utilizador não tem saldo Suficiente!");
                }
            }
            else
            {
                Console.WriteLine("\nFalha no Aluguer! Veiculo não se encontra Disponivel!");
            }

        }
        

        static public void CancelarAluguer(int ida)  //metodo que cancela um aluguer
        {

            for (int i = 0; i<DadosBicibox.Alugueresativos.Count; i++)
            {
                if (DadosBicibox.Alugueresativos[i].Id == ida)
                {
                    DadosBicibox.Alugueresativos.Remove(DadosBicibox.Alugueresativos[i]);

                    DadosBicibox.Alugueresativos[i].User.Veiculouser = null;


                    DadosBicibox.AdicionaVeiculo(DadosBicibox.Alugueresativos[i].Vehicle);

                    DadosBicibox.Alugueresativos[i].Vehicle.Estadoveiculo = ESTADOVEICULO.Disponivel;

                    Console.WriteLine("Aluguer Cancelado com Sucesso!");
                }
}
        }

        static public void PararAluguer(int ida)    //metodo que para um aluguer
        {
            for (int i = 0; i < DadosBicibox.Alugueresativos.Count; i++)
            {
                if (DadosBicibox.Alugueresativos[i].Id == ida)
                {
                    if (DadosBicibox.Alugueresativos[i].Datafim == DateTime.Now)
                    {
                        CancelarAluguer(ida);
                    }
                    Console.WriteLine("Aluguer Parado com Sucesso!");
                }
            }
        }

        #endregion

    }
}
