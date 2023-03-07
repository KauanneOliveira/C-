string aulaIntro = "Introdução às Coleções";

string aulaModelando = "Modelando a Classe Aula";

string aulaSets = "Trabalhando com Conjuntos";

string[] aulas = new string[3];

aulas[0] = aulaIntro;

aulas[1] = aulaModelando;

aulas[2] = aulaSets;

for (int i=0; i<aulas.Length; i++){
    Console.WriteLine(aulas[i]);
}

Console.WriteLine("Aula Modelando está no índice " +Array.IndexOf(aulas, aulaModelando));
 
Console.WriteLine("Aula Modelando está no índice " +Array.LastIndexOf(aulas, aulaModelando)); 

 

