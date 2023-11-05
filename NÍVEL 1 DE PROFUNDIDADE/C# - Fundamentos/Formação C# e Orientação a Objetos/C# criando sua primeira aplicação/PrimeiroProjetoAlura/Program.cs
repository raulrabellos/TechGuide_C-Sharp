String mensagemDeBoasVindas = "Boas vindas ao Screen Sound!";
Dictionary<string, List<int>> bandas = new Dictionary<string, List<int>>();
bandas.Add("Nirvana", new List<int> { 10, 9, 11});
bandas.Add("SlipKnot", new List<int>());
void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
    ");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    
    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBanda(); break;
        case 2: ExibirBandas(); break;
        case 3: AvaliarUmaBanda(); break;
        case 4: ExibirMediaBanda(); break;
        case -1: Console.WriteLine("Tchau"); break;
        default: Console.Clear(); Console.WriteLine("Opção inválida!"); ExibirOpcoesDoMenu();
            break;
    }
}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro de banda");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"\nA banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(4000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirBandas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas");
    foreach (var banda in bandas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.Write("\nPrecione Enter para sair");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void AvaliarUmaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar Banda");
    Console.Write("Digite o nome da banda: ");
    string nomeBanda = Console.ReadLine()!;
    if (bandas.ContainsKey(nomeBanda)) {
        Console.Write($"Qual nota você da a banda {nomeBanda}: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandas[nomeBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeBanda} \n");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeBanda} não foi encontrada!");
        Console.WriteLine("Precione Enter para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

void ExibirMediaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Media da Banda");
    Console.Write("Digite o nome da banda: ");
    string nomeBanda = Console.ReadLine()!;
    if (bandas.ContainsKey(nomeBanda))
    {
        List<int> nota = bandas[nomeBanda];
        Console.WriteLine($"\nA media da banda {nomeBanda} é {nota.Average()}");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeBanda} não foi encontrada!");
        Console.WriteLine("\nPrecione Enter para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

ExibirOpcoesDoMenu();


