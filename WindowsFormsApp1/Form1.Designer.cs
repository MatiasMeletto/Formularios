
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtboxNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtboxApe = new System.Windows.Forms.TextBox();
            this.lblApe = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblNac = new System.Windows.Forms.Label();
            this.txtboxAlt = new System.Windows.Forms.TextBox();
            this.lblAlt = new System.Windows.Forms.Label();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.txtboxPuesto = new System.Windows.Forms.TextBox();
            this.VistaDeLista = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSumar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VistaDeLista)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(713, 415);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Guardar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtboxNom
            // 
            this.txtboxNom.Location = new System.Drawing.Point(26, 54);
            this.txtboxNom.Name = "txtboxNom";
            this.txtboxNom.Size = new System.Drawing.Size(200, 20);
            this.txtboxNom.TabIndex = 1;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(23, 38);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(47, 13);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = "Nombre:";
            // 
            // txtboxApe
            // 
            this.txtboxApe.Location = new System.Drawing.Point(26, 111);
            this.txtboxApe.Name = "txtboxApe";
            this.txtboxApe.Size = new System.Drawing.Size(200, 20);
            this.txtboxApe.TabIndex = 3;
            // 
            // lblApe
            // 
            this.lblApe.AutoSize = true;
            this.lblApe.Location = new System.Drawing.Point(26, 92);
            this.lblApe.Name = "lblApe";
            this.lblApe.Size = new System.Drawing.Size(47, 13);
            this.lblApe.TabIndex = 4;
            this.lblApe.Text = "Apellido:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(26, 170);
            this.dateTimePicker1.MaxDate = new System.DateTime(2022, 4, 27, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.Value = new System.DateTime(2022, 4, 27, 0, 0, 0, 0);
            // 
            // lblNac
            // 
            this.lblNac.AutoSize = true;
            this.lblNac.Location = new System.Drawing.Point(26, 148);
            this.lblNac.Name = "lblNac";
            this.lblNac.Size = new System.Drawing.Size(109, 13);
            this.lblNac.TabIndex = 6;
            this.lblNac.Text = "Fecha de nacimiento:";
            // 
            // txtboxAlt
            // 
            this.txtboxAlt.Location = new System.Drawing.Point(23, 228);
            this.txtboxAlt.Name = "txtboxAlt";
            this.txtboxAlt.Size = new System.Drawing.Size(203, 20);
            this.txtboxAlt.TabIndex = 7;
            // 
            // lblAlt
            // 
            this.lblAlt.AutoSize = true;
            this.lblAlt.Location = new System.Drawing.Point(23, 209);
            this.lblAlt.Name = "lblAlt";
            this.lblAlt.Size = new System.Drawing.Size(37, 13);
            this.lblAlt.TabIndex = 8;
            this.lblAlt.Text = "Altura:";
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Location = new System.Drawing.Point(23, 267);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(43, 13);
            this.lblPuesto.TabIndex = 10;
            this.lblPuesto.Text = "Puesto:";
            // 
            // txtboxPuesto
            // 
            this.txtboxPuesto.Location = new System.Drawing.Point(23, 286);
            this.txtboxPuesto.Name = "txtboxPuesto";
            this.txtboxPuesto.Size = new System.Drawing.Size(203, 20);
            this.txtboxPuesto.TabIndex = 9;
            // 
            // VistaDeLista
            // 
            this.VistaDeLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VistaDeLista.Location = new System.Drawing.Point(322, 38);
            this.VistaDeLista.Name = "VistaDeLista";
            this.VistaDeLista.Size = new System.Drawing.Size(466, 268);
            this.VistaDeLista.TabIndex = 11;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(623, 415);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSumar
            // 
            this.btnSumar.Location = new System.Drawing.Point(12, 414);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(76, 23);
            this.btnSumar.TabIndex = 13;
            this.btnSumar.Text = "Nuevo";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(713, 313);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.VistaDeLista);
            this.Controls.Add(this.lblPuesto);
            this.Controls.Add(this.txtboxPuesto);
            this.Controls.Add(this.lblAlt);
            this.Controls.Add(this.txtboxAlt);
            this.Controls.Add(this.lblNac);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblApe);
            this.Controls.Add(this.txtboxApe);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.txtboxNom);
            this.Controls.Add(this.btnAceptar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.VistaDeLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtboxNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtboxApe;
        private System.Windows.Forms.Label lblApe;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblNac;
        private System.Windows.Forms.TextBox txtboxAlt;
        private System.Windows.Forms.Label lblAlt;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.TextBox txtboxPuesto;
        private System.Windows.Forms.DataGridView VistaDeLista;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Button btnEliminar;
    }
}

