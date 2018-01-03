using System;
using Cotizaciones.Utilities;
/// <summary>
/// Archivo donde se definen las clases del Dominio del problema.
/// </summary>
namespace Cotizaciones.Models
{

    /// <summary>
    /// Clase que representa a una persona en el Sistema.
    /// </summary>
    /// <remarks>
    /// Esta clase pertenece al modelo del Dominio y posee las siguientes restricciones:
    /// - No permite valores null en sus atributos.
    /// </remarks>
    public class Cotizacion
    {
       
        
        public int ID { get; set; }

        public DateTime fechaModificacion {get; set;}

        public DateTime fechaCreacion{get; set;}

        public string requisitos{get; set;}
        //Prueba
    

    }
}