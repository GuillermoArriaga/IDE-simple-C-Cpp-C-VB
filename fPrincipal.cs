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
using System.Diagnostics;

namespace TLC_AnalizadorLexicoSintactico
{
    public partial class fPrincipal : Form
    {
        int nivelIndentacion = 0;
        fDiccionario dicc = new fDiccionario();

        public fPrincipal()
        {
            InitializeComponent();
        }

        private void bAbrirCodigo_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "Todos los Archivos | *.*| Archivos de C sharp | *.cs| Archivos de C | *.c| Archivos de Cpp | *.cpp| Archivos de texto | *.txt";
            abrir.Title = "Seleccione una ruta para abrir";
            abrir.InitialDirectory = Application.StartupPath + "\\Archivos";

            if (abrir.ShowDialog() == DialogResult.OK)  // Espera a tener valor de dialogResult
            {
                tbNombreArchivo.Text = abrir.SafeFileName;
                
                switch (tbNombreArchivo.Text.Substring(tbNombreArchivo.Text.Length - 1))
                {
                    case "s":
                        rbCsharp.Checked = true;    // .cs
                        rbCE_Csharp.Checked = true;
                        tbNombreCompilEje.Text = tbNombreArchivo.Text.Substring(0, tbNombreArchivo.Text.Length - 3);
                        break;
                    case "b":
                        rbVB.Checked = true;        // .vb
                        rbCE_VB.Checked = true;
                        tbNombreCompilEje.Text = tbNombreArchivo.Text.Substring(0, tbNombreArchivo.Text.Length - 3);
                        break;
                    case "p":
                        rbCpp.Checked = true;       // .cpp
                        rbCE_Cpp.Checked = true;
                        tbNombreCompilEje.Text = tbNombreArchivo.Text.Substring(0, tbNombreArchivo.Text.Length - 4);
                        break;
                    case "c":
                        rbC.Checked = true;         // .c
                        rbCE_C.Checked = true;
                        tbNombreCompilEje.Text = tbNombreArchivo.Text.Substring(0, tbNombreArchivo.Text.Length - 2);
                        break;
                }

                StreamReader lector = new StreamReader(abrir.FileName);
                tbCodigo.Text = lector.ReadToEnd();
                lector.Close();
            }
        }

        private void bGuardarCodigo_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog();

            guardar.Filter = "Todos los Archivos | *.*|Archivos de C sharp | *.cs| Archivos de C | *.c| Archivos de Cpp | *.cpp| Archivos de texto | *.txt| Archivos de Visual Basic | *.vb";
            if (rbC.Checked)
            {
                guardar.Filter = "Archivos de C | *.c| Todos los Archivos | *.*| Archivos de C sharp | *.cs| Archivos de Cpp | *.cpp| Archivos de texto | *.txt| Archivos de Visual Basic | *.vb";
            }
            if (rbCpp.Checked)
            {
                guardar.Filter = "Archivos de Cpp | *.cpp| Archivos de C | *.c| Todos los Archivos | *.*|Archivos de C sharp | *.cs| Archivos de texto | *.txt| Archivos de Visual Basic | *.vb";
            }
            if (rbCsharp.Checked)
            {
                guardar.Filter = "Archivos de C sharp | *.cs| Archivos de C | *.c| Todos los Archivos | *.*| Archivos de Cpp | *.cpp| Archivos de texto | *.txt| Archivos de Visual Basic | *.vb";
            }
            if (rbC.Checked)
            {
                guardar.Filter = "Archivos de Visual Basic | *.vb| Archivos de C | *.c| Todos los Archivos | *.*| Archivos de C sharp | *.cs| Archivos de Cpp | *.cpp| Archivos de texto | *.txt|";
            }

            guardar.Title = "Seleccione una ruta para guardar";
            guardar.InitialDirectory = Application.StartupPath + "\\Archivos";

