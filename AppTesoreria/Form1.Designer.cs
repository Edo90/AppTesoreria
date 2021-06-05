
namespace AppTesoreria
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.nombreEmpresa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ferreteriaAmericanaDBDataSet = new AppTesoreria.FerreteriaAmericanaDBDataSet();
            this.empresaEmpleadosNominaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empresaEmpleadosNominaTableAdapter = new AppTesoreria.FerreteriaAmericanaDBDataSetTableAdapters.EmpresaEmpleadosNominaTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rNCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sueldoBrutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoMonedaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aRSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aFPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sueldoNetoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ferreteriaAmericanaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaEmpleadosNominaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreEmpresa
            // 
            this.nombreEmpresa.Location = new System.Drawing.Point(15, 79);
            this.nombreEmpresa.Name = "nombreEmpresa";
            this.nombreEmpresa.ReadOnly = true;
            this.nombreEmpresa.Size = new System.Drawing.Size(199, 20);
            this.nombreEmpresa.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Empresa";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.rNCDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.cedulaDataGridViewTextBoxColumn,
            this.sueldoBrutoDataGridViewTextBoxColumn,
            this.tipoMonedaDataGridViewTextBoxColumn,
            this.aRSDataGridViewTextBoxColumn,
            this.aFPDataGridViewTextBoxColumn,
            this.sueldoNetoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.empresaEmpleadosNominaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(254, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(722, 257);
            this.dataGridView1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(254, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Empleados";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ferreteriaAmericanaDBDataSet
            // 
            this.ferreteriaAmericanaDBDataSet.DataSetName = "FerreteriaAmericanaDBDataSet";
            this.ferreteriaAmericanaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empresaEmpleadosNominaBindingSource
            // 
            this.empresaEmpleadosNominaBindingSource.DataMember = "EmpresaEmpleadosNomina";
            this.empresaEmpleadosNominaBindingSource.DataSource = this.ferreteriaAmericanaDBDataSet;
            // 
            // empresaEmpleadosNominaTableAdapter
            // 
            this.empresaEmpleadosNominaTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rNCDataGridViewTextBoxColumn
            // 
            this.rNCDataGridViewTextBoxColumn.DataPropertyName = "RNC";
            this.rNCDataGridViewTextBoxColumn.HeaderText = "RNC";
            this.rNCDataGridViewTextBoxColumn.Name = "rNCDataGridViewTextBoxColumn";
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            // 
            // cedulaDataGridViewTextBoxColumn
            // 
            this.cedulaDataGridViewTextBoxColumn.DataPropertyName = "Cedula";
            this.cedulaDataGridViewTextBoxColumn.HeaderText = "Cedula";
            this.cedulaDataGridViewTextBoxColumn.Name = "cedulaDataGridViewTextBoxColumn";
            // 
            // sueldoBrutoDataGridViewTextBoxColumn
            // 
            this.sueldoBrutoDataGridViewTextBoxColumn.DataPropertyName = "SueldoBruto";
            this.sueldoBrutoDataGridViewTextBoxColumn.HeaderText = "SueldoBruto";
            this.sueldoBrutoDataGridViewTextBoxColumn.Name = "sueldoBrutoDataGridViewTextBoxColumn";
            // 
            // tipoMonedaDataGridViewTextBoxColumn
            // 
            this.tipoMonedaDataGridViewTextBoxColumn.DataPropertyName = "TipoMoneda";
            this.tipoMonedaDataGridViewTextBoxColumn.HeaderText = "TipoMoneda";
            this.tipoMonedaDataGridViewTextBoxColumn.Name = "tipoMonedaDataGridViewTextBoxColumn";
            // 
            // aRSDataGridViewTextBoxColumn
            // 
            this.aRSDataGridViewTextBoxColumn.DataPropertyName = "ARS";
            this.aRSDataGridViewTextBoxColumn.HeaderText = "ARS";
            this.aRSDataGridViewTextBoxColumn.Name = "aRSDataGridViewTextBoxColumn";
            // 
            // aFPDataGridViewTextBoxColumn
            // 
            this.aFPDataGridViewTextBoxColumn.DataPropertyName = "AFP";
            this.aFPDataGridViewTextBoxColumn.HeaderText = "AFP";
            this.aFPDataGridViewTextBoxColumn.Name = "aFPDataGridViewTextBoxColumn";
            // 
            // sueldoNetoDataGridViewTextBoxColumn
            // 
            this.sueldoNetoDataGridViewTextBoxColumn.DataPropertyName = "SueldoNeto";
            this.sueldoNetoDataGridViewTextBoxColumn.HeaderText = "SueldoNeto";
            this.sueldoNetoDataGridViewTextBoxColumn.Name = "sueldoNetoDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombreEmpresa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ferreteriaAmericanaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresaEmpleadosNominaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombreEmpresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private FerreteriaAmericanaDBDataSet ferreteriaAmericanaDBDataSet;
        private System.Windows.Forms.BindingSource empresaEmpleadosNominaBindingSource;
        private FerreteriaAmericanaDBDataSetTableAdapters.EmpresaEmpleadosNominaTableAdapter empresaEmpleadosNominaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rNCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sueldoBrutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoMonedaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aRSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aFPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sueldoNetoDataGridViewTextBoxColumn;
    }
}

