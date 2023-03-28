using System.ComponentModel.DataAnnotations.Schema;

namespace Botones.Models
{
    [Table("Botones")]
    public class Boton
    {
        public Boton()
        {
            Contador = 0;
        }        
        public int Id { get; set; }
        public int Contador { get; set; }
    }
}
