using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTesoreria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog() { Filter = "Text Documents|*.txt", Multiselect = false, ValidateNames = true }) 
            { 
              if(dialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader sr = new StreamReader(dialog.FileName ))
                    {
                        FerreteriaAmericanaDBEntities1 dBEntities = new FerreteriaAmericanaDBEntities1();

                        string firstLine = sr.ReadLine();
                        string typeNomina  = firstLine.Substring(0,2);
                        string RNC = firstLine.Substring(2, 10);
                        string fechaDepago = firstLine.Substring(11, 10);
                        string fechaDeTransito = firstLine.Substring(21, 10);
                        
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            if (line.Length <= 3)
                                break;
                            
                            decimal sueldoBruto = decimal.Parse(line.Substring(14, 7));
                            decimal afp = sueldoBruto * (decimal)0.0287;
                            decimal ars = sueldoBruto * (decimal)0.0304;

                            dBEntities.EmpresaEmpleadosNomina.Add(new EmpresaEmpleadosNomina()
                            {
                                RNC = RNC,
                                Tipo = typeNomina,
                                Cedula = line.Substring(2, 13),
                                SueldoBruto = sueldoBruto,
                                TipoMoneda = line.Substring(23, 2),
                                AFP = afp,
                                ARS = ars,
                                SueldoNeto = sueldoBruto - afp - ars
                            });
                        }

                        dBEntities.SaveChanges();
                        nombreEmpresa.Text = "Ferreteria Americana";
                        dataGridView1.Refresh();
                        dataGridView1.DataSource = dBEntities.EmpresaEmpleadosNomina.ToList();
                        sr.Close();
                    }
                }  
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ferreteriaAmericanaDBDataSet.EmpresaEmpleadosNomina' table. You can move, or remove it, as needed.
            this.empresaEmpleadosNominaTableAdapter.Fill(this.ferreteriaAmericanaDBDataSet.EmpresaEmpleadosNomina);

        }
    }
}
