using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dbDLLGenerico;

namespace dbDLLEspecifica
{
    public void InserirFuncionario(string Nome, string Endereco, string Celular, string Telefone, string Email)
    {
        DBBase db = new DBBase();
        string Query = "INSERT INTO tb01(Nome, Endereco, Celular, Telefone, Email)" +
        "VALUES" + "(" + Nome + "," + Endereco + "," + Celular + "," + Telefone + "," + Email + ")";
        db.ExecutaInstrucaoNaBase(Query);
    }

    public void ApagarFuncionario( int indice, string Nome, string CPF, string Endereco, string Telefone, string Cargo, string Sexo, string Login, string Senha, string Email, string Estado, DateTime Data_Cadastro)
    {
        DBBase db = new DBBase();
        string Query = "DELETE Funcionario where Id=" + indice.ToString();
        db.ExecutaInstrucaoNaBase(Query);
    }

    public void AtualizarTB01(int Id, string Nome, string Endereco, string Celular, string Telefone, string Email)
    {
        DBBase db = new DBBase();
        string Query = "UPDATE tb01 SET Nome='" + Nome + "' where Id=" + Id;
        db.ExecutaInstrucaoNaBase(Query);
    }
}