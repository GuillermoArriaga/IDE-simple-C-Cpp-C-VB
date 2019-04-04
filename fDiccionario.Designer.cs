namespace TLC_AnalizadorLexicoSintactico
{
    partial class fDiccionario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDiccionario));
            this.bAgregarDiccRes = new System.Windows.Forms.Button();
            this.bCargarDiccRes = new System.Windows.Forms.Button();
            this.dgvDiccReservado = new System.Windows.Forms.DataGridView();
            this.colLexema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComponenteLexico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPatron = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDiccReservado = new System.Windows.Forms.GroupBox();
            this.bInicialDiccRes = new System.Windows.Forms.Button();
            this.bGuardarDiccRes = new System.Windows.Forms.Button();
            this.gbDiccIdentificadores = new System.Windows.Forms.GroupBox();
            this.bInicialDiccIden = new System.Windows.Forms.Button();
            this.bGuardarDiccIdentificadores = new System.Windows.Forms.Button();
            this.dgvDiccIdentificadores = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bCargarDiccIdentificadores = new System.Windows.Forms.Button();
            this.bAgregarDiccIdentificadores = new System.Windows.Forms.Button();
            this.bCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiccReservado)).BeginInit();
            this.gbDiccReservado.SuspendLayout();
            this.gbDiccIdentificadores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiccIdentificadores)).BeginInit();
            this.SuspendLayout();
            // 
            // bAgregarDiccRes
            // 
            this.bAgregarDiccRes.ForeColor = System.Drawing.Color.Black;
            this.bAgregarDiccRes.Location = new System.Drawing.Point(30, 24);
            this.bAgregarDiccRes.Name = "bAgregarDiccRes";
            this.bAgregarDiccRes.Size = new System.Drawing.Size(106, 32);
            this.bAgregarDiccRes.TabIndex = 1;
            this.bAgregarDiccRes.Text = "Agregar";
            this.bAgregarDiccRes.UseVisualStyleBackColor = true;
            this.bAgregarDiccRes.Click += new System.EventHandler(this.bAgregarDicc_Click);
            // 
            // bCargarDiccRes
            // 
            this.bCargarDiccRes.ForeColor = System.Drawing.Color.Black;
            this.bCargarDiccRes.Location = new System.Drawing.Point(468, 24);
            this.bCargarDiccRes.Name = "bCargarDiccRes";
            this.bCargarDiccRes.Size = new System.Drawing.Size(126, 32);
            this.bCargarDiccRes.TabIndex = 2;
            this.bCargarDiccRes.Text = "Cargar Ultimo";
            this.bCargarDiccRes.UseVisualStyleBackColor = true;
            this.bCargarDiccRes.Click += new System.EventHandler(this.bCargarDiccReservado_Click);
            // 
            // dgvDiccReservado
            // 
            this.dgvDiccReservado.AllowUserToAddRows = false;
            this.dgvDiccReservado.AllowUserToDeleteRows = false;
            this.dgvDiccReservado.AllowUserToOrderColumns = true;
            this.dgvDiccReservado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiccReservado.BackgroundColor = System.Drawing.Color.Black;
            this.dgvDiccReservado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDiccReservado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDiccReservado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiccReservado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLexema,
            this.colComponenteLexico,
            this.colPatron});
            this.dgvDiccReservado.GridColor = System.Drawing.Color.Black;
            this.dgvDiccReservado.Location = new System.Drawing.Point(26, 74);
            this.dgvDiccReservado.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDiccReservado.Name = "dgvDiccReservado";
            this.dgvDiccReservado.ReadOnly = true;
            this.dgvDiccReservado.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
            this.dgvDiccReservado.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDiccReservado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiccReservado.Size = new System.Drawing.Size(568, 256);
            this.dgvDiccReservado.TabIndex = 3;
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
            // gbDiccReservado
            // 
            this.gbDiccReservado.Controls.Add(this.bInicialDiccRes);
            this.gbDiccReservado.Controls.Add(this.bGuardarDiccRes);
            this.gbDiccReservado.Controls.Add(this.dgvDiccReservado);
            this.gbDiccReservado.Controls.Add(this.bCargarDiccRes);
            this.gbDiccReservado.Controls.Add(this.bAgregarDiccRes);
            this.gbDiccReservado.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.gbDiccReservado.Location = new System.Drawing.Point(15, 46);
            this.gbDiccReservado.Name = "gbDiccReservado";
            this.gbDiccReservado.Size = new System.Drawing.Size(618, 354);
            this.gbDiccReservado.TabIndex = 4;
            this.gbDiccReservado.TabStop = false;
            this.gbDiccReservado.Text = "Diccionario de palabras y signos reservados de C#";
            // 
            // bInicialDiccRes
            // 
            this.bInicialDiccRes.ForeColor = System.Drawing.Color.Black;
            this.bInicialDiccRes.Location = new System.Drawing.Point(262, 24);
            this.bInicialDiccRes.Name = "bInicialDiccRes";
            this.bInicialDiccRes.Size = new System.Drawing.Size(144, 32);
            this.bInicialDiccRes.TabIndex = 6;
            this.bInicialDiccRes.Text = "Volver al Inicial";
            this.bInicialDiccRes.UseVisualStyleBackColor = true;
            this.bInicialDiccRes.Click += new System.EventHandler(this.bInicialDiccRes_Click);
            // 
            // bGuardarDiccRes
            // 
            this.bGuardarDiccRes.ForeColor = System.Drawing.Color.Black;
            this.bGuardarDiccRes.Location = new System.Drawing.Point(142, 24);
            this.bGuardarDiccRes.Name = "bGuardarDiccRes";
            this.bGuardarDiccRes.Size = new System.Drawing.Size(110, 32);
            this.bGuardarDiccRes.TabIndex = 4;
            this.bGuardarDiccRes.Text = "Guardar";
            this.bGuardarDiccRes.UseVisualStyleBackColor = true;
            this.bGuardarDiccRes.Click += new System.EventHandler(this.bGuardarDiccRes_Click);
            // 
            // gbDiccIdentificadores
            // 
            this.gbDiccIdentificadores.Controls.Add(this.bInicialDiccIden);
            this.gbDiccIdentificadores.Controls.Add(this.bGuardarDiccIdentificadores);
            this.gbDiccIdentificadores.Controls.Add(this.dgvDiccIdentificadores);
            this.gbDiccIdentificadores.Controls.Add(this.bCargarDiccIdentificadores);
            this.gbDiccIdentificadores.Controls.Add(this.bAgregarDiccIdentificadores);
            this.gbDiccIdentificadores.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.gbDiccIdentificadores.Location = new System.Drawing.Point(15, 410);
            this.gbDiccIdentificadores.Name = "gbDiccIdentificadores";
            this.gbDiccIdentificadores.Size = new System.Drawing.Size(618, 247);
            this.gbDiccIdentificadores.TabIndex = 5;
            this.gbDiccIdentificadores.TabStop = false;
            this.gbDiccIdentificadores.Text = "Diccionario de identificadores del usuario o C#";
            // 
            // bInicialDiccIden
            // 
            this.bInicialDiccIden.ForeColor = System.Drawing.Color.Black;
            this.bInicialDiccIden.Location = new System.Drawing.Point(262, 24);
            this.bInicialDiccIden.Name = "bInicialDiccIden";
            this.bInicialDiccIden.Size = new System.Drawing.Size(144, 32);
            this.bInicialDiccIden.TabIndex = 5;
            this.bInicialDiccIden.Text = "Volver al Inicial";
            this.bInicialDiccIden.UseVisualStyleBackColor = true;
            this.bInicialDiccIden.Click += new System.EventHandler(this.bInicialDiccIden_Click);
            // 
            // bGuardarDiccIdentificadores
            // 
            this.bGuardarDiccIdentificadores.ForeColor = System.Drawing.Color.Black;
            this.bGuardarDiccIdentificadores.Location = new System.Drawing.Point(146, 24);
            this.bGuardarDiccIdentificadores.Name = "bGuardarDiccIdentificadores";
            this.bGuardarDiccIdentificadores.Size = new System.Drawing.Size(106, 32);
            this.bGuardarDiccIdentificadores.TabIndex = 4;
            this.bGuardarDiccIdentificadores.Text = "Guardar";
            this.bGuardarDiccIdentificadores.UseVisualStyleBackColor = true;
            this.bGuardarDiccIdentificadores.Click += new System.EventHandler(this.bGuardarDiccIdentificadores_Click);
            // 
            // dgvDiccIdentificadores
            // 
            this.dgvDiccIdentificadores.AllowUserToAddRows = false;
            this.dgvDiccIdentificadores.AllowUserToDeleteRows = false;
            this.dgvDiccIdentificadores.AllowUserToOrderColumns = true;
            this.dgvDiccIdentificadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiccIdentificadores.BackgroundColor = System.Drawing.Color.Black;
            this.dgvDiccIdentificadores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDiccIdentificadores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDiccIdentificadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiccIdentificadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvDiccIdentificadores.GridColor = System.Drawing.Color.Black;
            this.dgvDiccIdentificadores.Location = new System.Drawing.Point(26, 74);
            this.dgvDiccIdentificadores.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDiccIdentificadores.Name = "dgvDiccIdentificadores";
            this.dgvDiccIdentificadores.ReadOnly = true;
            this.dgvDiccIdentificadores.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Blue;
            this.dgvDiccIdentificadores.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDiccIdentificadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiccIdentificadores.Size = new System.Drawing.Size(568, 149);
            this.dgvDiccIdentificadores.TabIndex = 3;
            this.dgvDiccIdentificadores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiccIdentificadores_CellContentClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Lexema";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Componente Lexico";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Patron";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // bCargarDiccIdentificadores
            // 
            this.bCargarDiccIdentificadores.ForeColor = System.Drawing.Color.Black;
            this.bCargarDiccIdentificadores.Location = new System.Drawing.Point(468, 24);
            this.bCargarDiccIdentificadores.Name = "bCargarDiccIdentificadores";
            this.bCargarDiccIdentificadores.Size = new System.Drawing.Size(126, 32);
            this.bCargarDiccIdentificadores.TabIndex = 2;
            this.bCargarDiccIdentificadores.Text = "Cargar Ultimo";
            this.bCargarDiccIdentificadores.UseVisualStyleBackColor = true;
            this.bCargarDiccIdentificadores.Click += new System.EventHandler(this.bCargarDiccIdentificadores_Click);
            // 
            // bAgregarDiccIdentificadores
            // 
            this.bAgregarDiccIdentificadores.ForeColor = System.Drawing.Color.Black;
            this.bAgregarDiccIdentificadores.Location = new System.Drawing.Point(30, 24);
            this.bAgregarDiccIdentificadores.Name = "bAgregarDiccIdentificadores";
            this.bAgregarDiccIdentificadores.Size = new System.Drawing.Size(106, 32);
            this.bAgregarDiccIdentificadores.TabIndex = 1;
            this.bAgregarDiccIdentificadores.Text = "Agregar";
            this.bAgregarDiccIdentificadores.UseVisualStyleBackColor = true;
            this.bAgregarDiccIdentificadores.Click += new System.EventHandler(this.bAgregarDiccIdentificadores_Click);
            // 
            // bCerrar
            // 
            this.bCerrar.ForeColor = System.Drawing.Color.Black;
            this.bCerrar.Location = new System.Drawing.Point(483, 8);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(126, 32);
            this.bCerrar.TabIndex = 7;
            this.bCerrar.Text = "Cerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // fDiccionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(651, 669);
            this.ControlBox = false;
            this.Controls.Add(this.bCerrar);
            this.Controls.Add(this.gbDiccIdentificadores);
            this.Controls.Add(this.gbDiccReservado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fDiccionario";
            this.Text = "Diccionario Reservado y de Identificadores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiccReservado)).EndInit();
            this.gbDiccReservado.ResumeLayout(false);
            this.gbDiccIdentificadores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiccIdentificadores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bAgregarDiccRes;
        private System.Windows.Forms.Button bCargarDiccRes;
        public System.Windows.Forms.DataGridView dgvDiccReservado;
        private System.Windows.Forms.GroupBox gbDiccReservado;
        private System.Windows.Forms.GroupBox gbDiccIdentificadores;
        public System.Windows.Forms.DataGridView dgvDiccIdentificadores;
        private System.Windows.Forms.Button bCargarDiccIdentificadores;
        private System.Windows.Forms.Button bAgregarDiccIdentificadores;
        public System.Windows.Forms.DataGridViewTextBoxColumn colLexema;
        public System.Windows.Forms.DataGridViewTextBoxColumn colComponenteLexico;
        public System.Windows.Forms.DataGridViewTextBoxColumn colPatron;
        private System.Windows.Forms.Button bGuardarDiccRes;
        private System.Windows.Forms.Button bGuardarDiccIdentificadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button bInicialDiccIden;
        private System.Windows.Forms.Button bInicialDiccRes;
        private System.Windows.Forms.Button bCerrar;
    }
}