            if (guardar.ShowDialog() == DialogResult.OK)  // Espera a tener valor de dialogResult
            {
                StreamWriter escritor = new StreamWriter(guardar.FileName);
                escritor.Write(tbCodigo.Text);
                escritor.Close();
            }

        }

        private void bLimipiarCodigo_Click(object sender, EventArgs e)
        {
            tbCodigo.Text = "";
            tbCodigo.Focus();
        }

        private void bCompilar_Click(object sender, EventArgs e)
        {
            string archivo = "";
            string compilador = "";

            if ( tbNombreCompilEje.Text == "")
            {
                tbNombreCompilEje.Text = "prueba";
            }

            if (rbCE_C.Checked)
            {
                archivo = "\\Archivos\\" + tbNombreCompilEje.Text + ".c";
                compilador = "\\Compiladores\\MinGW\\bin\\gcc.exe";
                //compilador = "\\Compiladores\\NETframework4.0.30319\\MSBuild.exe";  // cl.exe requiere 5GB, mejor con MinGW
            }

            if (rbCE_Cpp.Checked)
            {
                archivo = "\\Archivos\\" + tbNombreCompilEje.Text + ".cpp";
                compilador = "\\Compiladores\\MinGW\\bin\\g++.exe";
                //compilador = "\\Compiladores\\NETframework4.0.30319\\MSBuild.exe";  // cl.exe requiere 5GB, mejor con MinGW
            }

            if (rbCE_Csharp.Checked)
            {
                archivo = "\\Archivos\\" + tbNombreCompilEje.Text + ".cs";
                compilador = "\\Compiladores\\NETframework4.0.30319\\csc.exe";
            }

            if (rbCE_VB.Checked)
            {
                archivo = "\\Archivos\\" + tbNombreCompilEje.Text + ".vb";
                compilador = "\\Compiladores\\NETframework4.0.30319\\vbc.exe";
            }

            // Guardar
            if(File.Exists(Application.StartupPath + archivo))
            {
                File.Delete(Application.StartupPath + archivo);
            }
            StreamWriter escritor = new StreamWriter(Application.StartupPath + archivo);
            escritor.Write(tbCodigo.Text);
            escritor.Close();

            // Compilar
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = Application.StartupPath + compilador;
            info.Arguments = "\"" + Application.StartupPath + archivo + "\"";
            Process.Start(info);
        }

        private void bAbrirCarpetaArchivos_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + "\\Archivos");
        }

        private void bEjecutar_Click(object sender, EventArgs e)
        {
            // Reubicacion y Ejecucion

            string archivoPosicionFin = Application.StartupPath + "\\Archivos\\" + tbNombreCompilEje.Text + ".exe";

            if (rbCE_VB.Checked)
            {
                // El compilador de VB pone el archivo en la carpeta del archivo fuente
                Process.Start(archivoPosicionFin);
                return;
            }


            if (rbCE_Csharp.Checked)
            {

                // Aparece en directorio de la aplicacion el exe. Ahora se movera a la carpeta Archivos
                string archivoPosicionIni = Application.StartupPath + "\\" + tbNombreCompilEje.Text + ".exe";

                if (File.Exists(archivoPosicionFin))
                {
                    File.Delete(archivoPosicionFin);
                }

                if (File.Exists(archivoPosicionIni))
                {
                    File.Move(archivoPosicionIni, archivoPosicionFin);
                    Process.Start(archivoPosicionFin);
                }
                else
                {
                    MessageBox.Show("No hay archivo ejecutable aun (algun error para compilar).");
                }
            }
            else
            {
                // Aparece el ejecutable como a.exe en la carpeta de la aplicacion
                string archivoPosicionIni = Application.StartupPath + "\\a.exe";

                if (File.Exists(archivoPosicionFin))
                {
                    File.Delete(archivoPosicionFin);
                }

                if (File.Exists(archivoPosicionIni))
                {
                    File.Move(archivoPosicionIni, archivoPosicionFin);
                    Process.Start(archivoPosicionFin);
                }
                else
                {
                    MessageBox.Show("No hay archivo ejecutable aun (algun error para compilar) o ya existia uno con el nombre deseado.");
                }
            }
        }

        private void tbCodigo_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void tbNivelIdentacion_TextChanged(object sender, EventArgs e)
        {
            nivelIndentacion = Convert.ToInt32(tbNivelIndentacion.Text);
        }

        private void bAbrirLlave_Click(object sender, EventArgs e)
        {
            tbCodigo.AppendText("{" + String.Format(Environment.NewLine));
            nivelIndentacion++;
            tbNivelIndentacion.Text = nivelIndentacion.ToString();

            for (int i = 0; i < nivelIndentacion; i++)
            {
                tbCodigo.AppendText("    ");
            }
            tbCodigo.Focus();
        }

        private void bFinInstruccion_Click(object sender, EventArgs e)
        {
            tbCodigo.AppendText(";" + String.Format(Environment.NewLine));
            for (int i = 0; i < nivelIndentacion; i++)
            {
                tbCodigo.AppendText("    ");
            }
            tbCodigo.Focus();
        }

        private void bCerrarLlave_Click(object sender, EventArgs e)
        {
            if(nivelIndentacion > 0)
            {
                tbCodigo.Text = tbCodigo.Text.Substring(0, tbCodigo.Text.Length - 4);
            }
            
            tbCodigo.AppendText("}" + String.Format(Environment.NewLine));

            if (nivelIndentacion > 0)
            {
                nivelIndentacion--;
                tbNivelIndentacion.Text = nivelIndentacion.ToString();
                for (int i = 0; i < nivelIndentacion; i++)
                {
                    tbCodigo.AppendText("    ");
                }
            }
            tbCodigo.Focus();
        }

        private void bVerDiccionario_Click(object sender, EventArgs e)
        {
            dicc.Visible = true;
            dicc.bCargarDiccIdentificadores_Click(sender, e);
            dicc.bCargarDiccReservado_Click(sender, e);
        }

        private void fPrincipal_Load(object sender, EventArgs e)
        {
            dicc.Visible = false;
        }

        private void bAnalisisLexico_Click(object sender, EventArgs e)
        {
            dicc.bInicialDiccRes_Click(sender, e);
            dicc.bInicialDiccIden_Click(sender, e);
            dgvAnalisisLexico.Rows.Clear();

            for (int i = 0; i < tbCodigo.Lines.Length; i++)
            {
                string linea = QuitarComentarios(tbCodigo.Lines[i]);

                string[] lexema = linea.Split('"');
                int cantidadComillas = lexema.Length - 1;

                if (cantidadComillas % 2 == 0 && cantidadComillas > 0)
                {
                    Reconocer(lexema[0]);    // Siempre esta esta parte, aunque sea una cadena vacia antes de las comillas
                    for (int k = 1; k <= cantidadComillas; k += 2)
                    {
                        // Agrega directamente el valor string
                        dgvAnalisisLexico.Rows.Add("\"" + lexema[k] + "\"", "valor cadena", "caracter seguido de caracteres");
                        Reconocer(lexema[k + 1]);   // Agregar segun su reconocimiento
                    }
                }
                else
                {
                    // Despliegue de error si hay una cantidad impar de comillas
                    if (cantidadComillas % 2 == 1)
                    {
                        dgvAnalisisLexico.Rows.Add("-Linea " + (i+1), "error sintactico", "cantidad impar de comillas");
                    }
                    
                    // Si hay una cantidad impar de comillas solo las borra y continua
                    for( int k=0; k<=cantidadComillas; k++)
                    {
                        Reconocer(lexema[k]);
                    }
                }
            }
        }

        private void Reconocer(string noStrVal)    // Filtro que recibe un no valor de string
        {
            // Separar por espacios o signos de puntuacion: , { } :
            string[] lexemas = noStrVal.Split(' ', ',', '(', ')', '{', '}', ':', ';');    // el punto se tratara de modo especial

            for (int j = 0; j < lexemas.Length; j++)
            {
                if (lexemas[j] == "") // Salta palabras vacias, debidas a espacios.
                {
                    continue;
                }
                //lexemas[j].Replace("  ", string.Empty);   // Remueve espacios

                // Busqueda en diccionarios de referencias y de identificadores
                int posRef = buscarDiccRef(lexemas[j]);
                int posIde = buscarDiccId(lexemas[j]);

                if (posRef > -1)    // Es una palabra o simbolo reservado
                {
                    dgvAnalisisLexico.Rows.Add(dicc.dgvDiccReservado[0, posRef].Value, dicc.dgvDiccReservado[1, posRef].Value, dicc.dgvDiccReservado[2, posRef].Value);
                    continue;
                }
                else if (posIde > -1)    // Es un identificador antes detectado
                {
                    dgvAnalisisLexico.Rows.Add(dicc.dgvDiccIdentificadores[0, posIde].Value, dicc.dgvDiccIdentificadores[1, posIde].Value, dicc.dgvDiccIdentificadores[2, posIde].Value);
                    continue;
                }

                // Hasta aqui, es un nuevo identificador o un valor de variable numérica o caracter.

                if (lexemas[j][0] == '\'')    // *******************************************    Valor de caracter
                {
                    if (lexemas[j][2] == '\'')    // Valor sencillo
                    {
                        dgvAnalisisLexico.Rows.Add(lexemas[j], "valor de caracter", "caracter entre apostrofes");
                        continue;
                    }
                    else if ((lexemas[j][1] == '\\' && lexemas[j][3] == '\''))    // Caracter especial
                    {
                        dgvAnalisisLexico.Rows.Add(lexemas[j], "valor de caracter especial", "\\ + char especial");
                        continue;
                    }
                    else
                    {
                        dgvAnalisisLexico.Rows.Add(lexemas[j], "error sintactico", "pseudovalor de caracter");
                        continue;
                    }
                }

                int k;    // Revision de si todos sus integrantes son numeros o puntos
                for (k = 0; k < lexemas[j].Length && (char.IsDigit(lexemas[j][k]) || lexemas[j][k] == '.'); k++)
                {}
                if (k == lexemas[j].Length)    // **********************************************    Valor numerico
                {
                    int cantidadPuntos = lexemas[j].Split('.').Length - 1;
                    if (cantidadPuntos == 0)
                    {
                        dgvAnalisisLexico.Rows.Add(lexemas[j], "valor numerico entero", "digito seguido de digitos");
                        continue;
                    }
                    if (cantidadPuntos == 1)
                    {
                        dgvAnalisisLexico.Rows.Add(lexemas[j], "valor numerico real", "digito seguido de digitos con un punto");
                        continue;
                    }
                    if (cantidadPuntos > 1)
                    {
                        dgvAnalisisLexico.Rows.Add(lexemas[j], "error sintactico", "pseudovalor numerico real");
                        continue;
                    }
                }

                if (char.IsUpper(lexemas[j][0]))    // ************************    Identificador de clase o metodo
                {
                    dgvAnalisisLexico.Rows.Add(lexemas[j], "Identificador de metodo/clase/namespace/propiedad", "mayuscula seguida de caracteres");
                    dicc.dgvDiccIdentificadores.Rows.Add(lexemas[j], "Identificador de metodo/clase/namespace/propiedad", "mayuscula seguida de caracteres");
                    dicc.GuardarDiccIdentificadores();
                    continue;
                }
                else if (char.IsLower(lexemas[j][0]))    // Identificador de variable
                {
                    dgvAnalisisLexico.Rows.Add(lexemas[j], "Identificador de variable", "minuscula seguida de caracteres");
                    dicc.dgvDiccIdentificadores.Rows.Add(lexemas[j], "Identificador de variable", "minuscula seguida de caracteres");
                    dicc.GuardarDiccIdentificadores();
                    continue;
                }
                else    // Error de sintaxis: pseudo identificador o pseudo valor numerico
                {
                    dgvAnalisisLexico.Rows.Add(lexemas[j], "Error de sintaxis", "nombre que empieza con no letra o numero con mas de un punto");
                    continue;
                }
            }
        }


        private int buscarDiccRef(string palabra)
        {
            int posicion = -1;

            for (int i = 0; i < dicc.dgvDiccReservado.Rows.Count; i++)
            {
                if (palabra == dicc.dgvDiccReservado[0, i].Value.ToString())
                {
                    posicion = i;
                    break;
                }
            }

            return posicion;
        }

        private int buscarDiccId(string palabra)
        {
            int posicion = -1;

            for (int i = 0; i < dicc.dgvDiccIdentificadores.Rows.Count; i++)
            {
                if (palabra == dicc.dgvDiccIdentificadores[0, i].Value.ToString())
                {
                    posicion = i;
                    break;
                }
            }

            return posicion;
        }

        private string QuitarComentarios(string linea)
        {

            for( int i=0; i<linea.Length-1; i++)
            {
                if (linea.Substring(i,2) == "//")
                {
                    return linea.Substring(0,i);
                }
            }
            return linea;
        }

        private void bAnalisisSintactico_Click(object sender, EventArgs e)
        {
            bAnalisisLexico_Click(sender, e);
            tbAnalisisSintactico.Clear();
            int contaParentesis = 0;
            int contaLlaves = 0;

            for (int i = 0; i < tbCodigo.Lines.Length; i++)
            {
                if (tbCodigo.Lines[i].Length == 0)
                {
                    continue;
                }
                string linea = QuitarComentarios(tbCodigo.Lines[i]);


                // *************************************************************************    Terminaciones
                if(Contiene(linea, "namespace") || Contiene(linea, "class"))
                {
                    switch (linea[linea.Length - 1])
                    {
                        case ';':
                        case '}':
                        case ')':
                            tbAnalisisSintactico.AppendText("Error en linea " + (i + 1) + " = " + linea + " -:- La terminacion no debe ser ), ;, }.\n");
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    // Que termine cada linea en ; { } )
                    switch (linea[linea.Length - 1])
                    {
                        case ';':
                        case '{':
                        case '}':
                        case ')':
                            break;
                        default:
                            tbAnalisisSintactico.AppendText("Error en linea " + (i + 1) + " = " + linea + " -:- La terminacion no es la esperada ), ;, {, }.\n");
                            break;
                    }
                }

                // ********************************************************************    Cantidades ( ) { }
                if (Contiene(linea, "(")) contaParentesis++;
                if (Contiene(linea, ")")) contaParentesis--;
                if (Contiene(linea, "{")) contaLlaves++;
                if (Contiene(linea, "}")) contaLlaves--;
            }

            if (contaParentesis < 0 || contaParentesis % 2 == 1) tbAnalisisSintactico.AppendText("Error en cantidad de parentesis: " + contaParentesis + " es el resultado de restar a los de apertura los de cierre.");
            if (contaLlaves < 0 || contaLlaves % 2 == 1) tbAnalisisSintactico.AppendText("Error en cantidad de llaves: " + contaLlaves + " es el resultado de restar a las de apertura las de cierre.");
        }

        private Boolean Contiene(string frase, string palabra)  // Que regrese la cantidad de apariciones
        {
            int n = frase.Length;
            int m = palabra.Length;

            for (int i = 0; i < n - m; i++)
            {
                if (frase.Substring(i, m) == palabra)
                {
                    return true;
                }
            }
            return false;
        }


        private void bInformacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("RECOMENDACIONES DE FORMATO: \n\n"+
                "1. Iniciar con mayuscula el nombre de metodos, clases o namespaces.\n" +
                "2. Iniciar con minuscula el nombre de variables.\n" +
                "3. Cada linea debe terminar con ; ) { }, unicamente, a menos que haya un comentario.\n" +
                "4. Usar // para los comentarios, no hacerlos de varias lineas con /* */.\n" +
                "5. Mantener una indentacion adecuada.\n" +
                "6. Mantener los archivos fuente y ejecutables en la carpeta diseñada para ellos. Si se quieren manipular se puede trabajar sobre copias de ellos.\n\n\n" +
                "Desarrollado por Guillermo Arriaga Garcia en julio de 2017.\n" +
                "guillermoarriagag@gmail.com"
            );
        }
    }
}
