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
using TrabalhoPoo;

namespace USATUDO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Veiculo veiculo1 = new Veiculo(TIPOVEICULO.Bicicleta, ESTADOVEICULO.Disponivel, 0.1);
            Veiculo veiculo2 = new VeiculoEletrico(TIPOVEICULOELET.TrotineteElet, ESTADOVEICULO.Disponivel, 0.2, 30);
            Veiculo veiculo3 = new VeiculoEletrico(TIPOVEICULOELET.BicicletaElet, ESTADOVEICULO.Disponivel, 0.4, 50);
            Veiculo veiculo4 = new Veiculo(TIPOVEICULO.Bicicleta, ESTADOVEICULO.Disponivel, 0.1);
            Veiculo veiculo5 = new Veiculo(TIPOVEICULO.Bicicleta, ESTADOVEICULO.Avariado, 0.1);

            BL.UsaBicibox.AdicionaVeiculoBL(veiculo1);
            BL.UsaBicibox.AdicionaVeiculoBL(veiculo2);
            BL.UsaBicibox.AdicionaVeiculoBL(veiculo3);
            BL.UsaBicibox.AdicionaVeiculoBL(veiculo4);
            BL.UsaBicibox.AdicionaVeiculoBL(veiculo5);

            BL.UsaBicibox.ListaVeiculosDentroBL();

            Console.WriteLine("-----------------------");

            Utilizador user1 = new Utilizador("Roger Schmidt", 200);
            Utilizador user2 = new Utilizador("João Félix", 500);

            BL.UsaUtilizadores.AlugaVeiculoBL(veiculo1, user1, 30);
            //BL.UsaBicibox.ListaVeiculosForaBL();
            BL.UsaUtilizadores.AlugaVeiculoBL(veiculo2, user2, 20);

            BL.UsaBicibox.MostraVeiculosDisponiveisBL();

            Console.WriteLine("-----------------------");

            BL.UsaUtilizadores.MostraVeiculoUtilizadorBL(user1);
            BL.UsaUtilizadores.MostraVeiculoUtilizadorBL(user2);

            Console.WriteLine("-----------------------");

            BL.UsaBicibox.ListaAlugueresAtivosBL();

            BL.UsaAlugueres.CancelarAluguerBL(1);

            BL.UsaBicibox.ListaAlugueresAtivosBL();

            Console.WriteLine("-----------------------");

            BL.UsaBicibox.HistoricoAlugueresBiciboxBL();

            BL.UsaBicibox.ListaVeiculosDentroBL();
            BL.UsaBicibox.ListaVeiculosForaBL();

            BL.UsaUtilizadores.MostraVeiculoUtilizadorBL(user1);

            Console.WriteLine("-----------------------");

            Utilizador user3 = new Utilizador("António Silva", 0);

            BL.UsaUtilizadores.AlugaVeiculoBL(veiculo3, user3, 20);

            BL.UsaUtilizadores.AlugaVeiculoBL(veiculo3, user3, 20);


            Console.ReadKey();
        }
    }
}
