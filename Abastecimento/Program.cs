using CtlAbastec;

var abastecimentos = new Abastecimentos ("Renato Fernandez", 0m);

var gasolina = new Gasolina("Gasolina", 0);
gasolina.AtualizarValor(20, DateTime.Now, "Gasolina Comum");
gasolina.AtualizarValor(50, DateTime.Now, "Gasolina Aditivada");
gasolina.ExecutarAjustes();
Console.WriteLine(gasolina.EmitirRelatorio());

var alcool = new Alcool("Alcool", 0);
alcool.AtualizarValor(100, DateTime.Now, "Alcool Comum");
alcool.AtualizarValor(50, DateTime.Now, "Alcool Aditivada");
alcool.AtualizarValor(250, DateTime.Now, "Alcool Anidro");
alcool.ExecutarAjustes();
Console.WriteLine(alcool.EmitirRelatorio());

var diesel = new Diesel("Diesel", 0, -90);
diesel.AtualizarValor(500, DateTime.Now, "Diesel");
diesel.ExecutarAjustes();
Console.WriteLine(diesel.EmitirRelatorio());

var querosene = new Querosene("Querosene", 0);
querosene.AtualizarValor(1000, DateTime.Now, "Querosene");
querosene.ExecutarAjustes();
Console.WriteLine(querosene.EmitirRelatorio());

var nafta = new Nafta("Nafta", 0);
nafta.AtualizarValor(1000, DateTime.Now, "Nafta");
nafta.ExecutarAjustes();
Console.WriteLine(nafta.EmitirRelatorio());

var gnv = new GNV("GNV", 0);
gnv.AtualizarValor(500, DateTime.Now, "GNV");
gnv.ExecutarAjustes();
Console.WriteLine(gnv.EmitirRelatorio());

var dieselS10 = new DieselS10("Diesel S-10", 0);
dieselS10.AtualizarValor(500, DateTime.Now, "Diesel S-10");
dieselS10.AtualizarValor(200, DateTime.Now, "Aditivo 10");
dieselS10.ExecutarAjustes();
Console.WriteLine(dieselS10.EmitirRelatorio());