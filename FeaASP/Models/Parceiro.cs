using System.ComponentModel.DataAnnotations;

namespace FEAasp.Models
{
    public class Parceiros
    {
        [Key]
        public int idParceiro { get; set; }
        public string NomeEmpresa { get; set; }
        public int CNPJ { get; set; }
        public int telefoneEmpresa { get; set; }
        public string CEP { get; set; }
        public string EmailEmpresa { get; set; }
        public string msgparceiro { get; set; }
    }
}
