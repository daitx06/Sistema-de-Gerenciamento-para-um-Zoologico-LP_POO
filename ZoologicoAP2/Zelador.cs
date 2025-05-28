// Classe concreta que representa um Zelador, derivada de Funcionario e implementa ICuidador.
public class Zelador : Funcionario, ICuidador
{
    // Construtor que inicializa as propriedades, fixando o cargo como "Zelador".
    public Zelador(string nome, int idade)
        : base(nome, idade, "Zelador") { }

    // Implementa o método de trabalhar do funcionário.
    public override void Trabalhar()
    {
        Console.WriteLine($"{Nome} está cuidando dos habitats.");
    }

    // Método específico para alimentar um animal.
    public void AlimentarAnimal(Animal animal)
    {
        Console.WriteLine($"Zelador {Nome} alimentou o animal {animal.Nome} com sucesso.");
    }

    // Implementa o método da interface para cuidar do habitat.
    public void CuidarHabitat(Animal animal)
    {
        Console.WriteLine($"Zelador {Nome} cuidou do habitat do animal {animal.Nome}.");
    }

}
