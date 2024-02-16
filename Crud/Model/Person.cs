using System.ComponentModel.DataAnnotations;

namespace Crud.Model
{
    class Person
    {
        public Person()
        {
        }

        private int Id { get; set; }

        [Required] //indicar que el campo es requerido
        private String _Nombre { get; set; }
        
        private String _Apellido { get; set; }

        private String _Carrera { get; set; }

    }
}