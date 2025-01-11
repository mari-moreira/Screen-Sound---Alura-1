//Screen Sound

string boasVindas = "Boas vindas ao Screen Sound";

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();

bandasRegistradas.Add("O Rappa", new List<int> { 10, 9, 8 });
bandasRegistradas.Add("Natiruts", new List<int>());


//Exibir Logomarca

void ExibirLogo()
//site para essa logo : https://fsymbols.com
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(boasVindas);

}

void ExibirMenuOpcoes()
{
    ExibirLogo();

    Console.WriteLine("\nDigite 1 : Registar uma Banda");
    Console.WriteLine("Digite 2 : Mostar todas as Bandas");
    Console.WriteLine("Digite 3 : Avaliar uma Banda");
    Console.WriteLine("Digite 4 : Exibir media de uma banda");
    Console.WriteLine("Digite 0 : Sair do Programa");

    Console.Write("\nDigite sua opção  ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcao = int.Parse(opcaoEscolhida);

    switch (opcao)
    {
        case 1: RegistarBanda(); break;
        case 2: MostrarBandas(); break;
        case 3: AvaliarBanda(); break;
        case 4: ExibirMediaBanda(); break;
        case 0: Console.WriteLine("Progrma encerrado com sucesso!"); break;
        default:
            ;
            Console.WriteLine("Opção Inválida"); break;

    }
}



//Padrão de titulos
void ExibirTitulo(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string astericos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(astericos);
    Console.WriteLine(titulo);
    Console.WriteLine(astericos + "\n");

}

//Registar banda
void RegistarBanda()
{
    Console.Clear();
    ExibirTitulo("Registro de Bandas");
    Console.Write("Digite uma banda para registar  ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com Sucesso!");
    Thread.Sleep(3000);
    ExibirMenuOpcoes();

};

//Mostar banda
void MostrarBandas()
{
    Console.Clear();
    ExibirTitulo("Exibindo todas as Bandas Registradas ");

    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($" {banda}");
    }
    Thread.Sleep(4000);
    Console.Clear();
    ExibirMenuOpcoes();
};

//Avaliar Banda
void AvaliarBanda()
{
    Console.Clear();
    ExibirTitulo("Avaliar uma banda");
    Console.Write("Digite uma banda para avaliar ");
    string nomeBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeBanda))
    {
        Console.WriteLine($"Qual nota a banda {nomeBanda} merece ? ");
        int nota = int.Parse(Console.ReadLine());
        bandasRegistradas[nomeBanda].Add(nota);
        Console.WriteLine($"\n A nota {nota} foi registrada na {nomeBanda} com Sucesso");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirMenuOpcoes();

    }
    else
    {
        Console.WriteLine($"\n A banda {nomeBanda} não foi encontrada");
        Console.WriteLine("Digite qualquer tecla para voltar ao menu Principal");
        Console.ReadKey();
        ExibirMenuOpcoes();
    }
}

//Exibir Banda
void ExibirMediaBanda()
{
    Console.Clear();
    ExibirTitulo("Media da sua Banda preferida");
    Console.Write("Digite o nome da banda que desejar exiibir a média ");
    string nomeBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeBanda))
    {
        //pegar as notas da banda
        List<int> notasBanda = bandasRegistradas[nomeBanda];
        Console.WriteLine($" A media da Banda {nomeBanda} é {notasBanda.Average()}");
        Console.WriteLine("Digite qualquer tecla para voltar ao menu principal");
        Console.ReadKey();
        ExibirMenuOpcoes();
    }
    else
    {
        Console.WriteLine($"\n A banda {nomeBanda} não foi encontrada");
        Console.WriteLine("Digite qualquer tecla para voltar ao menu Principal");
        Console.ReadKey();
        ExibirMenuOpcoes();
    }
}

ExibirMenuOpcoes();