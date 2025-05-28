// Classe concreta que representa um Veterinário, derivada de Funcionario e implementa ITratamentoAnimal.
public class Veterinario : Funcionario, ITratamentoAnimal
{
    // Construtor que inicializa as propriedades, fixando o cargo como "Veterinário".
    public Veterinario(string nome, int idade)
        : base(nome, idade, "Veterinário") { }

    // Implementa o método de trabalhar do funcionário.
    public override void Trabalhar()
    {
        Console.WriteLine($"{Nome} está realizando consultas.");
    }

    // Método específico para consultar um animal.
    public void ConsultarAnimal(Animal animal)
    {
        Console.WriteLine($"Veterinário {Nome} consultou o animal {animal.Nome} com sucesso.");
    }

    // Implementa o método da interface para realizar tratamento.
    public void RealizarTratamento(Animal animal)
    {
        Console.WriteLine($"Veterinário {Nome} realizou tratamento no animal {animal.Nome}.");
    }
}


