namespace Presentacion
{
    partial class Frm_Backup
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnAbrirCarpeta = new System.Windows.Forms.Button();
            this.LblUltimaCopia = new System.Windows.Forms.Label();
            this.BtnCopiaSeguridad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_ActualizarLista = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnCargarCopia = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LBCopiasAnteriores = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnAbrirCarpeta);
            this.panel1.Controls.Add(this.LblUltimaCopia);
            this.panel1.Controls.Add(this.BtnCopiaSeguridad);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 171);
            this.panel1.TabIndex = 0;
            // 
            // BtnAbrirCarpeta
            // 
            this.BtnAbrirCarpeta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnAbrirCarpeta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAbrirCarpeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbrirCarpeta.Location = new System.Drawing.Point(334, 64);
            this.BtnAbrirCarpeta.Name = "BtnAbrirCarpeta";
            this.BtnAbrirCarpeta.Size = new System.Drawing.Size(131, 30);
            this.BtnAbrirCarpeta.TabIndex = 3;
            this.BtnAbrirCarpeta.Text = "Ver Archivos";
            this.BtnAbrirCarpeta.UseVisualStyleBackColor = false;
            this.BtnAbrirCarpeta.Click += new System.EventHandler(this.BtnAbrirCarpeta_Click);
            // 
            // LblUltimaCopia
            // 
            this.LblUltimaCopia.AutoSize = true;
            this.LblUltimaCopia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUltimaCopia.Location = new System.Drawing.Point(180, 117);
            this.LblUltimaCopia.Name = "LblUltimaCopia";
            this.LblUltimaCopia.Size = new System.Drawing.Size(103, 20);
            this.LblUltimaCopia.TabIndex = 2;
            this.LblUltimaCopia.Text = "Última Copia:";
            // 
            // BtnCopiaSeguridad
            // 
            this.BtnCopiaSeguridad.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnCopiaSeguridad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCopiaSeguridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCopiaSeguridad.Location = new System.Drawing.Point(197, 64);
            this.BtnCopiaSeguridad.Name = "BtnCopiaSeguridad";
            this.BtnCopiaSeguridad.Size = new System.Drawing.Size(131, 30);
            this.BtnCopiaSeguridad.TabIndex = 1;
            this.BtnCopiaSeguridad.Text = "Hacer Copia";
            this.BtnCopiaSeguridad.UseVisualStyleBackColor = false;
            this.BtnCopiaSeguridad.Click += new System.EventHandler(this.BtnCopiaSeguridad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Realizar Copia de Seguridad";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Khaki;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Btn_ActualizarLista);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.BtnCargarCopia);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.LBCopiasAnteriores);
            this.panel2.Location = new System.Drawing.Point(12, 189);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(674, 313);
            this.panel2.TabIndex = 1;
            // 
            // Btn_ActualizarLista
            // 
            this.Btn_ActualizarLista.BackColor = System.Drawing.Color.White;
            this.Btn_ActualizarLista.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_ActualizarLista.Image = global::Presentacion.Properties.Resources.update_24px;
            this.Btn_ActualizarLista.Location = new System.Drawing.Point(172, 254);
            this.Btn_ActualizarLista.Name = "Btn_ActualizarLista";
            this.Btn_ActualizarLista.Size = new System.Drawing.Size(44, 31);
            this.Btn_ActualizarLista.TabIndex = 4;
            this.Btn_ActualizarLista.UseVisualStyleBackColor = false;
            this.Btn_ActualizarLista.Click += new System.EventHandler(this.Btn_ActualizarLista_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Últimas copias realizadas:";
            // 
            // BtnCargarCopia
            // 
            this.BtnCargarCopia.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnCargarCopia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCargarCopia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCargarCopia.Location = new System.Drawing.Point(222, 254);
            this.BtnCargarCopia.Name = "BtnCargarCopia";
            this.BtnCargarCopia.Size = new System.Drawing.Size(241, 31);
            this.BtnCargarCopia.TabIndex = 2;
            this.BtnCargarCopia.Text = "Cargar Copia Seleccionada";
            this.BtnCargarCopia.UseVisualStyleBackColor = false;
            this.BtnCargarCopia.Click += new System.EventHandler(this.BtnCargarCopia_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(195, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cargar Copia de Seguridad";
            // 
            // LBCopiasAnteriores
            // 
            this.LBCopiasAnteriores.FormattingEnabled = true;
            this.LBCopiasAnteriores.Location = new System.Drawing.Point(62, 75);
            this.LBCopiasAnteriores.Name = "LBCopiasAnteriores";
            this.LBCopiasAnteriores.Size = new System.Drawing.Size(545, 173);
            this.LBCopiasAnteriores.TabIndex = 0;
            // 
            // Frm_Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 514);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Backup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Backup";
            this.Load += new System.EventHandler(this.Frm_Backup_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblUltimaCopia;
        private System.Windows.Forms.Button BtnCopiaSeguridad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox LBCopiasAnteriores;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnCargarCopia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAbrirCarpeta;
        private System.Windows.Forms.Button Btn_ActualizarLista;
    }
}