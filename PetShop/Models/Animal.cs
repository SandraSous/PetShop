namespace PetShop.Models {
    public class Animal {
       
        public int Id  { get; set; }
        public string? Raca { get; set; }

        public string? Especie { get; set; }
        public int ClienteId { get; set; }
        public Cliente? Cliente { get; set; }
    }
}
