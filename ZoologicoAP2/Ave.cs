// Classe concreta que representa uma ave, derivada de Animal.
public class Ave : Animal
{
    // Construtor que passa os parâmetros para a classe base Animal.
    public Ave(string nome, int idade, double peso, string especie)
        : base(nome, idade, peso, especie) { }

    // Implementa como a ave emite som.
    public override void EmitirSom()
    {
        Console.WriteLine($"{Nome} está cantando.");
    }

    // Implementa como a ave se movimenta.
    public override void Movimentar()
    {
        Console.WriteLine($"{Nome} está voando.");
    }

    // Método específico de aves: voar.
    public void Voar()
    {
        Console.WriteLine($"{Nome} está voando alto.");
    }
}
