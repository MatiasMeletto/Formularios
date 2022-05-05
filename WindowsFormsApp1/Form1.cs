using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json; 

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<Participante> Participantes = new List<Participante>();
        bool nuevo = false;
        int indice = -1;

        private void LeerArchivo()
        {
            FileInfo fi = new FileInfo("participantes.json");

            if (fi.Exists)
            {
                using (StreamReader lector = new StreamReader("participantes.json"))
                {
                    string datos = lector.ReadToEnd();
                    Participantes = JsonConvert.DeserializeObject<List<Participante>>(datos);
                }
            }

            ActualizarGrilla();
        }
        private void ActualizarLista()
        {
            using (StreamWriter escritor = new StreamWriter("participantes.json"))
            { 
                escritor.Write(JsonConvert.SerializeObject(Participantes));
            }
        }
        public Form1()
        {
            InitializeComponent();
            LeerArchivo();
            Bloquear(false);
            dateTimePicker1.MaxDate = DateTime.Today;
        }

        private void Bloquear(bool editando)
        {
            btnSumar.Enabled = !editando;
            btnAceptar.Enabled = editando;
            btnCancelar.Enabled = editando;
            btnEliminar.Enabled = !editando;
            txtboxAlt.Enabled = editando;
            txtboxApe.Enabled = editando;
            txtboxNom.Enabled = editando;
            txtboxPuesto.Enabled = editando;
            dateTimePicker1.Enabled = editando;
        }

        private void LimpiarForm()
        {
            txtboxPuesto.Text = "";
            txtboxNom.Text = "";
            txtboxApe.Text = "";
            txtboxAlt.Text = "";
            dateTimePicker1.Value = DateTime.Today; 
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            nuevo = true;
            LimpiarForm();
            Bloquear(true);
        }

        private List<string> ValidarDatos()
        {
            List<string> Errores = new List<string>();
            if (string.IsNullOrEmpty(txtboxNom.Text))
            {
                Errores.Add("Debe ingresar nombre");          
            }

            if (string.IsNullOrEmpty(txtboxApe.Text))
            {
                Errores.Add("Debe ingresar apellido");
            }

            if (string.IsNullOrEmpty(txtboxAlt.Text))
            {
                Errores.Add("Debe ingresar altura");
            }

            if (string.IsNullOrEmpty(txtboxPuesto.Text))
            {
                Errores.Add("Debe ingresar puesto");
            }

            return Errores;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            List<string> Errores = ValidarDatos();

            if (Errores.Count() != 0)
            {
                foreach (string a in Errores)
                {
                    MessageBox.Show(a);
                }
                return;
            }

            Participante p = new Participante(0, txtboxNom.Text, txtboxApe.Text, dateTimePicker1.Value, int.Parse(txtboxAlt.Text), int.Parse(txtboxPuesto.Text));
            if (nuevo == true)
            {
                Participantes.Add(p);
            }
            else if (nuevo == false)
            {
                Participantes[indice] = p;
            }
            

            LimpiarForm();
            ActualizarGrilla();
            Bloquear(false);

            return;
        }

        private void ActualizarGrilla()
        {
            VistaDeLista.DataSource = null;
            VistaDeLista.DataSource = Participantes;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (VistaDeLista.SelectedRows.Count != 1)
            {
                MessageBox.Show("Debe seleccionar al menos un participante");
            }

            else if (MessageBox.Show("¿Seguro que quiere eliminar a este participante?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Participantes.RemoveAt(VistaDeLista.SelectedRows[0].Index);
                ActualizarGrilla();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
            Bloquear(false);
        }

        private void VistaDeLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (VistaDeLista.SelectedRows.Count == 1)
            {
                nuevo = false;
                var participante = Participantes[VistaDeLista.SelectedRows[0].Index];
                indice = VistaDeLista.SelectedRows[0].Index;

                txtboxAlt.Text = participante.Altura.ToString();
                txtboxApe.Text = participante.Apellido;
                txtboxNom.Text = participante.Nombre;
                txtboxPuesto.Text = participante.Puesto.ToString();
                dateTimePicker1.Value = participante.FechaNacimiento;

                Bloquear(true);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ActualizarLista();
        }
    }
}
