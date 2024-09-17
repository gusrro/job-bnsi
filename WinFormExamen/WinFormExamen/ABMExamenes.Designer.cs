namespace WinFormExamen
{
    partial class ABMExamenes
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbCanal = new System.Windows.Forms.GroupBox();
            this.rbWS = new System.Windows.Forms.RadioButton();
            this.rbSP = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btConsultar = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.gvExamenes = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.gbCanal.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvExamenes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.gbCanal);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btEliminar);
            this.panel1.Controls.Add(this.btConsultar);
            this.panel1.Controls.Add(this.btModificar);
            this.panel1.Controls.Add(this.btAgregar);
            this.panel1.Controls.Add(this.gvExamenes);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 319);
            this.panel1.TabIndex = 0;
            // 
            // gbCanal
            // 
            this.gbCanal.Controls.Add(this.rbWS);
            this.gbCanal.Controls.Add(this.rbSP);
            this.gbCanal.Location = new System.Drawing.Point(546, 187);
            this.gbCanal.Name = "gbCanal";
            this.gbCanal.Size = new System.Drawing.Size(228, 51);
            this.gbCanal.TabIndex = 2;
            this.gbCanal.TabStop = false;
            this.gbCanal.Text = "Canal de Datos";
            // 
            // rbWS
            // 
            this.rbWS.AutoSize = true;
            this.rbWS.Location = new System.Drawing.Point(125, 20);
            this.rbWS.Name = "rbWS";
            this.rbWS.Size = new System.Drawing.Size(82, 17);
            this.rbWS.TabIndex = 5;
            this.rbWS.Text = "Webservice";
            this.rbWS.UseVisualStyleBackColor = true;
            // 
            // rbSP
            // 
            this.rbSP.AutoSize = true;
            this.rbSP.Checked = true;
            this.rbSP.Location = new System.Drawing.Point(18, 20);
            this.rbSP.Name = "rbSP";
            this.rbSP.Size = new System.Drawing.Size(108, 17);
            this.rbSP.TabIndex = 4;
            this.rbSP.TabStop = true;
            this.rbSP.Text = "Stored Procedure";
            this.rbSP.UseVisualStyleBackColor = true;
            this.rbSP.CheckedChanged += new System.EventHandler(this.rbSP_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbDescripcion);
            this.panel2.Controls.Add(this.lbId);
            this.panel2.Controls.Add(this.lbNombre);
            this.panel2.Controls.Add(this.tbDescripcion);
            this.panel2.Controls.Add(this.tbId);
            this.panel2.Controls.Add(this.tbNombre);
            this.panel2.Location = new System.Drawing.Point(22, 155);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(508, 108);
            this.panel2.TabIndex = 2;
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Location = new System.Drawing.Point(41, 81);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lbDescripcion.TabIndex = 1;
            this.lbDescripcion.Text = "Descripción:";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(41, 17);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(21, 13);
            this.lbId.TabIndex = 1;
            this.lbId.Text = "ID:";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(41, 47);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(47, 13);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre:";
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(132, 78);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(310, 20);
            this.tbDescripcion.TabIndex = 3;
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Location = new System.Drawing.Point(132, 14);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(84, 20);
            this.tbId.TabIndex = 1;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(132, 47);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(310, 20);
            this.tbNombre.TabIndex = 2;
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(415, 269);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(125, 22);
            this.btEliminar.TabIndex = 9;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btConsultar
            // 
            this.btConsultar.Location = new System.Drawing.Point(284, 269);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(125, 22);
            this.btConsultar.TabIndex = 8;
            this.btConsultar.Text = "Consultar";
            this.btConsultar.UseVisualStyleBackColor = true;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // btModificar
            // 
            this.btModificar.Location = new System.Drawing.Point(153, 269);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(125, 22);
            this.btModificar.TabIndex = 7;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(22, 269);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(125, 22);
            this.btAgregar.TabIndex = 6;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // gvExamenes
            // 
            this.gvExamenes.AllowUserToAddRows = false;
            this.gvExamenes.AllowUserToDeleteRows = false;
            this.gvExamenes.AllowUserToOrderColumns = true;
            this.gvExamenes.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Beige;
            this.gvExamenes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvExamenes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gvExamenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvExamenes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gvExamenes.Location = new System.Drawing.Point(22, 14);
            this.gvExamenes.MultiSelect = false;
            this.gvExamenes.Name = "gvExamenes";
            this.gvExamenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvExamenes.Size = new System.Drawing.Size(752, 135);
            this.gvExamenes.TabIndex = 0;
            this.gvExamenes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvExamenes_CellContentClick);
            this.gvExamenes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvExamenes_CellContentClick);
            // 
            // ABMExamenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(811, 343);
            this.Controls.Add(this.panel1);
            this.Name = "ABMExamenes";
            this.Text = "Consulta de Exámenes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.gbCanal.ResumeLayout(false);
            this.gbCanal.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvExamenes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.DataGridView gvExamenes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.GroupBox gbCanal;
        private System.Windows.Forms.RadioButton rbWS;
        private System.Windows.Forms.RadioButton rbSP;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox tbId;
    }
}

