string aulaIntro = "Introdução às Coleções";

string aulaModelando = "Modelando a Classe Aula";

string aulaSets = "Trabalhando com Conjuntos";

string[] aulas = new string[3];

aulas[0] = aulaIntro;

aulas[1] = aulaModelando;

aulas[2] = aulaSets;

foreach (var aula in aulas){
    Console.WriteLine(aula);
}