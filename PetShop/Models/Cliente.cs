namespace PetShop.Models; 
public class Cliente {
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? Telefone { get; set; }
    public List<Animal>? Animais { get; set; }
    public IEnumerable<Servico> Servico { get; set; }
}
