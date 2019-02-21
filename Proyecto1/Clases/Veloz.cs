using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Proyecto1.Clases
{
    public class Veloz
    {
        public enum estatus
        {
            creando = 1 , Modificando = 2, Eliminando = 3
        }

        public int id;
        public String Nombre;
        public String Contrasenia;
        public string Apellido;

        //Ejemplo de implementacion de propiedad, campo privado...
        //private int Identificacion;
        //public int Id///Propiedad publica que lleva como nombre id, para recuperar el valor del canpo identificacion
        //{
        //    get { return Identificacion; }///Aqui se obtiene el valor del campo identificacion
        //    set { Identificacion = value; }///Aqui se le puede realizar cambios
        //}
        //En caso de que desee solo puedo obtener osea de solo lectura..., a diferencia de la propiedad implementada automaticamente

        public Veloz(int id, string nombreuser, string contraseniauser, string Apellido)
        {
            this.id = id;
            this.Nombre = nombreuser;
            this.Contrasenia = contraseniauser;
            this.Apellido = Apellido;
        }


        //validacion correo eletronico
        public static bool ValidarEmail(string email)
        {
            string expression = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expression))
            {
                if(Regex.Replace(email,expression,String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
