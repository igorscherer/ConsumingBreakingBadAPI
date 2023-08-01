using ConsumingBreakingBadAPI;

void ExibirLogo()
{
    Console.WriteLine(@"
  ____  _____  ______          _  _______ _   _  _____   ____          _____             _____ _____ 
 |  _ \|  __ \|  ____|   /\   | |/ /_   _| \ | |/ ____| |  _ \   /\   |  __ \      /\   |  __ \_   _|
 | |_) | |__) | |__     /  \  | ' /  | | |  \| | |  __  | |_) | /  \  | |  | |    /  \  | |__) || |  
 |  _ <|  _  /|  __|   / /\ \ |  <   | | | . ` | | |_ | |  _ < / /\ \ | |  | |   / /\ \ |  ___/ | |  
 | |_) | | \ \| |____ / ____ \| . \ _| |_| |\  | |__| | | |_) / ____ \| |__| |  / ____ \| |    _| |_ 
 |____/|_|  \_\______/_/    \_\_|\_\_____|_| \_|\_____| |____/_/    \_\_____/  /_/    \_\_|   |_____|                                                                                                                                                 
");
    Console.WriteLine("Consumir API de falas da série breaking bad\n");

}
void ExibirOpcoes()
{
    Console.Clear();
    ExibirLogo();
    Console.WriteLine("Digite 1 para mostrar uma fala aleatória da serie");
    Console.WriteLine("Digite 2 para mostrar uma fala de alguem da serie");
    string leitura = Console.ReadLine()!;
    int opcaoEscolhida = int.Parse(leitura!);
    if (opcaoEscolhida >= 1 && opcaoEscolhida <= 2)
    {
        if (opcaoEscolhida == 1)
        {
            var task = ConsultaAleatoria.ExecutarConsultaBreakingBad();
            task.Wait();
            VoltarAoMenu();
        }
        else
        {
            Console.WriteLine("Digite a quantia de Citacoes desejadas a serem exibidas: ");
            int qntCitacoes = int.Parse(Console.ReadLine());
            var task = MultiplaConsulta.ExecutarMultiplaConsultasBreakingBad(qntCitacoes);
            task.Wait();
            VoltarAoMenu();
        }
    }
    else
    {
        Console.WriteLine("Opcao digitada invalida, tente novamente: ");
        Thread.Sleep(1000);
        Console.Clear();
        ExibirOpcoes();
    }
}

void VoltarAoMenu (){

    Console.WriteLine("\nAperte uma tecla para voltar ao menu!");
    Console.ReadLine();
    ExibirOpcoes();
}
ExibirOpcoes();