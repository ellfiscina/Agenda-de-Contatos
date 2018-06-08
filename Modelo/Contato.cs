using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendadeContatos.Modelo
{
    class Contato
    {
        private int codigo;
        private string nome;
        private string endereco;
        private string bairro;
        private int cod_cidade;
        private string telefone;
        private string celular;
        private string email;
        private char sexo;
        private DateTime data_nasc;
        private string obs;
        
        # region Métodos
        public int Codigo
        {
            get
            { 
                return codigo;
            }
            set
            {
                codigo = value;
            }
        }
        
        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }

        public string Endereco
        {
            get
            {
                return endereco;
            }
            set
            {
                endereco = value;
            }
        }
        
        public string Bairro
        {
            get
            {
                return bairro;
            }
            set
            {
                bairro = value;
            }
        }

        public int Cidade
        {
            get
            {
                return cod_cidade;
            }
            set
            {
                cod_cidade = value;
            }
        }

        public string Telefone
        {
            get
            {
                return telefone;
            }
            set
            {
                telefone = value;
            }
        }

        public string Celular
        {
            get
            {
                return celular;
            }
            set
            {
                celular = value;
            }
        }
        
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        public char Sexo
        {
            get
            {
                return sexo;
            }
            set
            {
                sexo = value;
            }
        }

        public DateTime Data_nasc
        {
            get
            {
                return data_nasc;
            }
            set
            {
                data_nasc = value;
            }
        }

        public string Obs
        {
            get
            {
                return obs;
            }
            set
            {
                obs = value;
            }
        }
        #endregion

    }
}
