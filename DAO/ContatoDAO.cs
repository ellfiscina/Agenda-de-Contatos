using AgendadeContatos.Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendadeContatos.DAO
{
    class ContatoDAO
    {
        public void Inserir(Contato contato)
        {
            try
            {
                string sql = "insert into contatos" +
                             "(Nome, Endereco, Bairro, Codigo_Cidade, Telefone, Celular, Email, Sexo, Data_Nasc, Observacao) values" +
                             "('" + contato.Nome + "','" + contato.Endereco + "','" + contato.Bairro + "'," + contato.Cidade + ",'" +
                             contato.Telefone + "','" + contato.Celular + "','" + contato.Email + "','" + contato.Sexo + "','" + contato.Data_nasc.ToString("yyyy-MM-dd HH:mm") +
                             "','" + contato.Obs + "')";
                Conexao.ExecutaComando(sql);
            }
            catch(MySqlException ex)
            {
                throw ex;
            }
        }

        public void Alterar(Contato contato)
        {
            try
            {
                string sql = "update contatos set Nome='" + contato.Nome + "',Endereco='" + contato.Endereco + "',Bairro='" + contato.Bairro +
                             "', Codigo_Cidade=" + contato.Cidade + ",Telefone='" + contato.Telefone + "',Celular='" + contato.Celular + "',Email='" +
                             contato.Email + "',Sexo='" + contato.Sexo + "',Data_Nasc='" + contato.Data_nasc + "',Observacao='" + contato.Obs +
                             "' where codigo_contato = " + contato.Codigo;
                Conexao.ExecutaComando(sql);
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }

        public void Excluir(Contato contato)
        {
            try
            {
                string sql = "delete from contatos where Codigo_Contato = " + contato.Codigo;
                Conexao.ExecutaComando(sql);
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }

        public DataTable PreencheComboCidade()
        {
            try
            {
                string sql = "select * from cidade order by nome";
                return Conexao.ExecutaComando(sql);
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }
    }
}
