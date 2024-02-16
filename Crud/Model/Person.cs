using System.ComponentModel.DataAnnotations;

namespace Crud.Model
{
    class Person
    {
        private int Id { get; set; }

        [Required] //indicar que el campo es requerido
        private String Nombre { get; set; }
        
        private String Apellido { get; set; }

        private String Carrera { get; set; }

    }
}