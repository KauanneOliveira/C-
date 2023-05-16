using Microsoft.Data.Sqlite;
using Aula09DB.Database; 
using Aula09DB.Repositories; 
using Aula09DB.Models; 

var databaseConfig = new DatabaseConfig();
var databaseSetup = new DatabaseSetup(databaseConfig);
var computerRepository = new ComputerRepository(databaseConfig); //nome do repósitorio

var modelName = args[0];   //pegando os parâmetros do main
var modelAction = args[1]; //pegando os parâmetros do main

if(modelName == "Computer")
{
    //list - tá listando o banco inteiro
    if(modelAction == "List")
    {
        //vai apresentar todos os registros do banco de dados
        
        Console.WriteLine("Computer List"); 
        foreach (var computer in computerRepository.GetAll()) //ta criando a variável computer que irá pegar tudo pelo computerRepository.GetAll
        {
            //vai listar essas três informações: id, memória ram e processador da máquina
            Console.WriteLine($"{computer.Id}, {computer.Ram}, {computer.Processor}"); 
        }
    } 


    //new - criando um registro
    if(modelAction == "New")
    {
        //vai pegar os argumento 3, 4 e 5  e salvar, respectivamente, nas variáveis id, ram e processador
        
        Console.WriteLine("Computer New");
        
        var id = Convert.ToInt32(args[2]); //convertendo para inteiro o ID, pois ele é numérico
        string ram = args[3];
        string processor = args[4];

        var computer = new Computer(id, ram, processor);
        computerRepository.Save(computer); //tá salvando no repositório os dados passado
    }

    //show - vai apresentar uma linha determinada do banco
    if(modelAction == "Show")
    {
        //vai passar por parâmetro o id e se existir ele vai exibir o registro

        Console.WriteLine("Computer Show");
        var id = Convert.ToInt32(args[2]);

        //ExitsById - vai verificar se existe o registro(método criado)
        if(computerRepository.ExitsById(id))
        {
            //vai apresentar esses dados se existir
            var computer = computerRepository.GetById(id);
            Console.WriteLine($"{computer.Id}, {computer.Ram}, {computer.Processor}");
        }
        else
        {
            Console.WriteLine($"O computador com Id {id} não existe.");
        }
    }

    //update - vai atualizar algum registro
    if(modelAction == "Update")
    {
        //tá pegando o id e convertendo 
        Console.WriteLine("Computer Update");
        var id = Convert.ToInt32(args[2]);

        //verificando se existe
        if(computerRepository.ExitsById(id))
        {
            string ram = args[3];
            string processor = args[4];
            var computer = new Computer(id, ram, processor);

            //caso exista está atualizando na linha de baixo
            computerRepository.Update(computer);
        }
        else
        {
            Console.WriteLine($"O computador com Id {id} não existe."); 
        } 
    }         
    
    //delete -  vai deletar um registro 
    if(modelAction == "Delete")
    {
        //tá pegando o id e convertendo
        Console.WriteLine("Computer Delete");
        var id = Convert.ToInt32(args[2]);

        //verificando se existe
        if(computerRepository.ExitsById(id))
        {
            //caso exista está deletando na linha de baixo
            computerRepository.Delete(id);
        }
        else
        {
            Console.WriteLine($"O computador com Id {id} não existe.");
        }
    }
}