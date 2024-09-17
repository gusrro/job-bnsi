using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApiExamenDll;


namespace WinFormExamen
{
    public partial class ABMExamenes : Form
    {
        //Instanciar la clase de la DLL
        public clsExamen dll = new clsExamen();
        public ABMExamenes()
        {
            InitializeComponent();
        }

        public void alternarColorFilasDataGridView(DataGridView grid)
        {
            //Alternar colores del grid
            grid.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Alternar colores de filas del DataGridView
            alternarColorFilasDataGridView(gvExamenes);

            //Setear canal de datos a StoredProcedure (SP Stored procedure/WS Webservice)
            dll.setCanal("WS");
            rbWS.Checked = true;

            //Consultar todos los registros de examenes
            gvExamenes.DataSource = dll.ConsultarExamen();
        }

        private void rbSP_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSP.Checked)
                dll.setCanal("SP");
            else
                dll.setCanal("WS");
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbNombre.Text == "" || tbDescripcion.Text == "")
                    MessageBox.Show("Debe llenar Nombre y Descripción", "Error al Agregar");
                else
                {
                    //Agregar registro
                    dll.AgregarExamen(tbNombre.Text, tbDescripcion.Text);
                    //Consultar todos los registros de examenes
                    gvExamenes.DataSource = dll.ConsultarExamen();
                    MessageBox.Show("Agregado a través de " + dll.canalActual());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbNombre.Text == "" || tbDescripcion.Text == "")
                    MessageBox.Show("Debe seleccionar registro con un click", "Error al Agregar");
                else
                {
                    //Actualizar registro
                    dll.ActualizarExamen(Convert.ToInt32(tbId.Text), tbNombre.Text, tbDescripcion.Text);
                    //Consultar todos los registros de examenes
                    gvExamenes.DataSource = dll.ConsultarExamen();
                    MessageBox.Show("Modificado a través de " + dll.canalActual());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btConsultar_Click(object sender, EventArgs e)
        {
            //Consultar todos los registros de examenes
            gvExamenes.DataSource = dll.ConsultarExamen();
            MessageBox.Show("Consulta realizada a través de " + dll.canalActual());
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Está seguro que quiere eliminar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                dll.EliminarExamen(Convert.ToInt32(tbId.Text));
                gvExamenes.DataSource = dll.ConsultarExamen();
                limpiarTextos();
                MessageBox.Show("Eliminado a través de " + dll.canalActual());
            }
        }

        private void limpiarTextos()
        {
            tbId.Text = "";
            tbNombre.Text = "";
            tbDescripcion.Text = "";
        }

        private void gvExamenes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbId.Text = gvExamenes.CurrentRow.Cells[0].Value.ToString();
            tbNombre.Text = gvExamenes.CurrentRow.Cells[1].Value.ToString();
            tbDescripcion.Text = gvExamenes.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
