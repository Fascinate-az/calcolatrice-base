Console.WriteLine("inserire il primo numero");
int numb1 = int.Parse(Console.ReadLine());
Console.WriteLine("inserire il secondo numero");
int numb2 = int.Parse(Console.ReadLine());
Console.WriteLine("scegliere il tipo di operazione +,-,*,/");
string operazione = Console.ReadLine();

switch (operazione){
    case "+":
    int somma = numb1 + numb2;
    Console.WriteLine($"la somma è di {somma}");
    break;
    case "-":
    int sottrazione = numb1 - numb2;
    Console.WriteLine($"la sottrazione è di {sottrazione}");
    break;
    case "*":
    int moltiplicazione = numb1 * numb2;
    Console.WriteLine($"la moltiplicazione è di {moltiplicazione}");
    break;
    case "/":
    int divisione = numb1 / numb2;
    int resto = numb1 % numb2;
    Console.WriteLine($"la divisione è di {divisione} con il resto di {resto}");
    break;
    default:
    Console.WriteLine("operatore non valido");
    break;

}

Console.ReadKey();