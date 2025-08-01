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
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    [Serializable]
    public class UsaDiretorIPCA
    {
        /// <summary>
        /// Métodos da classe DiretorIPCA na camada BL
        /// </summary>

        static public void GetAllBL()     //Mostra as listas de veiculos dentro da bicibox, fora, alugueres ativos e historico de alugueres da bicibox
        {
            DadosDiretorIPCA.GetAll();
        }

        public static void AlteraNomeBL(string novo)     //permite alterar o nome do DiretorIPCA
        {
            DadosDiretorIPCA.AlteraNome(novo);
        }

        public bool SavetoFileBL(string fileName)     //Salva informacçao em Ficheiro
        {
            try
            {
                Stream stream = File.Open(fileName, FileMode.OpenOrCreate);
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, DadosBicibox.Historicobici);
                stream.Close();
                return true;
            }
            catch (IOException e)
            {
                throw e;
            }
        }

    }
}
