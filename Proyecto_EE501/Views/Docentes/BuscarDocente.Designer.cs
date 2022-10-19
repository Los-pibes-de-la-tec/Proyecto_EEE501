namespace EjemploLibreriaForms.Docentes
{
    partial class BuscarDocente
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
            this.tabPageDetalleDocente = new System.Windows.Forms.TabPage();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.txt_dEmail = new System.Windows.Forms.TextBox();
            this.txt_dTelefono = new System.Windows.Forms.TextBox();
            this.txt_dCuit = new System.Windows.Forms.TextBox();
            this.txt_dApellido = new System.Windows.Forms.TextBox();
            this.txt_dNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tabPageListaDocentes = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Formacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciclo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Caracterizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_lGrupo = new System.Windows.Forms.ComboBox();
            this.txt_lTelefono = new System.Windows.Forms.TextBox();
            this.txt_IDNI = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_lApellido = new System.Windows.Forms.TextBox();
            this.txt_lNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageDetalleDocente.SuspendLayout();
            this.tabPageListaDocentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageDetalleDocente
            // 
            this.tabPageDetalleDocente.Controls.Add(this.btnCancel);
            this.tabPageDetalleDocente.Controls.Add(this.btnSave);
            this.tabPageDetalleDocente.Controls.Add(this.materialDivider2);
            this.tabPageDetalleDocente.Controls.Add(this.txt_dEmail);
            this.tabPageDetalleDocente.Controls.Add(this.txt_dTelefono);
            this.tabPageDetalleDocente.Controls.Add(this.txt_dCuit);
            this.tabPageDetalleDocente.Controls.Add(this.txt_dApellido);
            this.tabPageDetalleDocente.Controls.Add(this.txt_dNombre);
            this.tabPageDetalleDocente.Controls.Add(this.label6);
            this.tabPageDetalleDocente.Controls.Add(this.materialLabel1);
            this.tabPageDetalleDocente.Controls.Add(this.label10);
            this.tabPageDetalleDocente.Controls.Add(this.label12);
            this.tabPageDetalleDocente.Controls.Add(this.label13);
            this.tabPageDetalleDocente.Controls.Add(this.label14);
            this.tabPageDetalleDocente.Location = new System.Drawing.Point(4, 25);
            this.tabPageDetalleDocente.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageDetalleDocente.Name = "tabPageDetalleDocente";
            this.tabPageDetalleDocente.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageDetalleDocente.Size = new System.Drawing.Size(1021, 437);
            this.tabPageDetalleDocente.TabIndex = 1;
            this.tabPageDetalleDocente.Text = "Detalle Docente";
            this.tabPageDetalleDocente.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(508, 388);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(183, 44);
            this.btnCancel.TabIndex = 325;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(311, 388);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(183, 44);
            this.btnSave.TabIndex = 324;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(1, 372);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(1018, 1);
            this.materialDivider2.TabIndex = 323;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // txt_dEmail
            // 
            this.txt_dEmail.Location = new System.Drawing.Point(311, 232);
            this.txt_dEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txt_dEmail.Name = "txt_dEmail";
            this.txt_dEmail.Size = new System.Drawing.Size(132, 22);
            this.txt_dEmail.TabIndex = 310;
            // 
            // txt_dTelefono
            // 
            this.txt_dTelefono.Location = new System.Drawing.Point(628, 179);
            this.txt_dTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txt_dTelefono.Name = "txt_dTelefono";
            this.txt_dTelefono.Size = new System.Drawing.Size(132, 22);
            this.txt_dTelefono.TabIndex = 307;
            // 
            // txt_dCuit
            // 
            this.txt_dCuit.Location = new System.Drawing.Point(311, 178);
            this.txt_dCuit.Margin = new System.Windows.Forms.Padding(4);
            this.txt_dCuit.Name = "txt_dCuit";
            this.txt_dCuit.Size = new System.Drawing.Size(132, 22);
            this.txt_dCuit.TabIndex = 271;
            // 
            // txt_dApellido
            // 
            this.txt_dApellido.Location = new System.Drawing.Point(628, 126);
            this.txt_dApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txt_dApellido.Name = "txt_dApellido";
            this.txt_dApellido.Size = new System.Drawing.Size(132, 22);
            this.txt_dApellido.TabIndex = 269;
            // 
            // txt_dNombre
            // 
            this.txt_dNombre.Location = new System.Drawing.Point(311, 126);
            this.txt_dNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_dNombre.Name = "txt_dNombre";
            this.txt_dNombre.Size = new System.Drawing.Size(132, 22);
            this.txt_dNombre.TabIndex = 267;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label6.Location = new System.Drawing.Point(204, 237);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 309;
            this.label6.Text = "Email";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(72, 51);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(137, 19);
            this.materialLabel1.TabIndex = 283;
            this.materialLabel1.Text = "Datos del Docente:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label10.Location = new System.Drawing.Point(538, 184);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 16);
            this.label10.TabIndex = 275;
            this.label10.Text = "Telefono";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label12.Location = new System.Drawing.Point(204, 185);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 16);
            this.label12.TabIndex = 272;
            this.label12.Text = "CUIT";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label13.Location = new System.Drawing.Point(538, 133);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 16);
            this.label13.TabIndex = 270;
            this.label13.Text = "Apellido";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label14.Location = new System.Drawing.Point(204, 133);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 16);
            this.label14.TabIndex = 268;
            this.label14.Text = "Nombre";
            // 
            // tabPageListaDocentes
            // 
            this.tabPageListaDocentes.Controls.Add(this.dataGridView1);
            this.tabPageListaDocentes.Controls.Add(this.label7);
            this.tabPageListaDocentes.Controls.Add(this.cmb_lGrupo);
            this.tabPageListaDocentes.Controls.Add(this.txt_lTelefono);
            this.tabPageListaDocentes.Controls.Add(this.txt_IDNI);
            this.tabPageListaDocentes.Controls.Add(this.textBox1);
            this.tabPageListaDocentes.Controls.Add(this.txt_lApellido);
            this.tabPageListaDocentes.Controls.Add(this.txt_lNombre);
            this.tabPageListaDocentes.Controls.Add(this.label5);
            this.tabPageListaDocentes.Controls.Add(this.btnDelete);
            this.tabPageListaDocentes.Controls.Add(this.btnEdit);
            this.tabPageListaDocentes.Controls.Add(this.btnAddNew);
            this.tabPageListaDocentes.Controls.Add(this.label4);
            this.tabPageListaDocentes.Controls.Add(this.label3);
            this.tabPageListaDocentes.Controls.Add(this.label2);
            this.tabPageListaDocentes.Controls.Add(this.label1);
            this.tabPageListaDocentes.Location = new System.Drawing.Point(4, 25);
            this.tabPageListaDocentes.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageListaDocentes.Name = "tabPageListaDocentes";
            this.tabPageListaDocentes.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageListaDocentes.Size = new System.Drawing.Size(1021, 437);
            this.tabPageListaDocentes.TabIndex = 0;
            this.tabPageListaDocentes.Text = "Lista Docentes";
            this.tabPageListaDocentes.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.Nivel,
            this.DNI,
            this.Formacion,
            this.Ciclo,
            this.Caracterizacion,
            this.Grupo});
            this.dataGridView1.Location = new System.Drawing.Point(16, 126);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(834, 296);
            this.dataGridView1.TabIndex = 41;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Visible = false;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.Visible = false;
            // 
            // Nivel
            // 
            this.Nivel.HeaderText = "Nivel";
            this.Nivel.Name = "Nivel";
            this.Nivel.Visible = false;
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.Visible = false;
            // 
            // Formacion
            // 
            this.Formacion.HeaderText = "Formación";
            this.Formacion.Name = "Formacion";
            this.Formacion.Visible = false;
            // 
            // Ciclo
            // 
            this.Ciclo.HeaderText = "Ciclo";
            this.Ciclo.Name = "Ciclo";
            this.Ciclo.Visible = false;
            // 
            // Caracterizacion
            // 
            this.Caracterizacion.HeaderText = "Caracterización";
            this.Caracterizacion.Name = "Caracterizacion";
            this.Caracterizacion.Visible = false;
            // 
            // Grupo
            // 
            this.Grupo.HeaderText = "Grupo";
            this.Grupo.Name = "Grupo";
            this.Grupo.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label7.Location = new System.Drawing.Point(571, 78);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 40;
            this.label7.Text = "Grupo";
            // 
            // cmb_lGrupo
            // 
            this.cmb_lGrupo.FormattingEnabled = true;
            this.cmb_lGrupo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmb_lGrupo.Location = new System.Drawing.Point(673, 70);
            this.cmb_lGrupo.Margin = new System.Windows.Forms.Padding(5);
            this.cmb_lGrupo.Name = "cmb_lGrupo";
            this.cmb_lGrupo.Size = new System.Drawing.Size(160, 24);
            this.cmb_lGrupo.TabIndex = 39;
            // 
            // txt_lTelefono
            // 
            this.txt_lTelefono.Location = new System.Drawing.Point(374, 72);
            this.txt_lTelefono.Margin = new System.Windows.Forms.Padding(5);
            this.txt_lTelefono.Name = "txt_lTelefono";
            this.txt_lTelefono.Size = new System.Drawing.Size(160, 22);
            this.txt_lTelefono.TabIndex = 38;
            // 
            // txt_IDNI
            // 
            this.txt_IDNI.Location = new System.Drawing.Point(96, 72);
            this.txt_IDNI.Margin = new System.Windows.Forms.Padding(5);
            this.txt_IDNI.Name = "txt_IDNI";
            this.txt_IDNI.Size = new System.Drawing.Size(160, 22);
            this.txt_IDNI.TabIndex = 37;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(673, 24);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 22);
            this.textBox1.TabIndex = 36;
            // 
            // txt_lApellido
            // 
            this.txt_lApellido.Location = new System.Drawing.Point(374, 24);
            this.txt_lApellido.Margin = new System.Windows.Forms.Padding(5);
            this.txt_lApellido.Name = "txt_lApellido";
            this.txt_lApellido.Size = new System.Drawing.Size(160, 22);
            this.txt_lApellido.TabIndex = 19;
            // 
            // txt_lNombre
            // 
            this.txt_lNombre.Location = new System.Drawing.Point(96, 24);
            this.txt_lNombre.Margin = new System.Windows.Forms.Padding(5);
            this.txt_lNombre.Name = "txt_lNombre";
            this.txt_lNombre.Size = new System.Drawing.Size(160, 22);
            this.txt_lNombre.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.Location = new System.Drawing.Point(571, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 35;
            this.label5.Text = "Email";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(860, 259);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(132, 37);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(860, 189);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(132, 37);
            this.btnEdit.TabIndex = 28;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNew.Location = new System.Drawing.Point(860, 126);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(132, 37);
            this.btnAddNew.TabIndex = 27;
            this.btnAddNew.Text = "Agregar nuevo";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.Location = new System.Drawing.Point(288, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(13, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "CUIT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(288, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nombre";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageListaDocentes);
            this.tabControl1.Controls.Add(this.tabPageDetalleDocente);
            this.tabControl1.Location = new System.Drawing.Point(1, 64);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1029, 466);
            this.tabControl1.TabIndex = 1;
            // 
            // BuscarDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 531);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BuscarDocente";
            this.Sizable = false;
            this.Text = "Docentes";
            this.Load += new System.EventHandler(this.BuscarDocente_Load);
            this.tabPageDetalleDocente.ResumeLayout(false);
            this.tabPageDetalleDocente.PerformLayout();
            this.tabPageListaDocentes.ResumeLayout(false);
            this.tabPageListaDocentes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageDetalleDocente;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private System.Windows.Forms.TextBox txt_dEmail;
        private System.Windows.Forms.TextBox txt_dTelefono;
        private System.Windows.Forms.TextBox txt_dCuit;
        private System.Windows.Forms.TextBox txt_dApellido;
        private System.Windows.Forms.TextBox txt_dNombre;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage tabPageListaDocentes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Formacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciclo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caracterizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grupo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_lGrupo;
        private System.Windows.Forms.TextBox txt_lTelefono;
        private System.Windows.Forms.TextBox txt_IDNI;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txt_lApellido;
        private System.Windows.Forms.TextBox txt_lNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;


    }
}