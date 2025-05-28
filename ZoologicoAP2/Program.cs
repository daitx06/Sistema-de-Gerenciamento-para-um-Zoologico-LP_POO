// Lista que armazenará todos os animais cadastrados.
List<Animal> animais = new();

// Lista que armazenará todos os funcionários cadastrados.
List<Funcionario> funcionarios = new();

// Variável de controle do loop principal do programa.
bool continuar = true;

// Loop principal do programa.
while (continuar)
{
    // Exibe o menu principal para o usuário.
    Console.WriteLine("\nMenu Principal:");
    Console.WriteLine("1. Cadastrar Animal");
    Console.WriteLine("2. Cadastrar Funcionário");
    Console.WriteLine("3. Interação Animal-Funcionário");
    Console.WriteLine("4. Sair");
    Console.Write("Escolha uma opção: ");
    
    // Lê a opção do usuário.
    string? opcao = Console.ReadLine();

    // Estrutura de decisão para executar a ação escolhida.
    switch (opcao)
    {
        case "1":
            CadastrarAnimal();
            break;
        case "2":
            CadastrarFuncionario();
            break;
        case "3":
            Interagir();
            break;
        case "4":
            continuar = false; // Encerra o loop.
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
}

// Método para cadastrar um animal.
void CadastrarAnimal()
{
    Console.Write("Tipo de Animal (Mamifero, Ave, Reptil): ");
    string? tipo = Console.ReadLine();

    Console.Write("Nome: ");
    string? nome = Console.ReadLine();

    Console.Write("Idade: ");
    int idade = int.Parse(Console.ReadLine()!);

    Console.Write("Peso: ");
    double peso = double.Parse(Console.ReadLine()!);

    Console.Write("Espécie: ");
    string? especie = Console.ReadLine();

    // Cria a instância de acordo com o tipo informado.
    Animal animal = tipo?.ToLower() switch
    {
        "mamifero" => new Mamifero(nome!, idade, peso, especie!),
        "ave" => new Ave(nome!, idade, peso, especie!),
        "reptil" => new Reptil(nome!, idade, peso, especie!),
        _ => throw new Exception("Tipo inválido!")
    };

    // Adiciona o animal à lista.
    animais.Add(animal);

    // Exibe mensagem de confirmação.
    Console.WriteLine($"\nAnimal cadastrado com sucesso: Nome: {animal.Nome}, Idade: {animal.Idade}, Peso: {animal.Peso}kg, Espécie: {animal.Especie}.");
}

// Método para cadastrar um funcionário.
void CadastrarFuncionario()
{
    Console.Write("Tipo de Funcionário (Veterinario, Zelador): ");
    string? tipo = Console.ReadLine();

    Console.Write("Nome: ");
    string? nome = Console.ReadLine();

    Console.Write("Idade: ");
    int idade = int.Parse(Console.ReadLine()!);

    // Cria a instância de acordo com o tipo informado.
    Funcionario funcionario = tipo?.ToLower() switch
    {
        "veterinario" => new Veterinario(nome!, idade),
        "zelador" => new Zelador(nome!, idade),
        _ => throw new Exception("Tipo inválido!")
    };

    // Adiciona o funcionário à lista.
    funcionarios.Add(funcionario);

    // Exibe mensagem de confirmação.
    Console.WriteLine($"\nFuncionário cadastrado com sucesso: Nome: {funcionario.Nome}, Idade: {funcionario.Idade}, Cargo: {funcionario.Cargo}.");
}

// Método para realizar interação entre funcionário e animal.
void Interagir()
{
    // Verifica se há ao menos um animal e um funcionário cadastrados.
    if (!animais.Any() || !funcionarios.Any())
    {
        Console.WriteLine("Necessário cadastrar ao menos um animal e um funcionário.");
        return;
    }

    // Exibe os animais cadastrados.
    Console.WriteLine("\nAnimais:");
    for (int i = 0; i < animais.Count; i++)
    {
        Console.WriteLine($"{i}: {animais[i].Nome} ({animais[i].Especie})");
    }

    Console.Write("Selecione o índice do animal: ");
    // Lê a entrada do usuário (número mostrado na lista), converte para int, 
    int idxAnimal = int.Parse(Console.ReadLine()!);

    // Exibe os funcionários cadastrados.
    Console.WriteLine("\nFuncionários:");
    for (int i = 0; i < funcionarios.Count; i++)
    {
        Console.WriteLine($"{i}: {funcionarios[i].Nome} ({funcionarios[i].Cargo})");
    }

    Console.Write("Selecione o índice do funcionário: ");
    // Lê a entrada do usuário (número mostrado na lista), converte para int
    int idxFunc = int.Parse(Console.ReadLine()!);

    // Obtém o animal e o funcionário selecionados.
    Animal animal = animais[idxAnimal];
    Funcionario funcionario = funcionarios[idxFunc];

    // Realiza a interação conforme o tipo do funcionário.
    switch (funcionario)
    {
        case Veterinario vet:
            vet.ConsultarAnimal(animal);
            vet.RealizarTratamento(animal);
            break;
        case Zelador zel:
            zel.AlimentarAnimal(animal);
            zel.CuidarHabitat(animal);
            break;
        default:
            Console.WriteLine("Interação não definida.");
            break;
    }
}
