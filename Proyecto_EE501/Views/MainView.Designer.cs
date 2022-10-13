
namespace EjemploLibreriaForms.Views
{
    partial class MainView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_domicilio = new System.Windows.Forms.Button();
            this.btnGrupos = new System.Windows.Forms.Button();
            this.btnDocentes = new System.Windows.Forms.Button();
            this.btnAlumnos = new System.Windows.Forms.Button();
            this.btn_docs = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_docs);
            this.panel1.Controls.Add(this.btn_domicilio);
            this.panel1.Controls.Add(this.btnGrupos);
            this.panel1.Controls.Add(this.btnDocentes);
            this.panel1.Controls.Add(this.btnAlumnos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 565);
            this.panel1.TabIndex = 0;
            // 
            // btn_domicilio
            // 
            this.btn_domicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_domicilio.Location = new System.Drawing.Point(0, 72);
            this.btn_domicilio.Name = "btn_domicilio";
            this.btn_domicilio.Size = new System.Drawing.Size(200, 37);
            this.btn_domicilio.TabIndex = 3;
            this.btn_domicilio.Text = "Domicilio";
            this.btn_domicilio.UseVisualStyleBackColor = true;
            this.btn_domicilio.Click += new System.EventHandler(this.btn_domicilio_Click);
            // 
            // btnGrupos
            // 
            this.btnGrupos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrupos.Location = new System.Drawing.Point(0, 224);
            this.btnGrupos.Name = "btnGrupos";
            this.btnGrupos.Size = new System.Drawing.Size(200, 37);
            this.btnGrupos.TabIndex = 2;
            this.btnGrupos.Text = "Grupos";
            this.btnGrupos.UseVisualStyleBackColor = true;
            this.btnGrupos.Click += new System.EventHandler(this.btnGrupos_Click);
            // 
            // btnDocentes
            // 
            this.btnDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocentes.Location = new System.Drawing.Point(0, 149);
            this.btnDocentes.Name = "btnDocentes";
            this.btnDocentes.Size = new System.Drawing.Size(200, 37);
            this.btnDocentes.TabIndex = 1;
            this.btnDocentes.Text = "Docentes";
            this.btnDocentes.UseVisualStyleBackColor = true;
            this.btnDocentes.Click += new System.EventHandler(this.btnDocentes_Click);
            // 
            // btnAlumnos
            // 
            this.btnAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlumnos.Location = new System.Drawing.Point(0, 3);
            this.btnAlumnos.Name = "btnAlumnos";
            this.btnAlumnos.Size = new System.Drawing.Size(200, 37);
            this.btnAlumnos.TabIndex = 0;
            this.btnAlumnos.Text = "Alumnos";
            this.btnAlumnos.UseVisualStyleBackColor = true;
            this.btnAlumnos.Click += new System.EventHandler(this.btnAlumnos_Click);
            // 
            // btn_docs
            // 
            this.btn_docs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_docs.Location = new System.Drawing.Point(0, 291);
            this.btn_docs.Name = "btn_docs";
            this.btn_docs.Size = new System.Drawing.Size(200, 37);
            this.btn_docs.TabIndex = 4;
            this.btn_docs.Text = "Documentos";
            this.btn_docs.UseVisualStyleBackColor = true;
            this.btn_docs.Click += new System.EventHandler(this.btn_docs_Click);
            // 
            // MainView
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1213, 565);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vista Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainView_FormClosing);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAlumnos;
        private System.Windows.Forms.Button btnDocentes;
        private System.Windows.Forms.Button btnGrupos;
        private System.Windows.Forms.Button btn_domicilio;
        private System.Windows.Forms.Button btn_docs;
    }
}
