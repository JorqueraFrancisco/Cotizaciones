/// <summary>
/// Archivo donde se definen las clases del Dominio del problema.
/// </summary>
using System;

namespace Cotizaciones.Utilities {

    /// <summary>
    /// Clase que se usa para distintas utilidades de validacion
    /// </summary>
    public class Utilidades
    {
       
        public bool validarRut(string rut ) {

         bool validacion = false;
        try {
            rut =  rut.ToUpper();
            rut = rut.Replace(".", "");
            rut = rut.Replace("-", "");
            int rutAux = int.Parse(rut.Substring(0, rut.Length - 1));
 
            char dv = char.Parse(rut.Substring(rut.Length - 1, 1));
 
            int m = 0, s = 1;
            for (; rutAux != 0; rutAux /= 10) {
            s = (s + rutAux % 10 * (9 - m++ % 6)) % 11;
            }
            if (dv == (char) (s != 0 ? s + 47 : 75)) {
            validacion = true;
            }
        } catch (Exception) {
            Console.Write("   **RUT mal ingresado**  ");
            Environment.Exit(0);
        }
        
        return validacion;
        }

        public bool validarNombre(string nombre)
        {
            bool validacion = false;

         
                bool result = System.Text.RegularExpressions.Regex.IsMatch(nombre, @"^[a-zA-Z]+$");
                if(!result){
                    Console.Write("   **Nombre mal ingresado**  ");
                    Environment.Exit(0);
                }
               
           
            return validacion;
        }

        public bool validarID(int ID)
        {
            
            bool validacion = false;


            try{
                int bien = ID;
                validacion = true;
            }catch(Exception){
                Console.Write("   **ID mal ingresada**  ");
                Environment.Exit(0);
            }
            return validacion;
        }

        public bool validarFecha(DateTime fecha)
        {
            
            bool validacion = false;

            try{
                DateTime bien = fecha;
                validacion = true;
            }catch(Exception){
                Console.Write("   **Fecha mal ingresado**  ");
                Environment.Exit(0);
            }
            return validacion;
        }
       


        

    }
}