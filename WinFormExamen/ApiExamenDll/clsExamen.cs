using System;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.Web.Configuration;


namespace ApiExamenDll
{
     
    public class clsExamen
    {
        private clsExamenCanal canal;
        private string cadenaConexion;
        public void setCanal(string parCanal)
        {
            if(parCanal == "WS")
                canal = new clsExamenCanalWS();
            else
                canal = new clsExamenCanalSP();
        }

        public string canalActual()
        {
            return this.canal.Descripcion();
        }

        private string CadenaConexion()
        {
            return ConfigurationManager.ConnectionStrings["conexionBD"].ConnectionString;
        }
              
        public void AgregarExamen(string Nombre, string Descripcion)
        {
            canal.AgregarExamen(this,Nombre,Descripcion);
        }

        public DataTable AgregarExamenSP(string Nombre, string Descripcion)
        {
            //Consumir Stored Procedure
            DataTable dt = new DataTable();
            string conexion = CadenaConexion();
            SqlConnection cnn = new SqlConnection(conexion);
            SqlDataAdapter da = new SqlDataAdapter("spAgregar", cnn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@Nombre", Nombre); ;
            da.SelectCommand.Parameters.AddWithValue("@Descripcion", Descripcion);
            da.Fill(dt);
            cnn.Close();
            return dt;
        }

        public string AgregarExamenWS(string Nombre, string Descripcion)
        {
            //Consumir Webservice
            var client = new RestClient("http://localhost:59951/api/tblExamen");
            var request = new RestRequest();
            request.Method = Method.POST;
            request.AddHeader("Content-Type", "application/json");
            
            Examen examen = new Examen();
            examen.idExamen = 1;
            examen.Nombre = Nombre;
            examen.Descripcion = Descripcion;

            var body = JsonConvert.SerializeObject(examen);
            request.AddParameter("application/json", body, ParameterType.RequestBody);

            var response = client.Execute(request);

            return response.ToString();
        }

        public string ActualizarExamenWS(int id,string Nombre, string Descripcion)
        {
            //Consumir Webservice
            var client = new RestClient("http://localhost:59951/api/tblExamen/"+ id);
            var request = new RestRequest();
            request.Method = Method.PUT;
            request.AddHeader("Content-Type", "application/json");

            Examen examen = new Examen();
            examen.idExamen = id;
            examen.Nombre = Nombre;
            examen.Descripcion = Descripcion;

            var body = JsonConvert.SerializeObject(examen);
            request.AddParameter("application/json", body, ParameterType.RequestBody);

            var response = client.Execute(request);

            return response.ToString();
        }

        public DataTable ActualizarExamenSP(int id, string Nombre, string Descripcion)
        {
            //Consumir Stored Procedure
            DataTable dt = new DataTable();
            string conexion = CadenaConexion();
            SqlConnection cnn = new SqlConnection(conexion);
            SqlDataAdapter da = new SqlDataAdapter("spModificar", cnn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@idExamen", id);
            da.SelectCommand.Parameters.AddWithValue("@Nombre", Nombre); ;
            da.SelectCommand.Parameters.AddWithValue("@Descripcion", Descripcion);
            da.Fill(dt);
            cnn.Close();
            return dt;
        }

        public void ActualizarExamen(int Id, string Nombre, string Descripcion)
        {
            canal.ActualizarExamen(this, Id, Nombre, Descripcion);
        }

        public bool EliminarExamen(int id)
        {
            canal.EliminarExamen(this,id);
            return true;
        }

        public bool EliminarExamenWS(int id)
        {
            var client = new RestClient("http://localhost:59951/api/tblExamen/" + id);
            var request = new RestRequest(Method.DELETE);
            var response = client.Execute(request);
            return true;
        }
        public bool EliminarExamenSP(int id)
        {
            //Consumir Stored Procedure
            DataTable dt = new DataTable();
            string conexion = CadenaConexion();
            SqlConnection cnn = new SqlConnection(conexion);
            cnn.Open();
            SqlCommand cmd = new SqlCommand("spEliminar", cnn);
            cmd.Parameters.AddWithValue("@idExamen", id);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            cnn.Close();
            return true;
        }

        public DataTable ConsultarExamen()
        {
               return canal.ConsultarExamen(this);
        }
        public DataTable ConsultarExamenSP()
        {
            //Consumir Stored Procedure
            DataTable dt = new DataTable();
            string conexion = CadenaConexion();
            SqlConnection cnn = new SqlConnection(conexion);
            SqlDataAdapter da = new SqlDataAdapter("spConsultarTodo", cnn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        public DataTable ConsultarExamenWS() //Examenes
        {
            RestClient client = new RestClient("http://localhost:59951/api/tblExamen");
            string Respuesta;
            RestRequest request = new RestRequest();
            var response = client.Get(request);
            Respuesta = response.Content;
            DataTable dt = (DataTable)JsonConvert.DeserializeObject(Respuesta, (typeof(DataTable)));
            return dt;  
        }
    }
 }
