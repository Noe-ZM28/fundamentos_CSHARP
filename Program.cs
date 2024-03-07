using fundamentos_CSHARP.Models;
/*
Perro GoldenRetriver = new Perro("Canino", "Guau Guau", "Firulais", 70, 1);

GoldenRetriver.Velocidad = 5;

GoldenRetriver.Correr(5);
System.Console.WriteLine(GoldenRetriver.Nombre +" hace " +GoldenRetriver.HacerSonido());


Gato Persa = new Gato("Felino", "Miau Miau", "Pelos", 20, 2);

Persa.Velocidad = 5;

Persa.arañar("Sillon");
System.Console.WriteLine(Persa.Nombre + " hace " + Persa.HacerSonido());

*/
  
byte row = 8;
ManageDB data = new ManageDB();
data.View();
data.Add(3, "asfasdfs", 140, "Rino", 70);
data.View();
data.Edit(row, 1, "abcde", 100, "abc", 10);
data.View();
data.Delete(row);
data.View();

