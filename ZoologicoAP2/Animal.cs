// Classe abstrata que serve como modelo base para todos os animais.
public abstract class Animal
{
    // Propriedade que armazena o nome do animal.
    public string Nome { get; set; }
    
    // Propriedade que armazena a idade do animal.
    public int Idade { get; set; }
    
    // Propriedade que armazena o peso do animal.
    public double Peso { get; set; }
    
    // Propriedade que armazena a espécie do animal.
    public string Especie { get; set; }

    // Construtor que inicializa as propriedades do animal.
    protected Animal(string nome, int idade, double peso, string especie)
    {
        Nome = nome;      // Atribui o nome.
        Idade = idade;    // Atribui a idade.
        Peso = peso;      // Atribui o peso.
        Especie = especie;// Atribui a espécie.
    }

    // Método abstrato que obriga subclasses a implementar como o animal emite som.
    public abstract void EmitirSom();
    
    // Método abstrato que obriga subclasses a implementar como o animal se movimenta.
    public abstract void Movimentar();
}
