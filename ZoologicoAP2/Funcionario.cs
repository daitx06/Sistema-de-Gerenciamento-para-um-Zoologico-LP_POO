// Classe abstrata que representa um funcionário.
public abstract class Funcionario
{
    // Propriedade que armazena o nome do funcionário.
    public string Nome { get; set; }
    
    // Propriedade que armazena a idade do funcionário.
    public int Idade { get; set; }
    
    // Propriedade que armazena o cargo do funcionário.
    public string Cargo { get; set; }

    // Construtor que inicializa as propriedades do funcionário.
    protected Funcionario(string nome, int idade, string cargo)
    {
        Nome = nome;      // Atribui o nome.
        Idade = idade;    // Atribui a idade.
        Cargo = cargo;    // Atribui o cargo.
    }

    // Método abstrato que obriga subclasses a implementar o trabalho.
    public abstract void Trabalhar();
}
