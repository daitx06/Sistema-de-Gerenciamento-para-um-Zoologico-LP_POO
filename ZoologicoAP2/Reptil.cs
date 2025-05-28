// Classe concreta que representa um réptil, derivada de Animal.
public class Reptil : Animal
{
    // Construtor que passa os parâmetros para a classe base Animal.
    public Reptil(string nome, int idade, double peso, string especie)
        : base(nome, idade, peso, especie) { }

    // Implementa como o réptil emite som.
    public override void EmitirSom()
    {
        Console.WriteLine($"{Nome} está fazendo um som reptiliano.");
    }

    // Implementa como o réptil se movimenta.
    public override void Movimentar()
    {
        Console.WriteLine($"{Nome} está rastejando.");
    }

    // Método específico de répteis: rastejar.
    public void Rastejar()
    {
        Console.WriteLine($"{Nome} está rastejando pelo chão.");
    }
}
