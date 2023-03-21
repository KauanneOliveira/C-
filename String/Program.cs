var nomes = new List<string>{"Kauanne", "Jorge", "Henrique", "Chloe"};

foreach(var nome in nomes){
    Console.WriteLine($"Olá { nome.ToUpper() }.");
}



Console.WriteLine();
nomes.Add("Julia");
nomes.Add("Maggie");
nomes.Remove("Henrique");

foreach( var nome in nomes){
    Console.WriteLine($"Olá { nome.ToUpper() }.");  // saída: Olá KAUANNE. ... // não mostra o Henrique
}



Console.WriteLine();
Console.WriteLine($"Meu nome é {nomes[0]}"); //Meu nome é Kauanne
Console.WriteLine($"Adicionei é {nomes[3]} e {nomes[4]} na lista"); //Adicionei é Julia e Maggie na lista // com a remoção do Henrique Julia e Maggie pegaram esses índices
Console.WriteLine($"A lista tem {nomes.Count} pessoas"); //A lista tem 6 pessoas



var index = nomes.IndexOf("Felipe");             //o método IndexOf procura um item e retorna o índice do item

if(index == -1){                                // -1 quer dizer que não achou na lista, que não tem esse item na lista 
    
    Console.WriteLine($"Item não encontrado {index}");  //Item não encontrado -1

}else {

    Console.WriteLine($"O nome {nomes[index]} está no índice {index}"); //O nome Julia está no índice 3

}

nomes.Sort();    //Sort classifica ascedente(crescente para string) os intens da lista
foreach( var nome in nomes){
    Console.WriteLine($"Olá { nome.ToUpper() }!"); 
}