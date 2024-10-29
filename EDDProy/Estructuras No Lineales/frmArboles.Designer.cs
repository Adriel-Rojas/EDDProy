
namespace EDDemo.Estructuras_No_Lineales
{
    partial class frmArboles
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
            this.txtDato = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.txtArbol = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCrearArbol = new System.Windows.Forms.Button();
            this.btnRecorrer = new System.Windows.Forms.Button();
            this.txtNodos = new System.Windows.Forms.NumericUpDown();
            this.lblPreOrden = new System.Windows.Forms.Label();
            this.lblInOrdern = new System.Windows.Forms.Label();
            this.lblPostOrden = new System.Windows.Forms.Label();
            this.lblRecorrerPreOrden = new System.Windows.Forms.Label();
            this.lblRecorrerInOrden = new System.Windows.Forms.Label();
            this.lblRecorrerPostOrden = new System.Windows.Forms.Label();
            this.btnGrafica = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtNodos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDato
            // 
            this.txtDato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDato.Location = new System.Drawing.Point(49, 44);
            this.txtDato.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDato.Multiline = true;
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(68, 29);
            this.txtDato.TabIndex = 0;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(168, 41);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(83, 29);
            this.btnInsertar.TabIndex = 1;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtArbol
            // 
            this.txtArbol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArbol.Location = new System.Drawing.Point(3, 327);
            this.txtArbol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtArbol.Multiline = true;
            this.txtArbol.Name = "txtArbol";
            this.txtArbol.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtArbol.Size = new System.Drawing.Size(850, 309);
            this.txtArbol.TabIndex = 2;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(306, 41);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(83, 29);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCrearArbol
            // 
            this.btnCrearArbol.Location = new System.Drawing.Point(168, 102);
            this.btnCrearArbol.Name = "btnCrearArbol";
            this.btnCrearArbol.Size = new System.Drawing.Size(83, 29);
            this.btnCrearArbol.TabIndex = 3;
            this.btnCrearArbol.Text = "Crear Arbol";
            this.btnCrearArbol.UseVisualStyleBackColor = true;
            this.btnCrearArbol.Click += new System.EventHandler(this.btnCrearArbol_Click);
            // 
            // btnRecorrer
            // 
            this.btnRecorrer.Location = new System.Drawing.Point(171, 209);
            this.btnRecorrer.Name = "btnRecorrer";
            this.btnRecorrer.Size = new System.Drawing.Size(83, 29);
            this.btnRecorrer.TabIndex = 4;
            this.btnRecorrer.Text = "Recorrer";
            this.btnRecorrer.UseVisualStyleBackColor = true;
            this.btnRecorrer.Click += new System.EventHandler(this.btnRecorrer_Click);
            // 
            // txtNodos
            // 
            this.txtNodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNodos.Location = new System.Drawing.Point(49, 106);
            this.txtNodos.Name = "txtNodos";
            this.txtNodos.Size = new System.Drawing.Size(68, 24);
            this.txtNodos.TabIndex = 6;
            this.txtNodos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblPreOrden
            // 
            this.lblPreOrden.AutoSize = true;
            this.lblPreOrden.Location = new System.Drawing.Point(287, 209);
            this.lblPreOrden.Name = "lblPreOrden";
            this.lblPreOrden.Size = new System.Drawing.Size(68, 16);
            this.lblPreOrden.TabIndex = 7;
            this.lblPreOrden.Text = "PreOrden:";
            // 
            // lblInOrdern
            // 
            this.lblInOrdern.AutoSize = true;
            this.lblInOrdern.Location = new System.Drawing.Point(287, 249);
            this.lblInOrdern.Name = "lblInOrdern";
            this.lblInOrdern.Size = new System.Drawing.Size(57, 16);
            this.lblInOrdern.TabIndex = 8;
            this.lblInOrdern.Text = "InOrden:";
            // 
            // lblPostOrden
            // 
            this.lblPostOrden.AutoSize = true;
            this.lblPostOrden.Location = new System.Drawing.Point(287, 291);
            this.lblPostOrden.Name = "lblPostOrden";
            this.lblPostOrden.Size = new System.Drawing.Size(74, 16);
            this.lblPostOrden.TabIndex = 9;
            this.lblPostOrden.Text = "PostOrden:";
            // 
            // lblRecorrerPreOrden
            // 
            this.lblRecorrerPreOrden.AutoSize = true;
            this.lblRecorrerPreOrden.Location = new System.Drawing.Point(373, 209);
            this.lblRecorrerPreOrden.Name = "lblRecorrerPreOrden";
            this.lblRecorrerPreOrden.Size = new System.Drawing.Size(65, 16);
            this.lblRecorrerPreOrden.TabIndex = 10;
            this.lblRecorrerPreOrden.Text = "PreOrden";
            // 
            // lblRecorrerInOrden
            // 
            this.lblRecorrerInOrden.AutoSize = true;
            this.lblRecorrerInOrden.Location = new System.Drawing.Point(373, 249);
            this.lblRecorrerInOrden.Name = "lblRecorrerInOrden";
            this.lblRecorrerInOrden.Size = new System.Drawing.Size(54, 16);
            this.lblRecorrerInOrden.TabIndex = 11;
            this.lblRecorrerInOrden.Text = "InOrden";
            // 
            // lblRecorrerPostOrden
            // 
            this.lblRecorrerPostOrden.AutoSize = true;
            this.lblRecorrerPostOrden.Location = new System.Drawing.Point(373, 291);
            this.lblRecorrerPostOrden.Name = "lblRecorrerPostOrden";
            this.lblRecorrerPostOrden.Size = new System.Drawing.Size(68, 16);
            this.lblRecorrerPostOrden.TabIndex = 12;
            this.lblRecorrerPostOrden.Text = "PosOrden";
            // 
            // btnGrafica
            // 
            this.btnGrafica.Location = new System.Drawing.Point(441, 41);
            this.btnGrafica.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrafica.Name = "btnGrafica";
            this.btnGrafica.Size = new System.Drawing.Size(83, 29);
            this.btnGrafica.TabIndex = 13;
            this.btnGrafica.Text = "Grafica";
            this.btnGrafica.UseVisualStyleBackColor = true;
            this.btnGrafica.Click += new System.EventHandler(this.btnGrafica_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(567, 41);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(83, 29);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(564, 108);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(79, 18);
            this.lblResultado.TabIndex = 15;
            this.lblResultado.Text = "Reultado...";
            // 
            // frmArboles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 647);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnGrafica);
            this.Controls.Add(this.lblRecorrerPostOrden);
            this.Controls.Add(this.lblRecorrerInOrden);
            this.Controls.Add(this.lblRecorrerPreOrden);
            this.Controls.Add(this.lblPostOrden);
            this.Controls.Add(this.lblInOrdern);
            this.Controls.Add(this.lblPreOrden);
            this.Controls.Add(this.txtNodos);
            this.Controls.Add(this.btnRecorrer);
            this.Controls.Add(this.btnCrearArbol);
            this.Controls.Add(this.txtArbol);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txtDato);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmArboles";
            this.Text = "frmArboles";
            ((System.ComponentModel.ISupportInitialize)(this.txtNodos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox txtArbol;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCrearArbol;
        private System.Windows.Forms.Button btnRecorrer;
        private System.Windows.Forms.NumericUpDown txtNodos;
        private System.Windows.Forms.Label lblPreOrden;
        private System.Windows.Forms.Label lblInOrdern;
        private System.Windows.Forms.Label lblPostOrden;
        private System.Windows.Forms.Label lblRecorrerPreOrden;
        private System.Windows.Forms.Label lblRecorrerInOrden;
        private System.Windows.Forms.Label lblRecorrerPostOrden;
        private System.Windows.Forms.Button btnGrafica;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblResultado;
    }
}