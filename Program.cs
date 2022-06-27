//morra cinese

//2 parteciapanti
// cpu e utente

//l'utente e i computer devono scegliere tra sasso carta e forbice
//una volta che l'utente scelgie bisogna decidicedere il vincitore/punteggio
//          sasso   carta   forbice
// sasso     p        vc       vs
// carta     -        p        vf
// forbice   -        -         p


//al meglio di N partite che stabilisce l'utente
//tenere il punteggio intermedio
//stampare alla fine il vincitore

//aggiungere alla fine di tutte le partie una stampa di tutte le mosse fatte dai giocatori.

Console.WriteLine("*********************");
Console.WriteLine("MORRA CINESE");
Console.WriteLine("*********************");

string[] options = { "sasso", "carta", "forbice" };
Random rnd = new Random();

Console.WriteLine("quante partite vuoi fare?");
int nPartite = int.Parse(Console.ReadLine());

int numeroVittoriePerVincere = nPartite / 2 + 1;
int punteggioUtente = 0;
int punteggioPc = 0;

string[] mosseUtente = new string[nPartite];
string[] mossePc = new string[nPartite];

for (int i = 0; i < nPartite; i++)
{
    Console.WriteLine("Segli tra sasso, carta o forbice");
    string userChoice = Console.ReadLine();
    mosseUtente[i] = userChoice;

    int rndNum = rnd.Next(1, 3);

    string pcChoice = options[rndNum];
    mossePc[i] = pcChoice;

    bool pareggio = userChoice == pcChoice;
    //outcomes dove vince l'utente
    bool forbiciWin = userChoice == "forbice" && pcChoice == "carta";
    bool sassoWin = userChoice == "sasso" && pcChoice == "forbice";
    bool cartaWin = userChoice == "carta" && pcChoice == "sasso";


    Console.WriteLine(pcChoice);

    if (pareggio)
    {
        Console.WriteLine("avete pareggiato");

    } else
    {
        if (forbiciWin || sassoWin || cartaWin)
        {
            Console.WriteLine("hai vinto 1 punto");
            punteggioUtente++;
        } else
        {
            Console.WriteLine("hai perso, il pc vince 1 punto");
            punteggioPc++;
        }
    }

}

if (punteggioPc == punteggioUtente)
{
    Console.WriteLine("Partita Finita! Avete pareggiato {0} a {1}", punteggioUtente, punteggioPc);

}else if (punteggioUtente > punteggioPc) 
{
    Console.WriteLine("Partita Finita! Hai vinto {0} a {1}", punteggioUtente, punteggioPc);

}else
{
    Console.WriteLine("Partita Finita! Hai perso {0} a {1}", punteggioUtente, punteggioPc);
}

Console.WriteLine();
Console.WriteLine("Partita\tTu\tPc");
for (int i = 0; i < nPartite; i++)
{

    Console.WriteLine("{0}\t{1}\t{2}" , i, mosseUtente[i], mossePc[i]);
}