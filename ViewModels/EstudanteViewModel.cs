namespace MvcRazorViews.ViewModels;

public class EstudanteViewModel
{
    public int Id { get; set; }
    public String Nome { get; set; }
    public String Endereco { get; set; }
    public bool Ativo { get; set; }

    public EstudanteViewModel(int id, string nome, string endereco, bool ativo)
    {
        Id = id;
        Nome = nome;
        Endereco = endereco;
        Ativo = ativo;
    }

}