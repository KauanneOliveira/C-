using Controles;

var gastos = new Gastos("Kauanne Oliveira", 0m);

var alimentacao = new Alimentacao("Alimentação", 0);
alimentacao.AtualizarValor(20, DateTime.Now, "Café");
alimentacao.AtualizarValor(50, DateTime.Now, "Compra de Mantimentos");
alimentacao.ExecutarMargemdeSeguranca();
Console.WriteLine(alimentacao.EmitirRelatorio());

var vestuario = new Vestuario("Vestuário", 0);
vestuario.AtualizarValor(100, DateTime.Now, "Agasalho");
vestuario.AtualizarValor(50, DateTime.Now, "Calça");
vestuario.AtualizarValor(250, DateTime.Now, "Terno");
vestuario.ExecutarMargemdeSeguranca();
Console.WriteLine(vestuario.EmitirRelatorio());

var lazer = new Lazer("Lazer", 0, -50);
lazer.AtualizarValor(200, DateTime.Now, "Cinema");
lazer.ExecutarMargemdeSeguranca();
Console.WriteLine(lazer.EmitirRelatorio());

var educacao = new Educacao("Educação", 0);
educacao.AtualizarValor(1000, DateTime.Now, "Liguagem C#");
educacao.ExecutarMargemdeSeguranca();
Console.WriteLine(educacao.EmitirRelatorio());

var natacao = new Natacao("Natação", 0);
natacao.AtualizarValor(1000, DateTime.Now, "Aulas de natação");
natacao.ExecutarMargemdeSeguranca();
Console.WriteLine(natacao.EmitirRelatorio());

var danca = new Danca("Dança", 0);
danca.AtualizarValor(500, DateTime.Now, "Aulas de dança");
danca.ExecutarMargemdeSeguranca();
Console.WriteLine(danca.EmitirRelatorio());

var judo = new Judo("Judô", 0);
judo.AtualizarValor(500, DateTime.Now, "Kimono");
judo.AtualizarValor(200, DateTime.Now, "Camisetas");
judo.ExecutarMargemdeSeguranca();
Console.WriteLine(judo.EmitirRelatorio());

var ingles = new Ingles("Inglês", 0);
ingles.AtualizarValor(550, DateTime.Now, "Livro de inglês");
ingles.AtualizarValor(780, DateTime.Now, "Dicionário de inglês");
ingles.ExecutarMargemdeSeguranca();
Console.WriteLine(ingles.EmitirRelatorio());

var futebol = new Futebol("Futebol", 0);
futebol.AtualizarValor(1360, DateTime.Now, "Uniforme do time");
futebol.AtualizarValor(500, DateTime.Now, "Ingressos da temporada");
futebol.AtualizarValor(480, DateTime.Now, "Petiscos nos estádios");
futebol.AtualizarValor(222, DateTime.Now, "Adereços para os jogos");
futebol.ExecutarMargemdeSeguranca();
Console.WriteLine(futebol.EmitirRelatorio());