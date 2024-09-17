using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiExamenDll
{
    public class clsExamenCanalWS : clsExamenCanal
    {
        public override DataTable ConsultarExamen(clsExamen examen)
        {
            return examen.ConsultarExamenWS();
        }
        public override void AgregarExamen(clsExamen examen, string Nombre, string Descripcion)
        {
            examen.AgregarExamenWS(Nombre, Descripcion);
        }
        public override void EliminarExamen(clsExamen examen, int id)
        {
            examen.EliminarExamenWS(id);
        }
        public override void ActualizarExamen(clsExamen examen, int id, string Nombre, string Descripcion)
        {
            examen.ActualizarExamenWS(id, Nombre, Descripcion);
        }
        public override string Descripcion()
        {
            return "Webservice";
        }
    }
}
