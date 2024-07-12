namespace PetShop.Models; 
public class Servico {
    public int Id { get; set; }
    public string? Descricao { get; set; }
    public float Valor { get; set;}
    public int clienteId { get; set; }
    public Cliente? Cliente { get; set; }

}
