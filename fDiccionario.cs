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

namespace TLC_AnalizadorLexicoSintactico
{
    public partial class fDiccionario : Form
    {
        string archivoRes = Application.StartupPath + "\\Compiladores\\DiccionarioReservado.txt";
        string archivoResIni = Application.StartupPath + "\\Compiladores\\DiccionarioReservadoInicial.txt";
        string archivoIde = Application.StartupPath + "\\Compiladores\\DiccionarioIdentificadores.txt";
        string archivoIdeIni = Application.StartupPath + "\\Compiladores\\DiccionarioIdentificadoresInicial.txt";

        public fDiccionario()
        {
            InitializeComponent();
        }

        private void bAgregarDicc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Escriba en la ultima linea. Seleccione la ultima actual y presione la tecla de flecha para abajo para que se genere el nuevo renglon. Si desea cancelar solo oprima el boton cargar.");
            dgvDiccReservado.ReadOnly = false;
            dgvDiccReservado.AllowUserToAddRows = true;
            bGuardarDiccRes.Visible = true;
        }

        public void bCargarDiccReservado_Click(object sender, EventArgs e)
        {
            bGuardarDiccRes.Visible = false;
            dgvDiccReservado.ReadOnly = true;
            dgvDiccReservado.AllowUserToAddRows = false;
            CargarDGVreservado();
            dgvDiccReservado.Sort(dgvDiccReservado.Columns[1], ListSortDirection.Ascending);
        }

        private void CargarDGVreservado()
        {
            string[] lineas = File.ReadAllLines(archivoRes);
            dgvDiccReservado.Rows.Clear();

            for (int i = 0; i < lineas.Length; i++)
            {
                lineas[i] = lineas[i].Substring(0, lineas[i].Length - 1);   // formato csv que termina en coma
                string[] frases = lineas[i].Split(',');
                dgvDiccReservado.Rows.Add(frases[0], frases[1], frases[2]);
            }
        }

        private void bGuardarDiccRes_Click(object sender, EventArgs e)
        {
            dgvDiccReservado.ReadOnly = true;
            dgvDiccReservado.AllowUserToAddRows = false;

            if (File.Exists(archivoRes))
            {
                File.Delete(archivoRes);
            }

            StreamWriter escritor = File.AppendText(archivoRes);

            for (int i = 0; i < dgvDiccReservado.Rows.Count; i++)
            {
                escritor.WriteLine(dgvDiccReservado[0, i].Value + "," + dgvDiccReservado[1, i].Value + "," + dgvDiccReservado[2, i].Value + ",");
            }

            escritor.Close();
            bGuardarDiccRes.Visible = false;
        }

        private void bAgregarDiccIdentificadores_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Escriba en la ultima linea. Seleccione la ultima actual y presione la tecla de flecha para abajo para que se genere el nuevo renglon. Si desea cancelar solo oprima el boton cargar.");
            dgvDiccIdentificadores.ReadOnly = false;
            dgvDiccIdentificadores.AllowUserToAddRows = true;
            bGuardarDiccIdentificadores.Visible = true;

        }

        private void bGuardarDiccIdentificadores_Click(object sender, EventArgs e)
        {
            GuardarDiccIdentificadores();
        }

        public void GuardarDiccIdentificadores()
        {
            dgvDiccIdentificadores.ReadOnly = true;
            dgvDiccIdentificadores.AllowUserToAddRows = false;

            if (File.Exists(archivoIde))
            {
                File.Delete(archivoIde);
            }

            StreamWriter escritor = File.AppendText(archivoIde);

            for (int i = 0; i < dgvDiccIdentificadores.Rows.Count; i++)
            {
                escritor.WriteLine(dgvDiccIdentificadores[0, i].Value + "," + dgvDiccIdentificadores[1, i].Value + "," + dgvDiccIdentificadores[2, i].Value + ",");
            }

            escritor.Close();
            bGuardarDiccIdentificadores.Visible = false;
        }

        public void bCargarDiccIdentificadores_Click(object sender, EventArgs e)
        {
            bGuardarDiccIdentificadores.Visible = false;
            dgvDiccIdentificadores.ReadOnly = true;
            dgvDiccIdentificadores.AllowUserToAddRows = false;

            string[] lineas = File.ReadAllLines(archivoIde);
            dgvDiccIdentificadores.Rows.Clear();

            for (int i = 0; i < lineas.Length; i++)
            {
                lineas[i] = lineas[i].Substring(0, lineas[i].Length - 1);   // formato csv que termina en coma
                string[] frases = lineas[i].Split(',');
                dgvDiccIdentificadores.Rows.Add(frases[0], frases[1], frases[2]);
            }

            if(dgvDiccIdentificadores.Rows.Count > 0)
            {
                dgvDiccIdentificadores.Sort(dgvDiccIdentificadores.Columns[0], ListSortDirection.Ascending);
            }
        }

        private void dgvDiccIdentificadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        public void bInicialDiccIden_Click(object sender, EventArgs e)
        {
            Remplaza(archivoIdeIni, archivoIde);
            bCargarDiccIdentificadores_Click(sender, e);
        }

        public void bInicialDiccRes_Click(object sender, EventArgs e)
        {
            Remplaza(archivoResIni, archivoRes);
            bCargarDiccReservado_Click(sender, e);
        }

        private void Remplaza(string archivoOrigen, string archivoARemplazar)
        {
            if (File.Exists(archivoARemplazar))
            {
                File.Delete(archivoARemplazar);
            }

            File.Copy(archivoOrigen, archivoARemplazar);
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            Visible = false;
        }
    }
}