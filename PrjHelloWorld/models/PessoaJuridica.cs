using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjHelloWorld.Models
{
    public class PessoaJuridica : Pessoa
    {
        private string _Cnpj;
        public string Cnpj
        {
            get { return _Cnpj; }
            set
            {
                if (value.Length != 14)
                {
                    throw new Exception("CNPJ Inválido!");

                }
                _Cnpj = value;
            }
        }
        public PessoaJuridica(string pNome, int pIdade, string pjCnpj) : base(pNome, pIdade)
        {

            Cnpj = pjCnpj;
        }
    }
}
