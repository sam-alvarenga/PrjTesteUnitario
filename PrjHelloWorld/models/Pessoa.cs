using System;

using System.Collections.Generic;

using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

using System.Threading.Tasks;
using System.Xml.Schema;

namespace PrjHelloWorld.Models

{

    public class Pessoa

    {

        public string _nome;

        public string Nome
        {
            get
            {
                return this._nome.ToUpper();
            }
            set
            {
                if (value == String.Empty || value.Length < 2)
                {
                    //lançar exception
                    throw new Exception("Erro: nome nulo ou inválido!");
                };
                this._nome = value.Trim().ToUpper();  
                //Trim() --- elimina espaços desnecessarios na hora de salvar um dado no banco.
                //EXEMPLO: "    Carlos   " é convertida para "Carlos" na hora que é guardada no banco

               //ToUpper() --- salva os dados em caixa alta para deixar os dados padronizados.
            }
        }

        //getter setter padrão
        public int _idade; //atributo

        public int Idade { //property ou getter setter
        get
        {
            return this._idade;
        }
        set 
        {
            if (value <= 0 || value >= 135)
            {
                throw new Exception("Erro: Idade inválida");
            }
            this._idade = value; 
        }

    }   // esse bloco equivale a public int Idade { get; set;}

        public Pessoa() { }

        public Pessoa(string pNome, int pIdade)

        {

            this.Nome = pNome;

            this.Idade = pIdade;

        }

        //modificador | tipo de retorno | nome do método(tipos e parametros)

        public bool verificarMaioridade()

        {

            if (this.Idade < 18)

            {

                return false;

            }

            return true;

        }

        public string exibirMensagemMaioridade()

        {

            //if ternario 

            //     condição ? caminho verdadeiro : caminho falso

            //int x = y >10 ? 5 : 9;

            return this.verificarMaioridade() ? $"{this.Nome} é maior de idade." : $"{this.Nome} é menor de idade.";

            //if (this.verificarMaioridade())

            //{

            //    return "Você é maior de idade.";

            //}

            //else 

            //{

            //    return "Você é menor de idade.";

            //}

        }

        public string exibirDadosPessoa()

        {

            return $"################################" +

                   $"\n O nome da pessoa é {this.Nome} " +

                   $"e a idade é {this.getIdadeFormatada}  \n" +

                   $"{this.exibirMensagemMaioridade()} \n" +

                   $"################################";

        }

        //metodo sem retorno

        //public void fazerAlgo()

        //{

        //}
        public string getIdadeFormatada()
        {
            return $"{this.Idade.ToString()} anos.";
        }
    }

}
