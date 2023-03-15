 var peixes = new List<string>();
 peixes.Add("Bagre Ensaboado");  //Add adiociona item
 peixes.Add("Tilápia");
 peixes.Add("Camarão");
 peixes.Add("Sardinha");

 foreach(var peixe in peixes){  // diferentemente do while ou for, o foreach não precisa definir uma condição de parada. Isso é definido de forma implícita, pelo tamanho da coleção
     Console.WriteLine(peixe);
 }


var peixinhos = new List<string> {"Bagre Ensaboado2", "Tilápia2", "Camarão2", "Sardinha2"};

 for(var i = 0; i < peixinhos.Count; i++) {
     Console.Write(peixinhos[i] + " ");
 }

peixinhos.Remove("Tilápia2");  //Remove o conteúdo da variável

foreach( var peixinho in peixinhos ){
    Console.WriteLine(peixinho);
}

var numeros = new List<int> {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

for(var i = numeros.Count - 1; i >= 0; i--){
    if(numeros[i] % 2 == 1) {
        numeros.RemoveAt(i);  //Remove de um determinado índice 
    }
}

numeros.ForEach( numero => Console.Write(numero + " ") );
