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
    public static class DadosBicibox
    {

        #region LISTAS

        /// <summary>
        /// Listas da classe Bicibox
        /// </summary>

        static List<Veiculo> veiculosbiciin = new List<Veiculo>();    //lista que contem veiculos dentro da bicibox

        static List<Veiculo> veiculosbiciout = new List<Veiculo>();   //lista que contem veiculos fora da bicibox (alugados ou abandonados)

        static List<Aluguer> historicobici = new List<Aluguer>();     //historico de alugueres da bicibox

        static List<Aluguer> alugueresativos = new List<Aluguer>();   //lista de alugueres ativos 

        #endregion


        #region PROPRIEDADES

        /// <summary>
        /// Propriedades das listas da classe Bicibox
        /// </summary>

        static public List<Aluguer> Historicobici
        {
            get { return historicobici; }
            set { historicobici = value; }
        }

        static public List<Aluguer> Alugueresativos
        {
            get { return alugueresativos; }
            set { alugueresativos = value; }
        }

        static public List<Veiculo> Veiculosbiciin
        {
            get { return veiculosbiciin; }
            set { veiculosbiciin = value; }
        }

        static public List<Veiculo> Veiculosbiciout
        {
            get { return veiculosbiciout; }
            set { veiculosbiciout = value; }
        }

        #endregion



        #region METODOS

        /// <summary>
        /// Métodos da classe Bicibox
        /// </summary>

        static public void AdicionaVeiculo(Veiculo a)   //adiciona veiculo na bicibox
        {
            if (veiculosbiciin.Contains(a))
            {
                Console.WriteLine("\nVeiculo " + a.Id + " já está na Bicibox\n");
            }
            else
            {
                veiculosbiciin.Add(a);
                Bicibox.Totveiculos++;

                if (veiculosbiciout.Contains(a))
                {
                    veiculosbiciout.Remove(a);
                    Bicibox.Totveiculosout--;
                }
                else { }
               
            }

        }

        static public void RemoveVeiculo(Veiculo a)     //remove veiculo da bicibox
        {
            if (veiculosbiciin.Contains(a))
            {
                veiculosbiciin.Remove(a);
                Bicibox.Totveiculos--;
                veiculosbiciout.Add(a);
                Bicibox.Totveiculosout++;

                
            }
            else
            {
                if (veiculosbiciout.Contains(a))
                {
                    Console.WriteLine("\nVeiculo " + a.Id + " não está na Bicibox\n");
                }
                else
                {
                    veiculosbiciout.Add(a);
                    Bicibox.Totveiculosout++;
                }

            }
        }

        static public void ListaVeiculosDentro()    //lista todos os veiculos dentro da bicibox (independentemente do estado)
        {
            Console.WriteLine("\nTODOS OS VEICULOS DENTRO DA BICIBOX: \n");

            foreach (Veiculo item in veiculosbiciin)
            {
                Console.WriteLine(item);

            }

            Console.WriteLine("\nNumero de Veiculos dentro da Bicibox: \n" + Bicibox.Totveiculos);
        }

        static public void ListaVeiculosFora()    //lista todos os veiculosfora da bicibox (independentemente do estado)
        {
            Console.WriteLine("\nTODOS OS VEICULOS FORA DA BICIBOX: \n");

            foreach (Veiculo item in veiculosbiciout)
            {
                Console.WriteLine(item);

            }

            Console.WriteLine("\nNumero de Veiculos fora da Bicibox: \n" + Bicibox.Totveiculosout);
        }

        static public void HistoricoAlugueresBicibox()    //lista o historico de alugueres da bicibox
        {
            Console.WriteLine("\nHISTORICO DE ALUGUERES DA BICIBOX");

            foreach (Aluguer item in historicobici)
            {
                Console.WriteLine(item);

            }
        }

        static public void ListaAlugueresAtivos()    //lista os alugueres ativos 
        {
            Console.WriteLine("\nLISTA DE ALUGUERES ATIVOS DA BICIBOX");

            foreach (Aluguer item in alugueresativos)
            {
                Console.WriteLine(item);

            }
        }

        static public void MostraVeiculosDisponiveis()    //mostra apenas os veiculos dentro que se encontram disponiveis
        {
            Console.WriteLine("\nLISTA DE VEICULOS DISPONIVEIS NA BICIBOX\n");

            foreach (Veiculo item in Veiculosbiciin)
            {
                if (item.Estadoveiculo == ESTADOVEICULO.Disponivel)
                {
                    Console.WriteLine(item);
                }
            }


        }

        static public void EditarVeiculo(int idv, TIPOVEICULO tiponovo, ESTADOVEICULO estadonovo, double custonovo)  //permite editar um veiculo
        {
            foreach (Veiculo item1 in Veiculosbiciin)
            {
                if (item1.Id == idv)
                {
                    item1.Tipoveiculo = tiponovo;
                    item1.Estadoveiculo = estadonovo;
                    item1.Custo = custonovo;

                    Console.WriteLine("Veiculo Editado com Sucesso!");
                }
                else
                {
                    foreach (Veiculo item2 in Veiculosbiciout)
                    {
                        if (item2.Id == idv)
                        {
                            item2.Tipoveiculo = tiponovo;
                            item2.Estadoveiculo = estadonovo;
                            item2.Custo = custonovo;

                            Console.WriteLine("Veiculo Editado com Sucesso!");
                        }
                    }
                }
                
            }



        }


        #endregion
    }
}
