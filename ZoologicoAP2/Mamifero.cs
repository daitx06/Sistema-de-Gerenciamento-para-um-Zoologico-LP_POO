// Classe concreta que representa um mamífero, derivada de Animal.
public class Mamifero : Animal
{
    // Construtor que passa os parâmetros para a classe base Animal.
    public Mamifero(string nome, int idade, double peso, string especie)
        : base(nome, idade, peso, especie) { }

    // Implementa como o mamífero emite som.
    public override void EmitirSom()
    {
        Console.WriteLine($"{Nome} está emitindo um som de mamífero.");
    }

    // Implementa como o mamífero se movimenta.
    public override void Movimentar()
    {
        Console.WriteLine($"{Nome} está se movendo como um mamífero.");
    }

    // Método específico de mamíferos: amamentar.
    public void Amamentar()
    {
        Console.WriteLine($"{Nome} está amamentando.");
    }
}
