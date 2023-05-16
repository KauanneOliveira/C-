using Aula09DB.Database;
using Aula09DB.Models;
using Microsoft.Data.Sqlite;

namespace Aula09DB.Repositories;

class ComputerRepository
{
    private readonly DatabaseConfig _databaseConfig;
    public ComputerRepository(DatabaseConfig databaseConfig)
    {
        _databaseConfig = databaseConfig;
    }

    //criando uma lista onde vai ler todos os registros do banco
    public List<Computer> GetAll()
    {
        var computers = new List<Computer>();
        var connection = new SqliteConnection(_databaseConfig.ConnectionString);
        //tá abrindo o banco
        connection.Open();
        var command = connection.CreateCommand();
        //comando que tá pegando todos os atributos
        command.CommandText = "SELECT * FROM Computers";
        var reader = command.ExecuteReader();
        //para ler uma linha do banco ta usando o metodo Read()
        while(reader.Read())
        {
            //reader.GetString e readerGetInt é para conseguir ler os dados no banco de dados
            var id = reader.GetInt32(0);
            var ram = reader.GetString(1);
            var processor = reader.GetString(2);
            var computer = ReaderToComputer(reader);
            computers.Add(computer); 
        }
        //tá fechando o banco
        connection.Close();
        return computers; //returna as informações da classe
    }

    public Computer Save(Computer computer)
    {
        var connection = new SqliteConnection(_databaseConfig.ConnectionString);
        connection.Open();
        var command = connection.CreateCommand();
        command.CommandText = "INSERT INTO Computers VALUES($id, $ram, $processor)";
        //adicionando informações no banco, usa o AddWithValue
        command.Parameters.AddWithValue("$id", computer.Id);
        command.Parameters.AddWithValue("$ram", computer.Ram);
        command.Parameters.AddWithValue("$processor", computer.Processor);
        command.ExecuteNonQuery();
        connection.Close();
        return computer;
    }

    public Computer GetById(int id)
    {
        var connection = new SqliteConnection(_databaseConfig.ConnectionString);
        connection.Open();
        var command = connection.CreateCommand();
        command.CommandText = "SELECT * FROM Computers WHERE (id = $id)";
        command.Parameters.AddWithValue("$id", id);
        var reader = command.ExecuteReader();
        reader.Read();
        var computer = ReaderToComputer(reader);
        connection.Close();
        return computer;
    } 

    public Computer Update(Computer computer)
    {
        var connection = new SqliteConnection(_databaseConfig.ConnectionString);
        connection.Open();
        var command = connection.CreateCommand();
        command.CommandText = "INSERT INTO Computers VALUES ($id, $ram, $processor)";
        command.CommandText = "UPDATE Computers SET ram = $ram, processor = $processor WHERE (id = $id)";
        command.Parameters.AddWithValue("$id", computer.Id);
        command.Parameters.AddWithValue("$ram", computer.Ram);
        command.Parameters.AddWithValue("$processor", computer.Processor);
        command.ExecuteNonQuery();
        connection.Close();
        return computer; 
    }

    public void Delete(int id)
    {
        var connection = new SqliteConnection(_databaseConfig.ConnectionString);
        connection.Open();
        var command = connection.CreateCommand();
        command.CommandText = "DELETE FROM Computers WHERE (id = $id)";
        command.Parameters.AddWithValue("$id", id);
        command.ExecuteNonQuery();
        connection.Close();
    }

    public bool ExitsById(int id)
    {
        var connection = new SqliteConnection(_databaseConfig.ConnectionString);
        connection.Open();
        var command = connection.CreateCommand();
        command.CommandText = "SELECT count(id) FROM Computers WHERE(id = $id)";
        command.Parameters.AddWithValue("$id", id);
        var reader = command.ExecuteReader();
        reader.Read();
        var result = reader.GetBoolean(0);
        return result;
    }

    private Computer ReaderToComputer(SqliteDataReader reader)
    {
        var computer = new Computer(reader.GetInt32(0),
        reader.GetString(1), reader.GetString(2));
        return computer;
    }
}