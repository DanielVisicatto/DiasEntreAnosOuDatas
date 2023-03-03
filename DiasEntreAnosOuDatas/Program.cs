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

Console.Write("Digite o primeiro ano:");
int firstYear = int.Parse(Console.ReadLine());
Console.Write("Digite o segundo ano:");
int secondYear = int.Parse(Console.ReadLine());

int totalDays = 0; // variável para contar os dias de cada ano manualmente.
if(firstYear < secondYear)
{
    for(int year = firstYear; year <= secondYear; year++)// percorrendo todos os anos1
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
    Console.WriteLine("O total de dias entre {0} e {1} é de {2} dias",
        firstYear, secondYear, totalDays);
}
else
{
    Console.WriteLine("Digite o menor ano primeiro por favor!");
}