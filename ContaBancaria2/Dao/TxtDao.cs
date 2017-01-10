using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ContaBancaria2.Dao
{
    class TxtDao
    {

        public string arquivoDados { get; set; }

        public TxtDao(string arquivoDados) {
            this.arquivoDados = arquivoDados;
        }

        /*
         * Lista todos os dados de um arquivo 
         * e retorna no formato de uma Lista de Dicionários
         * (Melhor alternativa para um array[chave, valor])
         */
        public List<Dictionary<string, string>> listar() {

            List<Dictionary<string, string>> listaFinal = new List<Dictionary<string, string>>();

            if (this.arquivoExiste(this.arquivoDados)) {

                Stream entrada = File.Open(this.arquivoDados, FileMode.Open);
                StreamReader leitor = new StreamReader(entrada);
                List<String> linhas = new List<String>();

                string linha = leitor.ReadLine();
                while (linha != null)
                {

                    linhas.Add(linha);
                    linha = leitor.ReadLine();

                }

                leitor.Close();
                entrada.Close();

                foreach (string l in linhas) {

                    listaFinal.Add(this.separarColunas(l));

                }

                return listaFinal;
                
            }
            else
            {
                throw new Exception("Arquivo de dados "+this.arquivoDados+" não encontrado.");
            }

        }

        public Boolean arquivoExiste(string nomeArquivo) {

            if (File.Exists(nomeArquivo))
                return true;

            return false;

        }

       /*
        * separa as colunas de dados em cada linha do arquivo
        * e retorna um dicionário com o campo e valor do mesmo
        */
        public Dictionary<string, string> separarColunas(String linha) {

            string[] partes = linha.Split(';');

            var dict = new Dictionary<string, string>();

            foreach (string parte in partes)
            {

                string[] colunas = parte.Split(':');

                //verifica se a chave da coluna existe
                if (!String.IsNullOrEmpty(colunas[0])) {

                    if (!String.IsNullOrEmpty(colunas[1]))
                        dict[colunas[0]] = colunas[1];
                    else
                        dict[colunas[0]] = "";

                }

            }

            return dict;

        }

        /*
         * Insere uma string no arquivo de texto informado
         */
        public Boolean inserir(String linha) {

            try
            {

                Stream saida;

                if (this.arquivoExiste(this.arquivoDados))
                {
                    saida = File.Open(this.arquivoDados, FileMode.Create);
                }
                else
                {
                    saida = File.Open(this.arquivoDados, FileMode.Append);
                }

                StreamWriter escritor = new StreamWriter(saida);

                escritor.Write(linha);

                escritor.Close();
                saida.Close();

                return true;

            }
            catch (Exception e)
            {
                throw new Exception("Erro ao gravar texto em arquivo " + e.Message);
            }

        }

    }
}
