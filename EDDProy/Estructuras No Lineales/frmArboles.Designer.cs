
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
            this.btnPodar = new System.Windows.Forms.Button();
            this.lblPodar = new System.Windows.Forms.Label();
            this.btnPredecesor = new System.Windows.Forms.Button();
            this.btnSucesor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAltura = new System.Windows.Forms.Button();
            this.lblAltura = new System.Windows.Forms.Label();
            this.btnContarHojas = new System.Windows.Forms.Button();
            this.lblContarHojas = new System.Windows.Forms.Label();
            this.btnContarNodos = new System.Windows.Forms.Button();
            this.lblContarNodos = new System.Windows.Forms.Label();
            this.btnLleno = new System.Windows.Forms.Button();
            this.lblLleno = new System.Windows.Forms.Label();
            this.btnRecorridoN = new System.Windows.Forms.Button();
            this.lblRecorridoN = new System.Windows.Forms.Label();
            this.lblCompleto = new System.Windows.Forms.Label();
            this.btnCompleto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtNodos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDato
            // 
            this.txtDato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDato.Location = new System.Drawing.Point(49, 44);
            this.txtDato.Margin = new System.Windows.Forms.Padding(2);
            this.txtDato.Multiline = true;
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(68, 29);
            this.txtDato.TabIndex = 0;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(168, 41);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(2);
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
            this.txtArbol.Margin = new System.Windows.Forms.Padding(2);
            this.txtArbol.Multiline = true;
            this.txtArbol.Name = "txtArbol";
            this.txtArbol.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtArbol.Size = new System.Drawing.Size(1445, 309);
            this.txtArbol.TabIndex = 2;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(306, 41);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
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
            this.btnRecorrer.Location = new System.Drawing.Point(169, 156);
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
            this.lblPreOrden.Location = new System.Drawing.Point(285, 156);
            this.lblPreOrden.Name = "lblPreOrden";
            this.lblPreOrden.Size = new System.Drawing.Size(68, 16);
            this.lblPreOrden.TabIndex = 7;
            this.lblPreOrden.Text = "PreOrden:";
            // 
            // lblInOrdern
            // 
            this.lblInOrdern.AutoSize = true;
            this.lblInOrdern.Location = new System.Drawing.Point(285, 196);
            this.lblInOrdern.Name = "lblInOrdern";
            this.lblInOrdern.Size = new System.Drawing.Size(57, 16);
            this.lblInOrdern.TabIndex = 8;
            this.lblInOrdern.Text = "InOrden:";
            // 
            // lblPostOrden
            // 
            this.lblPostOrden.AutoSize = true;
            this.lblPostOrden.Location = new System.Drawing.Point(285, 238);
            this.lblPostOrden.Name = "lblPostOrden";
            this.lblPostOrden.Size = new System.Drawing.Size(74, 16);
            this.lblPostOrden.TabIndex = 9;
            this.lblPostOrden.Text = "PostOrden:";
            // 
            // lblRecorrerPreOrden
            // 
            this.lblRecorrerPreOrden.AutoSize = true;
            this.lblRecorrerPreOrden.Location = new System.Drawing.Point(371, 156);
            this.lblRecorrerPreOrden.Name = "lblRecorrerPreOrden";
            this.lblRecorrerPreOrden.Size = new System.Drawing.Size(74, 16);
            this.lblRecorrerPreOrden.TabIndex = 10;
            this.lblRecorrerPreOrden.Text = "PreOrden...";
            // 
            // lblRecorrerInOrden
            // 
            this.lblRecorrerInOrden.AutoSize = true;
            this.lblRecorrerInOrden.Location = new System.Drawing.Point(371, 196);
            this.lblRecorrerInOrden.Name = "lblRecorrerInOrden";
            this.lblRecorrerInOrden.Size = new System.Drawing.Size(63, 16);
            this.lblRecorrerInOrden.TabIndex = 11;
            this.lblRecorrerInOrden.Text = "InOrden...";
            // 
            // lblRecorrerPostOrden
            // 
            this.lblRecorrerPostOrden.AutoSize = true;
            this.lblRecorrerPostOrden.Location = new System.Drawing.Point(371, 238);
            this.lblRecorrerPostOrden.Name = "lblRecorrerPostOrden";
            this.lblRecorrerPostOrden.Size = new System.Drawing.Size(77, 16);
            this.lblRecorrerPostOrden.TabIndex = 12;
            this.lblRecorrerPostOrden.Text = "PosOrden...";
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
            this.btnBuscar.Location = new System.Drawing.Point(652, 41);
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
            this.lblResultado.Location = new System.Drawing.Point(758, 47);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(87, 18);
            this.lblResultado.TabIndex = 15;
            this.lblResultado.Text = "Resultado...";
            // 
            // btnPodar
            // 
            this.btnPodar.Location = new System.Drawing.Point(652, 114);
            this.btnPodar.Name = "btnPodar";
            this.btnPodar.Size = new System.Drawing.Size(83, 29);
            this.btnPodar.TabIndex = 16;
            this.btnPodar.Text = "Podar";
            this.btnPodar.UseVisualStyleBackColor = true;
            this.btnPodar.Click += new System.EventHandler(this.btnPodar_Click);
            // 
            // lblPodar
            // 
            this.lblPodar.AutoSize = true;
            this.lblPodar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPodar.Location = new System.Drawing.Point(758, 125);
            this.lblPodar.Name = "lblPodar";
            this.lblPodar.Size = new System.Drawing.Size(87, 18);
            this.lblPodar.TabIndex = 17;
            this.lblPodar.Text = "Resultado...";
            // 
            // btnPredecesor
            // 
            this.btnPredecesor.Location = new System.Drawing.Point(1078, 47);
            this.btnPredecesor.Name = "btnPredecesor";
            this.btnPredecesor.Size = new System.Drawing.Size(89, 29);
            this.btnPredecesor.TabIndex = 18;
            this.btnPredecesor.Text = "Predecesor";
            this.btnPredecesor.UseVisualStyleBackColor = true;
            this.btnPredecesor.Click += new System.EventHandler(this.btnPredecesor_Click);
            // 
            // btnSucesor
            // 
            this.btnSucesor.Location = new System.Drawing.Point(1203, 47);
            this.btnSucesor.Name = "btnSucesor";
            this.btnSucesor.Size = new System.Drawing.Size(89, 29);
            this.btnSucesor.TabIndex = 19;
            this.btnSucesor.Text = "Sucesor";
            this.btnSucesor.UseVisualStyleBackColor = true;
            this.btnSucesor.Click += new System.EventHandler(this.btnSucesor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1124, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Eliminar nodos";
            // 
            // btnAltura
            // 
            this.btnAltura.Location = new System.Drawing.Point(652, 183);
            this.btnAltura.Name = "btnAltura";
            this.btnAltura.Size = new System.Drawing.Size(83, 29);
            this.btnAltura.TabIndex = 21;
            this.btnAltura.Text = "Altura";
            this.btnAltura.UseVisualStyleBackColor = true;
            this.btnAltura.Click += new System.EventHandler(this.btnAltura_Click);
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(758, 194);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(87, 18);
            this.lblAltura.TabIndex = 22;
            this.lblAltura.Text = "Resultado...";
            // 
            // btnContarHojas
            // 
            this.btnContarHojas.Location = new System.Drawing.Point(652, 249);
            this.btnContarHojas.Name = "btnContarHojas";
            this.btnContarHojas.Size = new System.Drawing.Size(83, 44);
            this.btnContarHojas.TabIndex = 23;
            this.btnContarHojas.Text = "Contar hojas";
            this.btnContarHojas.UseVisualStyleBackColor = true;
            this.btnContarHojas.Click += new System.EventHandler(this.btnContarHojas_Click);
            // 
            // lblContarHojas
            // 
            this.lblContarHojas.AutoSize = true;
            this.lblContarHojas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContarHojas.Location = new System.Drawing.Point(758, 261);
            this.lblContarHojas.Name = "lblContarHojas";
            this.lblContarHojas.Size = new System.Drawing.Size(87, 18);
            this.lblContarHojas.TabIndex = 24;
            this.lblContarHojas.Text = "Resultado...";
            // 
            // btnContarNodos
            // 
            this.btnContarNodos.Location = new System.Drawing.Point(987, 90);
            this.btnContarNodos.Name = "btnContarNodos";
            this.btnContarNodos.Size = new System.Drawing.Size(83, 44);
            this.btnContarNodos.TabIndex = 25;
            this.btnContarNodos.Text = "Contar nodos";
            this.btnContarNodos.UseVisualStyleBackColor = true;
            this.btnContarNodos.Click += new System.EventHandler(this.btnContarNodos_Click);
            // 
            // lblContarNodos
            // 
            this.lblContarNodos.AutoSize = true;
            this.lblContarNodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContarNodos.Location = new System.Drawing.Point(1102, 102);
            this.lblContarNodos.Name = "lblContarNodos";
            this.lblContarNodos.Size = new System.Drawing.Size(87, 18);
            this.lblContarNodos.TabIndex = 26;
            this.lblContarNodos.Text = "Resultado...";
            // 
            // btnLleno
            // 
            this.btnLleno.Location = new System.Drawing.Point(987, 232);
            this.btnLleno.Name = "btnLleno";
            this.btnLleno.Size = new System.Drawing.Size(83, 29);
            this.btnLleno.TabIndex = 27;
            this.btnLleno.Text = "Es lleno?";
            this.btnLleno.UseVisualStyleBackColor = true;
            this.btnLleno.Click += new System.EventHandler(this.btnLleno_Click);
            // 
            // lblLleno
            // 
            this.lblLleno.AutoSize = true;
            this.lblLleno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLleno.Location = new System.Drawing.Point(1102, 238);
            this.lblLleno.Name = "lblLleno";
            this.lblLleno.Size = new System.Drawing.Size(87, 18);
            this.lblLleno.TabIndex = 28;
            this.lblLleno.Text = "Resultado...";
            // 
            // btnRecorridoN
            // 
            this.btnRecorridoN.Location = new System.Drawing.Point(987, 275);
            this.btnRecorridoN.Name = "btnRecorridoN";
            this.btnRecorridoN.Size = new System.Drawing.Size(96, 47);
            this.btnRecorridoN.TabIndex = 29;
            this.btnRecorridoN.Text = "Recorrido por niveles";
            this.btnRecorridoN.UseVisualStyleBackColor = true;
            this.btnRecorridoN.Click += new System.EventHandler(this.btnRecorridoN_Click);
            // 
            // lblRecorridoN
            // 
            this.lblRecorridoN.AutoSize = true;
            this.lblRecorridoN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecorridoN.Location = new System.Drawing.Point(1102, 292);
            this.lblRecorridoN.Name = "lblRecorridoN";
            this.lblRecorridoN.Size = new System.Drawing.Size(87, 18);
            this.lblRecorridoN.TabIndex = 30;
            this.lblRecorridoN.Text = "Resultado...";
            // 
            // lblCompleto
            // 
            this.lblCompleto.AutoSize = true;
            this.lblCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompleto.Location = new System.Drawing.Point(1102, 179);
            this.lblCompleto.Name = "lblCompleto";
            this.lblCompleto.Size = new System.Drawing.Size(87, 18);
            this.lblCompleto.TabIndex = 32;
            this.lblCompleto.Text = "Resultado...";
            // 
            // btnCompleto
            // 
            this.btnCompleto.Location = new System.Drawing.Point(987, 166);
            this.btnCompleto.Name = "btnCompleto";
            this.btnCompleto.Size = new System.Drawing.Size(96, 47);
            this.btnCompleto.TabIndex = 31;
            this.btnCompleto.Text = "Es completo?";
            this.btnCompleto.UseVisualStyleBackColor = true;
            this.btnCompleto.Click += new System.EventHandler(this.btnCompleto_Click);
            // 
            // frmArboles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 647);
            this.Controls.Add(this.lblCompleto);
            this.Controls.Add(this.btnCompleto);
            this.Controls.Add(this.lblRecorridoN);
            this.Controls.Add(this.btnRecorridoN);
            this.Controls.Add(this.lblLleno);
            this.Controls.Add(this.btnLleno);
            this.Controls.Add(this.lblContarNodos);
            this.Controls.Add(this.btnContarNodos);
            this.Controls.Add(this.lblContarHojas);
            this.Controls.Add(this.btnContarHojas);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.btnAltura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSucesor);
            this.Controls.Add(this.btnPredecesor);
            this.Controls.Add(this.lblPodar);
            this.Controls.Add(this.btnPodar);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button btnPodar;
        private System.Windows.Forms.Label lblPodar;
        private System.Windows.Forms.Button btnPredecesor;
        private System.Windows.Forms.Button btnSucesor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAltura;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Button btnContarHojas;
        private System.Windows.Forms.Label lblContarHojas;
        private System.Windows.Forms.Button btnContarNodos;
        private System.Windows.Forms.Label lblContarNodos;
        private System.Windows.Forms.Button btnLleno;
        private System.Windows.Forms.Label lblLleno;
        private System.Windows.Forms.Button btnRecorridoN;
        private System.Windows.Forms.Label lblRecorridoN;
        private System.Windows.Forms.Label lblCompleto;
        private System.Windows.Forms.Button btnCompleto;
    }
}