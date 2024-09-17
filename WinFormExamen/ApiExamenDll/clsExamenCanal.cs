using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiExamenDll
{
    abstract public class clsExamenCanal
    {
        //Clase Abstracta
        abstract public DataTable ConsultarExamen(clsExamen examen);
        // se redefine en las subclases
        abstract public void AgregarExamen(clsExamen examen, string Nombre, string Descripcion);
        // se redefine en las subclases
        abstract public void EliminarExamen(clsExamen examen, int id);
        // se redefine en las subclases
        abstract public void ActualizarExamen(clsExamen examen, int id, string Nombre, string Descripcion);
        // se redefine en las subclases
        abstract public string Descripcion();
        // se redefine en las subclases
    }
}
