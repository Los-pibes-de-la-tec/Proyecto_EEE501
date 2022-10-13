namespace EjemploLibreriaForms
{
    partial class DocumentosHome
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageListaDocumentos = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPageAgregarDocumento = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CUIT = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.TipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuitAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPageListaDocumentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPageAgregarDocumento.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageListaDocumentos);
            this.tabControl1.Controls.Add(this.tabPageAgregarDocumento);
            this.tabControl1.Location = new System.Drawing.Point(1, 64);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1019, 466);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageListaDocumentos
            // 
            this.tabPageListaDocumentos.Controls.Add(this.btnDelete);
            this.tabPageListaDocumentos.Controls.Add(this.btnEdit);
            this.tabPageListaDocumentos.Controls.Add(this.btnAddNew);
            this.tabPageListaDocumentos.Controls.Add(this.dataGridView1);
            this.tabPageListaDocumentos.Location = new System.Drawing.Point(4, 22);
            this.tabPageListaDocumentos.Name = "tabPageListaDocumentos";
            this.tabPageListaDocumentos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageListaDocumentos.Size = new System.Drawing.Size(1011, 440);
            this.tabPageListaDocumentos.TabIndex = 0;
            this.tabPageListaDocumentos.Text = "Lista Documentos";
            this.tabPageListaDocumentos.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(858, 166);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(132, 37);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "Eliminar Documento";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(858, 105);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(132, 37);
            this.btnEdit.TabIndex = 28;
            this.btnEdit.Text = "Ver Documento";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNew.Location = new System.Drawing.Point(858, 45);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(132, 37);
            this.btnAddNew.TabIndex = 27;
            this.btnAddNew.Text = "Nuevo Documento";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoDoc,
            this.NombreDoc,
            this.CuitAlumno});
            this.dataGridView1.Location = new System.Drawing.Point(16, 45);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(824, 376);
            this.dataGridView1.TabIndex = 16;
            // 
            // tabPageAgregarDocumento
            // 
            this.tabPageAgregarDocumento.Controls.Add(this.checkBox1);
            this.tabPageAgregarDocumento.Controls.Add(this.label2);
            this.tabPageAgregarDocumento.Controls.Add(this.richTextBox1);
            this.tabPageAgregarDocumento.Controls.Add(this.textBox2);
            this.tabPageAgregarDocumento.Controls.Add(this.comboBox6);
            this.tabPageAgregarDocumento.Controls.Add(this.label1);
            this.tabPageAgregarDocumento.Controls.Add(this.CUIT);
            this.tabPageAgregarDocumento.Controls.Add(this.label12);
            this.tabPageAgregarDocumento.Controls.Add(this.textBox1);
            this.tabPageAgregarDocumento.Controls.Add(this.btnCancel);
            this.tabPageAgregarDocumento.Controls.Add(this.btnSave);
            this.tabPageAgregarDocumento.Controls.Add(this.materialLabel1);
            this.tabPageAgregarDocumento.Location = new System.Drawing.Point(4, 22);
            this.tabPageAgregarDocumento.Name = "tabPageAgregarDocumento";
            this.tabPageAgregarDocumento.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAgregarDocumento.Size = new System.Drawing.Size(1011, 440);
            this.tabPageAgregarDocumento.TabIndex = 1;
            this.tabPageAgregarDocumento.Text = "Nuevo Documento";
            this.tabPageAgregarDocumento.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.richTextBox1.Location = new System.Drawing.Point(32, 171);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(953, 166);
            this.richTextBox1.TabIndex = 323;
            this.richTextBox1.Text = "";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(527, 105);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(160, 20);
            this.textBox2.TabIndex = 322;
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "Actas",
            "Informes",
            "Certificados",
            "Titulaciones"});
            this.comboBox6.Location = new System.Drawing.Point(222, 53);
            this.comboBox6.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(160, 21);
            this.comboBox6.TabIndex = 321;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(87, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 320;
            this.label1.Text = "Tipo de documento";
            // 
            // CUIT
            // 
            this.CUIT.AutoSize = true;
            this.CUIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.CUIT.Location = new System.Drawing.Point(421, 109);
            this.CUIT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CUIT.Name = "CUIT";
            this.CUIT.Size = new System.Drawing.Size(87, 16);
            this.CUIT.TabIndex = 318;
            this.CUIT.Text = "CUIT Alumno";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label12.Location = new System.Drawing.Point(87, 109);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 16);
            this.label12.TabIndex = 309;
            this.label12.Text = "Nombre Documento";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(222, 106);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 20);
            this.textBox1.TabIndex = 308;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(514, 355);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(183, 44);
            this.btnCancel.TabIndex = 307;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(325, 355);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(183, 44);
            this.btnSave.TabIndex = 306;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(36, 3);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(153, 19);
            this.materialLabel1.TabIndex = 283;
            this.materialLabel1.Text = "Datos del documento";
            // 
            // TipoDoc
            // 
            this.TipoDoc.HeaderText = "Tipo Documento";
            this.TipoDoc.Name = "TipoDoc";
            // 
            // NombreDoc
            // 
            this.NombreDoc.HeaderText = "Nombre Documento";
            this.NombreDoc.Name = "NombreDoc";
            // 
            // CuitAlumno
            // 
            this.CuitAlumno.HeaderText = "CUIT del alumno";
            this.CuitAlumno.Name = "CuitAlumno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(29, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 16);
            this.label2.TabIndex = 324;
            this.label2.Text = "Texto del documento:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(424, 58);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(144, 17);
            this.checkBox1.TabIndex = 325;
            this.checkBox1.Text = "Es referente a un alumno";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // DocumentosHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 497);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Name = "DocumentosHome";
            this.Text = "DocumentosHome";
            this.tabControl1.ResumeLayout(false);
            this.tabPageListaDocumentos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPageAgregarDocumento.ResumeLayout(false);
            this.tabPageAgregarDocumento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageListaDocumentos;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPageAgregarDocumento;
        private System.Windows.Forms.Label CUIT;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuitAlumno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}