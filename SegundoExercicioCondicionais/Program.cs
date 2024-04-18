double nota1, nota2, media;

Console.Write("Digite sua primeira nota: ");
nota1 = double.Parse(Console.ReadLine());
Console.Write("Digite sua segunda nota: ");
nota2 = double.Parse(Console.ReadLine());

media = (nota1 + nota2) / 2;

if (media < 0)
{
    Console.WriteLine("Não existe nota abaixo de 0");
}
else if (media <= 3)
{
    Console.WriteLine("Reprovado");
}
else if (media > 3 && media <= 5)
{
    Console.WriteLine("Exame");
}
else
{
    Console.WriteLine("Aprovado");
}