namespace TLC_AnalizadorLexicoSintactico
{
    partial class fPrincipal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fPrincipal));
            this.gbEditor = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNombreArchivo = new System.Windows.Forms.TextBox();
            this.gbIndentacion = new System.Windows.Forms.GroupBox();
            this.bFinInstruccion = new System.Windows.Forms.Button();
            this.bCerrarLlave = new System.Windows.Forms.Button();
            this.bAbrirLlave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNivelIndentacion = new System.Windows.Forms.TextBox();
            this.rbVB = new System.Windows.Forms.RadioButton();
            this.rbCsharp = new System.Windows.Forms.RadioButton();
            this.rbCpp = new System.Windows.Forms.RadioButton();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.bLimipiarCodigo = new System.Windows.Forms.Button();
            this.bGuardarCodigo = new System.Windows.Forms.Button();
            this.bAbrirCodigo = new System.Windows.Forms.Button();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.bCompilar = new System.Windows.Forms.Button();
            this.gbAnalisisLexico = new System.Windows.Forms.GroupBox();
            this.bVerDiccionario = new System.Windows.Forms.Button();
            this.dgvAnalisisLexico = new System.Windows.Forms.DataGridView();
            this.colLexema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComponenteLexico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPatron = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bAnalisisLexico = new System.Windows.Forms.Button();
            this.gbAnalisisSintactico = new System.Windows.Forms.GroupBox();
            this.bAnalisisSintactico = new System.Windows.Forms.Button();
            this.tbAnalisisSintactico = new System.Windows.Forms.TextBox();
            this.gbCompilacionEjecucion = new System.Windows.Forms.GroupBox();
            this.bAbrirCarpetaArchivos = new System.Windows.Forms.Button();
            this.rbCE_VB = new System.Windows.Forms.RadioButton();
            this.rbCE_Csharp = new System.Windows.Forms.RadioButton();
            this.rbCE_Cpp = new System.Windows.Forms.RadioButton();
            this.rbCE_C = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNombreCompilEje = new System.Windows.Forms.TextBox();
            this.bEjecutar = new System.Windows.Forms.Button();
            this.bInformacion = new System.Windows.Forms.Button();
            this.gbEditor.SuspendLayout();
            this.gbIndentacion.SuspendLayout();
            this.gbAnalisisLexico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnalisisLexico)).BeginInit();
            this.gbAnalisisSintactico.SuspendLayout();
            this.gbCompilacionEjecucion.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEditor
            // 
            this.gbEditor.Controls.Add(this.bInformacion);
            this.gbEditor.Controls.Add(this.label3);
            this.gbEditor.Controls.Add(this.tbNombreArchivo);
            this.gbEditor.Controls.Add(this.gbIndentacion);
            this.gbEditor.Controls.Add(this.rbVB);
            this.gbEditor.Controls.Add(this.rbCsharp);
            this.gbEditor.Controls.Add(this.rbCpp);
            this.gbEditor.Controls.Add(this.rbC);
            this.gbEditor.Controls.Add(this.bLimipiarCodigo);
            this.gbEditor.Controls.Add(this.bGuardarCodigo);
            this.gbEditor.Controls.Add(this.bAbrirCodigo);
            this.gbEditor.Controls.Add(this.tbCodigo);
            this.gbEditor.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.gbEditor.Location = new System.Drawing.Point(16, 15);
            this.gbEditor.Margin = new System.Windows.Forms.Padding(4);
            this.gbEditor.Name = "gbEditor";
            this.gbEditor.Padding = new System.Windows.Forms.Padding(4);
            this.gbEditor.Size = new System.Drawing.Size(677, 288);
            this.gbEditor.TabIndex = 0;
            this.gbEditor.TabStop = false;
            this.gbEditor.Text = "Editor de Codigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(442, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Archivo:";
            // 
            // tbNombreArchivo
            // 
            this.tbNombreArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNombreArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombreArchivo.ForeColor = System.Drawing.Color.Gold;
            this.tbNombreArchivo.Location = new System.Drawing.Point(504, 16);
            this.tbNombreArchivo.Name = "tbNombreArchivo";
            this.tbNombreArchivo.ReadOnly = true;
            this.tbNombreArchivo.Size = new System.Drawing.Size(164, 22);
            this.tbNombreArchivo.TabIndex = 14;
            this.tbNombreArchivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbIndentacion
            // 
            this.gbIndentacion.BackColor = System.Drawing.Color.Black;
            this.gbIndentacion.Controls.Add(this.bFinInstruccion);
            this.gbIndentacion.Controls.Add(this.bCerrarLlave);
            this.gbIndentacion.Controls.Add(this.bAbrirLlave);
            this.gbIndentacion.Controls.Add(this.label2);
            this.gbIndentacion.Controls.Add(this.tbNivelIndentacion);
            this.gbIndentacion.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.gbIndentacion.Location = new System.Drawing.Point(124, 12);
            this.gbIndentacion.Name = "gbIndentacion";
            this.gbIndentacion.Size = new System.Drawing.Size(273, 59);
            this.gbIndentacion.TabIndex = 12;
            this.gbIndentacion.TabStop = false;
            this.gbIndentacion.Text = "Indentación";
            // 
            // bFinInstruccion
            // 
            this.bFinInstruccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bFinInstruccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFinInstruccion.ForeColor = System.Drawing.Color.Gold;
            this.bFinInstruccion.Location = new System.Drawing.Point(47, 19);
            this.bFinInstruccion.Margin = new System.Windows.Forms.Padding(4);
            this.bFinInstruccion.Name = "bFinInstruccion";
            this.bFinInstruccion.Size = new System.Drawing.Size(32, 33);
            this.bFinInstruccion.TabIndex = 14;
            this.bFinInstruccion.Text = ";";
            this.bFinInstruccion.UseVisualStyleBackColor = false;
            this.bFinInstruccion.Click += new System.EventHandler(this.bFinInstruccion_Click);
            // 
            // bCerrarLlave
            // 
            this.bCerrarLlave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bCerrarLlave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCerrarLlave.ForeColor = System.Drawing.Color.Gold;
            this.bCerrarLlave.Location = new System.Drawing.Point(87, 19);
            this.bCerrarLlave.Margin = new System.Windows.Forms.Padding(4);
            this.bCerrarLlave.Name = "bCerrarLlave";
            this.bCerrarLlave.Size = new System.Drawing.Size(32, 33);
            this.bCerrarLlave.TabIndex = 13;
            this.bCerrarLlave.Text = "}";
            this.bCerrarLlave.UseVisualStyleBackColor = false;
            this.bCerrarLlave.Click += new System.EventHandler(this.bCerrarLlave_Click);
            // 
            // bAbrirLlave
            // 
            this.bAbrirLlave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bAbrirLlave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAbrirLlave.ForeColor = System.Drawing.Color.Gold;
            this.bAbrirLlave.Location = new System.Drawing.Point(7, 19);
            this.bAbrirLlave.Margin = new System.Windows.Forms.Padding(4);
            this.bAbrirLlave.Name = "bAbrirLlave";
            this.bAbrirLlave.Size = new System.Drawing.Size(32, 33);
            this.bAbrirLlave.TabIndex = 12;
            this.bAbrirLlave.Text = "{";
            this.bAbrirLlave.UseVisualStyleBackColor = false;
            this.bAbrirLlave.Click += new System.EventHandler(this.bAbrirLlave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nivel Actual:";
            // 
            // tbNivelIndentacion
            // 
            this.tbNivelIndentacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNivelIndentacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNivelIndentacion.ForeColor = System.Drawing.Color.Gold;
            this.tbNivelIndentacion.Location = new System.Drawing.Point(217, 22);
            this.tbNivelIndentacion.Name = "tbNivelIndentacion";
            this.tbNivelIndentacion.Size = new System.Drawing.Size(40, 24);
            this.tbNivelIndentacion.TabIndex = 11;
            this.tbNivelIndentacion.Text = "0";
            this.tbNivelIndentacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNivelIndentacion.TextChanged += new System.EventHandler(this.tbNivelIdentacion_TextChanged);
            // 
            // rbVB
            // 
            this.rbVB.AutoSize = true;
            this.rbVB.Location = new System.Drawing.Point(64, 50);
            this.rbVB.Name = "rbVB";
            this.rbVB.Size = new System.Drawing.Size(47, 21);
            this.rbVB.TabIndex = 8;
            this.rbVB.Text = "VB";
            this.rbVB.UseVisualStyleBackColor = true;
            // 
            // rbCsharp
            // 
            this.rbCsharp.AutoSize = true;
            this.rbCsharp.Location = new System.Drawing.Point(14, 50);
            this.rbCsharp.Name = "rbCsharp";
            this.rbCsharp.Size = new System.Drawing.Size(46, 21);
            this.rbCsharp.TabIndex = 7;
            this.rbCsharp.Text = "C#";
            this.rbCsharp.UseVisualStyleBackColor = true;
            // 
            // rbCpp
            // 
            this.rbCpp.AutoSize = true;
            this.rbCpp.Location = new System.Drawing.Point(64, 27);
            this.rbCpp.Name = "rbCpp";
            this.rbCpp.Size = new System.Drawing.Size(54, 21);
            this.rbCpp.TabIndex = 6;
            this.rbCpp.Text = "C++";
            this.rbCpp.UseVisualStyleBackColor = true;
            // 
            // rbC
            // 
            this.rbC.AutoSize = true;
            this.rbC.Location = new System.Drawing.Point(14, 27);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(38, 21);
            this.rbC.TabIndex = 5;
            this.rbC.Text = "C";
            this.rbC.UseVisualStyleBackColor = true;
            // 
            // bLimipiarCodigo
            // 
            this.bLimipiarCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bLimipiarCodigo.Location = new System.Drawing.Point(404, 45);
            this.bLimipiarCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.bLimipiarCodigo.Name = "bLimipiarCodigo";
            this.bLimipiarCodigo.Size = new System.Drawing.Size(97, 28);
            this.bLimipiarCodigo.TabIndex = 4;
            this.bLimipiarCodigo.Text = "Limpiar";
            this.bLimipiarCodigo.UseVisualStyleBackColor = false;
            this.bLimipiarCodigo.Click += new System.EventHandler(this.bLimipiarCodigo_Click);
            // 
            // bGuardarCodigo
            // 
            this.bGuardarCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bGuardarCodigo.Location = new System.Drawing.Point(586, 45);
            this.bGuardarCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.bGuardarCodigo.Name = "bGuardarCodigo";
            this.bGuardarCodigo.Size = new System.Drawing.Size(83, 28);
            this.bGuardarCodigo.TabIndex = 2;
            this.bGuardarCodigo.Text = "Guardar";
            this.bGuardarCodigo.UseVisualStyleBackColor = false;
            this.bGuardarCodigo.Click += new System.EventHandler(this.bGuardarCodigo_Click);
            // 
            // bAbrirCodigo
            // 
            this.bAbrirCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bAbrirCodigo.Location = new System.Drawing.Point(504, 45);
            this.bAbrirCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.bAbrirCodigo.Name = "bAbrirCodigo";
            this.bAbrirCodigo.Size = new System.Drawing.Size(83, 28);
            this.bAbrirCodigo.TabIndex = 1;
            this.bAbrirCodigo.Text = "Abrir";
            this.bAbrirCodigo.UseVisualStyleBackColor = false;
            this.bAbrirCodigo.Click += new System.EventHandler(this.bAbrirCodigo_Click);
            // 
            // tbCodigo
            // 
            this.tbCodigo.BackColor = System.Drawing.Color.Black;
            this.tbCodigo.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodigo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbCodigo.Location = new System.Drawing.Point(8, 80);
            this.tbCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.tbCodigo.Multiline = true;
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbCodigo.Size = new System.Drawing.Size(660, 200);
            this.tbCodigo.TabIndex = 0;
            this.tbCodigo.WordWrap = false;
            this.tbCodigo.TextChanged += new System.EventHandler(this.tbCodigo_TextChanged);
            // 
            // bCompilar
            // 
            this.bCompilar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bCompilar.Location = new System.Drawing.Point(8, 24);
            this.bCompilar.Margin = new System.Windows.Forms.Padding(4);
            this.bCompilar.Name = "bCompilar";
            this.bCompilar.Size = new System.Drawing.Size(210, 51);
            this.bCompilar.TabIndex = 3;
            this.bCompilar.Text = "Guardar y Compilar";
            this.bCompilar.UseVisualStyleBackColor = false;
            this.bCompilar.Click += new System.EventHandler(this.bCompilar_Click);
            // 
            // gbAnalisisLexico
            // 
            this.gbAnalisisLexico.Controls.Add(this.bVerDiccionario);
            this.gbAnalisisLexico.Controls.Add(this.dgvAnalisisLexico);
            this.gbAnalisisLexico.Controls.Add(this.bAnalisisLexico);
            this.gbAnalisisLexico.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.gbAnalisisLexico.Location = new System.Drawing.Point(16, 303);
            this.gbAnalisisLexico.Margin = new System.Windows.Forms.Padding(4);
            this.gbAnalisisLexico.Name = "gbAnalisisLexico";
            this.gbAnalisisLexico.Padding = new System.Windows.Forms.Padding(4);
            this.gbAnalisisLexico.Size = new System.Drawing.Size(677, 158);
            this.gbAnalisisLexico.TabIndex = 1;
            this.gbAnalisisLexico.TabStop = false;
            this.gbAnalisisLexico.Text = "Analisis Lexico para codigo en C#";
            // 
            // bVerDiccionario
            // 
            this.bVerDiccionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bVerDiccionario.Location = new System.Drawing.Point(8, 88);
            this.bVerDiccionario.Margin = new System.Windows.Forms.Padding(4);
            this.bVerDiccionario.Name = "bVerDiccionario";
            this.bVerDiccionario.Size = new System.Drawing.Size(97, 55);
            this.bVerDiccionario.TabIndex = 3;
            this.bVerDiccionario.Text = "Ver Diccionario";
            this.bVerDiccionario.UseVisualStyleBackColor = false;
            this.bVerDiccionario.Click += new System.EventHandler(this.bVerDiccionario_Click);
            // 
            // dgvAnalisisLexico
            // 
            this.dgvAnalisisLexico.AllowUserToAddRows = false;
            this.dgvAnalisisLexico.AllowUserToDeleteRows = false;
            this.dgvAnalisisLexico.AllowUserToOrderColumns = true;
            this.dgvAnalisisLexico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAnalisisLexico.BackgroundColor = System.Drawing.Color.Black;
            this.dgvAnalisisLexico.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAnalisisLexico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAnalisisLexico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnalisisLexico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLexema,
            this.colComponenteLexico,
            this.colPatron});
            this.dgvAnalisisLexico.GridColor = System.Drawing.Color.Black;
            this.dgvAnalisisLexico.Location = new System.Drawing.Point(113, 23);
            this.dgvAnalisisLexico.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAnalisisLexico.Name = "dgvAnalisisLexico";
            this.dgvAnalisisLexico.ReadOnly = true;
            this.dgvAnalisisLexico.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
            this.dgvAnalisisLexico.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAnalisisLexico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAnalisisLexico.Size = new System.Drawing.Size(556, 121);
            this.dgvAnalisisLexico.TabIndex = 2;
            // 
            // colLexema
            // 
            this.colLexema.HeaderText = "Lexema";
            this.colLexema.Name = "colLexema";
            this.colLexema.ReadOnly = true;
            // 
            // colComponenteLexico
            // 
            this.colComponenteLexico.HeaderText = "Componente Lexico";
            this.colComponenteLexico.Name = "colComponenteLexico";
            this.colComponenteLexico.ReadOnly = true;
            // 
            // colPatron
            // 
            this.colPatron.HeaderText = "Patron";
            this.colPatron.Name = "colPatron";
            this.colPatron.ReadOnly = true;
            // 
            // bAnalisisLexico
            // 
            this.bAnalisisLexico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bAnalisisLexico.Location = new System.Drawing.Point(8, 25);
            this.bAnalisisLexico.Margin = new System.Windows.Forms.Padding(4);
            this.bAnalisisLexico.Name = "bAnalisisLexico";
            this.bAnalisisLexico.Size = new System.Drawing.Size(97, 55);
            this.bAnalisisLexico.TabIndex = 1;
            this.bAnalisisLexico.Text = "Analizar o Actualizar";
            this.bAnalisisLexico.UseVisualStyleBackColor = false;
            this.bAnalisisLexico.Click += new System.EventHandler(this.bAnalisisLexico_Click);
            // 
            // gbAnalisisSintactico
            // 
            this.gbAnalisisSintactico.Controls.Add(this.bAnalisisSintactico);
            this.gbAnalisisSintactico.Controls.Add(this.tbAnalisisSintactico);
            this.gbAnalisisSintactico.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.gbAnalisisSintactico.Location = new System.Drawing.Point(16, 464);
            this.gbAnalisisSintactico.Margin = new System.Windows.Forms.Padding(4);
            this.gbAnalisisSintactico.Name = "gbAnalisisSintactico";
            this.gbAnalisisSintactico.Padding = new System.Windows.Forms.Padding(4);
            this.gbAnalisisSintactico.Size = new System.Drawing.Size(677, 117);
            this.gbAnalisisSintactico.TabIndex = 2;
            this.gbAnalisisSintactico.TabStop = false;
            this.gbAnalisisSintactico.Text = "Analisis Sintactico para codigo en C#";
            // 
            // bAnalisisSintactico
            // 
            this.bAnalisisSintactico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bAnalisisSintactico.Location = new System.Drawing.Point(8, 21);
            this.bAnalisisSintactico.Margin = new System.Windows.Forms.Padding(4);
            this.bAnalisisSintactico.Name = "bAnalisisSintactico";
            this.bAnalisisSintactico.Size = new System.Drawing.Size(97, 87);
            this.bAnalisisSintactico.TabIndex = 3;
            this.bAnalisisSintactico.Text = "Analizar o Actualizar";
            this.bAnalisisSintactico.UseVisualStyleBackColor = false;
            this.bAnalisisSintactico.Click += new System.EventHandler(this.bAnalisisSintactico_Click);
            // 
            // tbAnalisisSintactico
            // 
            this.tbAnalisisSintactico.BackColor = System.Drawing.Color.Black;
            this.tbAnalisisSintactico.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAnalisisSintactico.ForeColor = System.Drawing.Color.Gold;
            this.tbAnalisisSintactico.Location = new System.Drawing.Point(113, 21);
            this.tbAnalisisSintactico.Margin = new System.Windows.Forms.Padding(4);
            this.tbAnalisisSintactico.Multiline = true;
            this.tbAnalisisSintactico.Name = "tbAnalisisSintactico";
            this.tbAnalisisSintactico.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbAnalisisSintactico.Size = new System.Drawing.Size(555, 86);
            this.tbAnalisisSintactico.TabIndex = 0;
            this.tbAnalisisSintactico.WordWrap = false;
            // 
            // gbCompilacionEjecucion
            // 
            this.gbCompilacionEjecucion.Controls.Add(this.bAbrirCarpetaArchivos);
            this.gbCompilacionEjecucion.Controls.Add(this.rbCE_VB);
            this.gbCompilacionEjecucion.Controls.Add(this.rbCE_Csharp);
            this.gbCompilacionEjecucion.Controls.Add(this.rbCE_Cpp);
            this.gbCompilacionEjecucion.Controls.Add(this.rbCE_C);
            this.gbCompilacionEjecucion.Controls.Add(this.label1);
            this.gbCompilacionEjecucion.Controls.Add(this.tbNombreCompilEje);
            this.gbCompilacionEjecucion.Controls.Add(this.bEjecutar);
            this.gbCompilacionEjecucion.Controls.Add(this.bCompilar);
            this.gbCompilacionEjecucion.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.gbCompilacionEjecucion.Location = new System.Drawing.Point(16, 583);
            this.gbCompilacionEjecucion.Margin = new System.Windows.Forms.Padding(4);
            this.gbCompilacionEjecucion.Name = "gbCompilacionEjecucion";
            this.gbCompilacionEjecucion.Padding = new System.Windows.Forms.Padding(4);
            this.gbCompilacionEjecucion.Size = new System.Drawing.Size(677, 86);
            this.gbCompilacionEjecucion.TabIndex = 4;
            this.gbCompilacionEjecucion.TabStop = false;
            this.gbCompilacionEjecucion.Text = "Compilacion con csc.exe, vbc.exe, g++.exe o gcc.exe";
            // 
            // bAbrirCarpetaArchivos
            // 
            this.bAbrirCarpetaArchivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bAbrirCarpetaArchivos.Location = new System.Drawing.Point(449, 23);
            this.bAbrirCarpetaArchivos.Margin = new System.Windows.Forms.Padding(4);
            this.bAbrirCarpetaArchivos.Name = "bAbrirCarpetaArchivos";
            this.bAbrirCarpetaArchivos.Size = new System.Drawing.Size(112, 53);
            this.bAbrirCarpetaArchivos.TabIndex = 13;
            this.bAbrirCarpetaArchivos.Text = "Abrir Carpeta";
            this.bAbrirCarpetaArchivos.UseVisualStyleBackColor = false;
            this.bAbrirCarpetaArchivos.Click += new System.EventHandler(this.bAbrirCarpetaArchivos_Click);
            // 
            // rbCE_VB
            // 
            this.rbCE_VB.AutoSize = true;
            this.rbCE_VB.Location = new System.Drawing.Point(381, 53);
            this.rbCE_VB.Name = "rbCE_VB";
            this.rbCE_VB.Size = new System.Drawing.Size(47, 21);
            this.rbCE_VB.TabIndex = 12;
            this.rbCE_VB.Text = "VB";
            this.rbCE_VB.UseVisualStyleBackColor = true;
            // 
            // rbCE_Csharp
            // 
            this.rbCE_Csharp.AutoSize = true;
            this.rbCE_Csharp.Checked = true;
            this.rbCE_Csharp.Location = new System.Drawing.Point(334, 53);
            this.rbCE_Csharp.Name = "rbCE_Csharp";
            this.rbCE_Csharp.Size = new System.Drawing.Size(46, 21);
            this.rbCE_Csharp.TabIndex = 11;
            this.rbCE_Csharp.TabStop = true;
            this.rbCE_Csharp.Text = "C#";
            this.rbCE_Csharp.UseVisualStyleBackColor = true;
            // 
            // rbCE_Cpp
            // 
            this.rbCE_Cpp.AutoSize = true;
            this.rbCE_Cpp.Location = new System.Drawing.Point(278, 52);
            this.rbCE_Cpp.Name = "rbCE_Cpp";
            this.rbCE_Cpp.Size = new System.Drawing.Size(54, 21);
            this.rbCE_Cpp.TabIndex = 10;
            this.rbCE_Cpp.Text = "C++";
            this.rbCE_Cpp.UseVisualStyleBackColor = true;
            // 
            // rbCE_C
            // 
            this.rbCE_C.AutoSize = true;
            this.rbCE_C.Location = new System.Drawing.Point(228, 52);
            this.rbCE_C.Name = "rbCE_C";
            this.rbCE_C.Size = new System.Drawing.Size(38, 21);
            this.rbCE_C.TabIndex = 9;
            this.rbCE_C.Text = "C";
            this.rbCE_C.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre:";
            // 
            // tbNombreCompilEje
            // 
            this.tbNombreCompilEje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNombreCompilEje.ForeColor = System.Drawing.Color.Gold;
            this.tbNombreCompilEje.Location = new System.Drawing.Point(295, 22);
            this.tbNombreCompilEje.Name = "tbNombreCompilEje";
            this.tbNombreCompilEje.Size = new System.Drawing.Size(126, 22);
            this.tbNombreCompilEje.TabIndex = 5;
            this.tbNombreCompilEje.Text = "prueba";
            this.tbNombreCompilEje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bEjecutar
            // 
            this.bEjecutar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bEjecutar.Location = new System.Drawing.Point(568, 23);
            this.bEjecutar.Margin = new System.Windows.Forms.Padding(4);
            this.bEjecutar.Name = "bEjecutar";
            this.bEjecutar.Size = new System.Drawing.Size(100, 53);
            this.bEjecutar.TabIndex = 4;
            this.bEjecutar.Text = "Ejecutar";
            this.bEjecutar.UseVisualStyleBackColor = false;
            this.bEjecutar.Click += new System.EventHandler(this.bEjecutar_Click);
            // 
            // bInformacion
            // 
            this.bInformacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInformacion.Location = new System.Drawing.Point(404, 13);
            this.bInformacion.Margin = new System.Windows.Forms.Padding(4);
            this.bInformacion.Name = "bInformacion";
            this.bInformacion.Size = new System.Drawing.Size(31, 28);
            this.bInformacion.TabIndex = 15;
            this.bInformacion.Text = "?";
            this.bInformacion.UseVisualStyleBackColor = false;
            this.bInformacion.Click += new System.EventHandler(this.bInformacion_Click);
            // 
            // fPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(709, 682);
            this.Controls.Add(this.gbCompilacionEjecucion);
            this.Controls.Add(this.gbAnalisisSintactico);
            this.Controls.Add(this.gbAnalisisLexico);
            this.Controls.Add(this.gbEditor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TLC Analizador Lexico y Sintactico";
            this.Load += new System.EventHandler(this.fPrincipal_Load);
            this.gbEditor.ResumeLayout(false);
            this.gbEditor.PerformLayout();
            this.gbIndentacion.ResumeLayout(false);
            this.gbIndentacion.PerformLayout();
            this.gbAnalisisLexico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnalisisLexico)).EndInit();
            this.gbAnalisisSintactico.ResumeLayout(false);
            this.gbAnalisisSintactico.PerformLayout();
            this.gbCompilacionEjecucion.ResumeLayout(false);
            this.gbCompilacionEjecucion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEditor;
        private System.Windows.Forms.Button bCompilar;
        private System.Windows.Forms.Button bGuardarCodigo;
        private System.Windows.Forms.Button bAbrirCodigo;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.GroupBox gbAnalisisLexico;
        private System.Windows.Forms.Button bAnalisisLexico;
        private System.Windows.Forms.DataGridView dgvAnalisisLexico;
        private System.Windows.Forms.GroupBox gbAnalisisSintactico;
        private System.Windows.Forms.Button bAnalisisSintactico;
        private System.Windows.Forms.TextBox tbAnalisisSintactico;
        private System.Windows.Forms.Button bLimipiarCodigo;
        private System.Windows.Forms.GroupBox gbCompilacionEjecucion;
        private System.Windows.Forms.Button bEjecutar;
        private System.Windows.Forms.RadioButton rbCsharp;
        private System.Windows.Forms.RadioButton rbCpp;
        private System.Windows.Forms.RadioButton rbC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNombreCompilEje;
        private System.Windows.Forms.RadioButton rbVB;
        private System.Windows.Forms.Button bAbrirCarpetaArchivos;
        private System.Windows.Forms.RadioButton rbCE_VB;
        private System.Windows.Forms.RadioButton rbCE_Csharp;
        private System.Windows.Forms.RadioButton rbCE_Cpp;
        private System.Windows.Forms.RadioButton rbCE_C;
        private System.Windows.Forms.TextBox tbNivelIndentacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbIndentacion;
        private System.Windows.Forms.Button bFinInstruccion;
        private System.Windows.Forms.Button bCerrarLlave;
        private System.Windows.Forms.Button bAbrirLlave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNombreArchivo;
        private System.Windows.Forms.Button bVerDiccionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLexema;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComponenteLexico;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatron;
        private System.Windows.Forms.Button bInformacion;
    }
}

