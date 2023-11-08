using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoCrud.Models
{
    public class Contacto
    {
        public int IdContacto { get; set; }

        [Required(ErrorMessage = "¡Este campo es obligatorio!")]
        [StringLength(40, ErrorMessage = "¡Los nombres solo pueden ocupar hasta 40 caracteres!")]

        public string Nombres { get; set; }

        [Required(ErrorMessage = "¡Este campo es obligatorio!")]
        [StringLength(40, ErrorMessage = "¡Los apellidos solo pueden ocupar hasta 40 caracteres!")]

        public string Apellidos { get; set; }


        [Required(ErrorMessage = "¡Este campo es obligatorio!")]
        [Range(1, double.MaxValue, ErrorMessage = "¡Solo puedes introducir un número válido! (Sin espacios, guiones, ni puntos)")]
        [StringLength(15, ErrorMessage = "¡Solo puedes introducir un número válido! (Sin espacios, guiones, ni puntos)")]

        public string Telefono { get; set; }

        [Required(ErrorMessage = "¡Este campo es obligatorio!")]
        [StringLength(45, ErrorMessage = "¡El correo solo puede ocupar hasta 45 caracteres!")]
        [EsEmail(ErrorMessage = "¡Este correo es invalido! ¡Solo se permiten correos @hotmail.com, @gmail.com y @outlook.com!")]

        public string Correo { get; set; }

    }
}