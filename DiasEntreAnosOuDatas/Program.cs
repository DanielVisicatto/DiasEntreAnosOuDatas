//Console.Write("Digite a primeira data: ");
//DateTime firstDate = DateTime.Parse(Console.ReadLine());
//Console.Write("Digite a segunda data: ");
//DateTime secondDate = DateTime.Parse(Console.ReadLine());

//if(firstDate > secondDate)
//{
//    TimeSpan daysDifference = firstDate.Subtract(secondDate);
//    Console.WriteLine("Diferença de {0} dias", daysDifference.TotalDays);
//}
//else
//{
//    TimeSpan daysDifference2 = secondDate.Subtract(firstDate);
//    Console.WriteLine("Diferença de {0} dias", daysDifference2.TotalDays);
//}
int firstYear = 0, secondYear = 0, totalDays = 0;

RecebeValores();
VerificaAnosDigitados();

void VerificaAnosDigitados()
{
    if (firstYear < secondYear)
    {
        ContaNormalOuBissexto();
        Console.WriteLine("O total de dias entre {0} e {1} é de {2} dias",
            firstYear, secondYear, totalDays);
    }
    else
    {
        Console.WriteLine("Digite o menor ano primeiro por favor!");
    }
}
void RecebeValores()
{
    Console.Write("Digite o primeiro ano:");
    firstYear = int.Parse(Console.ReadLine());
    Console.Write("Digite o segundo ano:");
    secondYear = int.Parse(Console.ReadLine());
}
void ContaNormalOuBissexto()
{
    for (int year = firstYear; year <= secondYear; year++)// percorrendo todos os anos1
    {
        if (DateTime.IsLeapYear(year)) // se for bissexto conta 366, System verifica
        {
            totalDays += 366;
        }
        else
        {
            totalDays += 365; // senão conta normal 365
        }
    }
}