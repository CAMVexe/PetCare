using System.ComponentModel.DataAnnotations;

namespace PetCare.Models
{
    public class Mascota
    {
        [Required(ErrorMessage = "Debe ingresar un nombre para poder referirse a la mascota")]
        [StringLength(2, ErrorMessage = "El nombre debe tener al menos 2 caracteres")]
        public string PetName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Debe ingresar una especie para la mascota")]
        public string Especie {  get; set; } = string.Empty;

        public string Raza { get; set; } = string.Empty;

        [Required(ErrorMessage = "Para poder agregar a la persona es necesario ingresar la edad")]
        [Range(1, 120, ErrorMessage = "La edad debe estar entre 0 y 120 años")]
        public int Edad { get; set; }

        [Required(ErrorMessage = "Debe ingresar el nombre del dueño")]
        [StringLength(3, ErrorMessage = "El nombre debe tener al menos 3 caracteres")]
        public string OwnerName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Se debe establecer un contacto (número telefónico")]
        [Range(10000000, 99999999, ErrorMessage = "El número debe tener exactamente 8 dígitos.")]
        public int OwnerTel  { get; set; }

        [Required(ErrorMessage = "Debe ingresar la fecha de ingreso de la mascota")]
        [DataType(DataType.Date)]
        public DateTime DateIn {  get; set; } = DateTime.Today;


    }
}
