using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Proyecto1.Clases
{
    public  class Veloz
    {
        public enum estatus
        {
            creando = 1 , Modificando = 2, Eliminando = 3
        }

        public   int id;
        public   String Nombre;
        public  String Contrasenia;
        public  string Apellido;

        //Ejemplo de implementacion de propiedad, campo privado...
        //private int Identificacion;
        //public int Id///Propiedad publica que lleva como nombre id, para recuperar el valor del canpo identificacion
        //{
        //    get { return Identificacion; }///Aqui se obtiene el valor del campo identificacion
        //    set { Identificacion = value; }///Aqui se le puede realizar cambios
        //}
        //En caso de que desee solo puedo obtener osea de solo lectura..., a diferencia de la propiedad implementada automaticamente

        public  Veloz(int id, string nombreuser, string contraseniauser, string Apellido)
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
        public static string VerificacionString(string filtro)
        {
            try
            {
                string valor = filtro;
            }
            catch
            {
                return null;
            }
            return filtro;
        }
        public static byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        public static Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
       
       
    }
    public static class Funciones
    {
        public static string ToString<T>(this IList<T> list)
        {
            //de lista a strings
            return string.Join(",", list.ToArray());
        }
    }
}
