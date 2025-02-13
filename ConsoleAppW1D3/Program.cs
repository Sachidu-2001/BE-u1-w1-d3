// See https://aka.ms/new-console-template for more information



Console.WriteLine("=======================");
Console.WriteLine("Benvenuto nel Tuo Conto");
Console.WriteLine("=======================");

Console.WriteLine("");

Console.WriteLine("Inserire numero Conto per accesso");

var InserireConto = Console.ReadLine();

var NuovoConto = "";


var ProprietarioConto = "";

var SaldoConto = 0;


if(InserireConto == "123456789") {
    Console.WriteLine("Ciao Sushi, inserisci la password");
    var InserirePassword = Console.ReadLine();
    if (InserirePassword == "Sachidu2001")
    {
        Console.WriteLine("PassWord Corretta, puoi procedere con i servizi");



    }
    else
    {
        Console.WriteLine("Ops, credo che tu non sia Sachi, inserisci di nuovo la password");

        InserirePassword = Console.ReadLine();
    }










} else{
    Console.WriteLine("Non risulta un conto, inseriamo un conto nuovo");

    NuovoConto = Console.ReadLine();

    Console.WriteLine("Ciao inserisci il tuo nome");

    ProprietarioConto = Console.ReadLine();

    Console.WriteLine($"Ciao {ProprietarioConto}, titolare del conto {NuovoConto} benvenuto nella Banca Popolare di Sachidu");


}

