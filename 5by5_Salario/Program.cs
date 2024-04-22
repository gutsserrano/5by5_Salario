// faça um program que leia o valor atual do salário de uma pessoa e o valor com
// acréscimo e informe a porcentagem de acrescimo que foi dado

float salario1, salario2, porcent;

int option;

do
{
    do
    {
        Console.WriteLine("Digite o salário atual:");
        salario1 = float.Parse(Console.ReadLine());

        if (salario1 <= 0)
        {
            Console.WriteLine("\nSalário deve ser maioir que zero!");
        }
    } while (salario1 <= 0);

    do
    {
        Console.WriteLine("Digite o salário com acréscimo:");
        salario2 = float.Parse(Console.ReadLine());

        if (salario2 <= 0)
        {
            Console.WriteLine("\nSalário deve ser maioir que zero!\n");
        }else if(salario2 <= salario1)
        {
            Console.WriteLine("\nO novo salário deve ser maior que o salário atual!\n");
        }
    } while (salario2 <= 0 || salario2 <= salario1) ;

    porcent = (salario2 - salario1) * 100 / salario1;

    Console.WriteLine($"\nO salário subiu {porcent}%\n");

    do
    {
        Console.WriteLine("\nDeseja sair?");
        Console.WriteLine("1 - sim");
        Console.WriteLine("2 - não");
        option = int.Parse(Console.ReadLine());
    } while (option < 1 || option > 2);
} while (option == 2);
