using Microsoft.Data.Sqlite;
namespace Aula09DB.Database; 

class DatabaseSetup
{
    //é uma variável de conexão, para poder criar uma tabela
    private readonly DatabaseConfig _databaseConfig;

    //vai receber a informação do bdd
    public DatabaseSetup(DatabaseConfig databaseConfig)
    {
        _databaseConfig = databaseConfig;
        CreateComputerTable();
    }

    //método para criar uma tabela
    private void CreateComputerTable()
    {
        //tá criando uma variável conexão onde ta pegando a várial _databaseConfig pelo método SqliteConnection, da qual é atribuida a string de conexão da DatabaseConfig para fazer a conexão com o banco do SQLite
        var connection = new SqliteConnection(_databaseConfig.ConnectionString);

        //.Open está abrindo o banco para criar uma tabela (nome da tabela é Computers) lá dentro
        connection.Open();
        //.CreateCommand - método para criar um comando no banco 
        var command = connection.CreateCommand();
        command.CommandText = @"
        CREATE TABLE IF NOT EXISTS Computers(
        id int not null primary key,
        ram varchar(100) not null,
        processor varchar(100) not null
        );
        "; 

        command.ExecuteNonQuery(); //ExecuteNonQuery - comando para ocorrer a execução no bdd
        connection.Close(); //.Close está fechando o banco
    }
}
