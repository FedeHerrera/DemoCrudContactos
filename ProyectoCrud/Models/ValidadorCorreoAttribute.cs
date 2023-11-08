using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoCrud.Models
{
    public class EsEmail : ValidationAttribute
    {

        public override bool IsValid(object value)
        {
            // return true if value is a non-null number > 0, otherwise return false
            if (value == null) return false;
            bool bandera;
            bandera = value.ToString().EndsWith("hotmail.com");
            if (bandera == false) bandera = value.ToString().EndsWith("gmail.com");
            if (bandera == false) bandera = value.ToString().EndsWith("outlook.com");

            return (bandera);
        }
    }
}