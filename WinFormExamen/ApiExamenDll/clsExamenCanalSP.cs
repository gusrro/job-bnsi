using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiExamenDll
{
    public class clsExamenCanalSP : clsExamenCanal
    {
        public override DataTable ConsultarExamen(clsExamen examen)
        {
            return examen.ConsultarExamenSP();
        }
        public override void AgregarExamen(clsExamen examen, string Nombre, string Descripcion)
        {
            examen.AgregarExamenSP(Nombre, Descripcion);
        }
        public override void EliminarExamen(clsExamen examen, int id)
        {
            examen.EliminarExamenSP(id);
        }
        public override void ActualizarExamen(clsExamen examen, int id, string Nombre, string Descripcion)
        {
            examen.ActualizarExamenSP(id, Nombre, Descripcion);
        }
        public override string Descripcion()
        {
            return "Stored Procedure";
        }
    }
}
