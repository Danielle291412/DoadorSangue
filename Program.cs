int idade;
bool podeSerDoador;

Console.Clear();
Console.WriteLine("Qual é a sua idade?");

idade = Convert.ToInt32(Console.ReadLine ()!);
podeSerDoador = (idade >= 18) && (idade <= 67);

if (podeSerDoador)
{
     Console.WriteLine("Você pode ser doador de sangue.");
}
else
{
    Console.WriteLine("Você não pode ser doador de sangue.");
}