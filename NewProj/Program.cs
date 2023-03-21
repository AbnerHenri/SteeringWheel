
static void Direction(string dir)
{
    switch (dir)
    {
        case "Cima":
            Console.WriteLine("Seguindo pra cima");
            break;
        case "Baixo":
            Console.WriteLine("Seguindo para baixo");
            break;
        case "Direita":
            Console.WriteLine("Virando a direita");
            break;
        case "Esquerda":
            Console.WriteLine("Virando a esquerda");
            break;
    }
}

bool Status = true;
Console.WriteLine("Digite Quit para sair do console!");

while (Status)
{
    Console.Write("Digite a direção : ");
    string Dir = Console.ReadLine();

    if(Dir == "Quit") {
        Status = false;
        Environment.Exit(0);
    }
    Direction(Dir);
}

Console.ReadKey();
