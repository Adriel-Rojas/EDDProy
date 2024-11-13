using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_No_Lineales
{
    public partial class frmArboles : Form
    {
        ArbolBusqueda miArbol;
        NodoBinario miRaiz;

        public frmArboles()
        {
            InitializeComponent();
            miArbol = new ArbolBusqueda();
            miRaiz = null;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
 
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();

            //Limpiamos la cadena donde se concatenan los nodos del arbol 
            miArbol.strArbol = "";

            //Se inserta el nodo con el dato capturado
            miArbol.InsertaNodo(int.Parse(txtDato.Text), ref miRaiz);

            //Leer arbol completo y mostrarlo en caja de texto
            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;
            
            txtDato.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            miArbol = null;
            miRaiz = null;
            miArbol = new ArbolBusqueda();
            txtArbol.Text  = "";
            txtDato.Text = "";
            lblRecorrerPreOrden.Text = "";
            lblRecorrerInOrden.Text = "";
            lblRecorrerPostOrden.Text = "";
        }

        private void btnGrafica_Click(object sender, EventArgs e)
        {
            String graphVizString;

            miRaiz = miArbol.RegresaRaiz();
            if (miRaiz == null)
            {
                MessageBox.Show("El arbol esta vacio");
                return;
            }

            StringBuilder b = new StringBuilder();
            b.Append("digraph G { node [shape=\"circle\"]; " + Environment.NewLine);
            b.Append(miArbol.ToDot(miRaiz));
            b.Append("}");
            graphVizString = b.ToString();

            //graphVizString = @" digraph g{ label=""Graph""; labelloc=top;labeljust=left;}";
            //graphVizString = @"digraph Arbol{Raiz->60; 60->40. 60->90; 40->34; 40->50;}";
            Bitmap bm = FileDotEngine.Run(graphVizString);


            frmGrafica graf = new frmGrafica();
            graf.ActualizaGrafica(bm);
            graf.MdiParent = this.MdiParent;
            graf.Show();
        }

        private void btnRecorrer_Click(object sender, EventArgs e)
        {
            //Recorrido en PreOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblRecorrerPreOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorrerPreOrden.Text = "";
            miArbol.PreOrden(miRaiz);

            lblRecorrerPreOrden.Text = miArbol.strRecorrido;


            //Recorrido en InOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblRecorrerInOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorrerInOrden.Text = "";
            miArbol.InOrden(miRaiz);
            lblRecorrerInOrden.Text = miArbol.strRecorrido;


            //Recorrido en PostOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblRecorrerPostOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorrerPostOrden.Text = "";
            miArbol.PostOrden(miRaiz);
            lblRecorrerPostOrden.Text = miArbol.strRecorrido;
        }

        private void btnCrearArbol_Click(object sender, EventArgs e)
        {
            //Limpiamos los objetos y clases del anterior arbol
            miArbol = null;
            miRaiz = null;
            miArbol = new ArbolBusqueda();
            txtArbol.Text = "";
            txtDato.Text = "";

            miArbol.strArbol = "";

            Random rnd = new Random();

            for (int nNodos = 1; nNodos <= txtNodos.Value; nNodos++)
            {
                int Dato = rnd.Next(1, 100);
                //Obtenemos el nodo Raiz del arbol
                miRaiz = miArbol.RegresaRaiz();

                //Se inserta el nodo con el dato capturado
                miArbol.InsertaNodo(Dato, ref miRaiz);
            }

            //Leer arbol completo y mostrarlo en caja de texto
            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;

            txtDato.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(int.TryParse(txtDato.Text, out int valor))
            {
                String resultado = miArbol.BuscaNodo(valor);
                lblResultado.Text = resultado;
                txtDato.Clear();
            }
            else
            {
                lblResultado.Text = "Ingrese un numero valido...";
            }
        }

        private void btnPodar_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();

            if(miRaiz == null)
            {
                MessageBox.Show("El arbol esta vacio", "Arbol vacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            miArbol.Podar();

            txtArbol.Text = "";

            lblPodar.Text = "El arbol ha sido podado.";
        }

        private void btnPredecesor_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDato.Text, out int valor))
            {
                miRaiz = miArbol.RegresaRaiz();
                if (miRaiz == null)
                {
                    MessageBox.Show("El arbol esta vacio", "Arbol vacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                miArbol.eliminarPredecesor(valor, ref miRaiz);

                // Actualiza el árbol en la interfaz gráfica
                miArbol.strArbol = "";
                miArbol.MuestraArbolAcostado(1, miRaiz);
                txtArbol.Text = miArbol.strArbol;

                txtDato.Clear();
                MessageBox.Show("Se elimino el nodo", "Nodo eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ingrese un numero valido", "Nnumero invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSucesor_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDato.Text, out int valor))
            {
                miRaiz = miArbol.RegresaRaiz();
                if (miRaiz == null)
                {
                    MessageBox.Show("El arbol esta vacio.", "Arbol vacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                miArbol.eliminarSucesor(valor, ref miRaiz);

                // Actualiza el árbol en la interfaz gráfica
                miArbol.strArbol = "";
                miArbol.MuestraArbolAcostado(1, miRaiz);
                txtArbol.Text = miArbol.strArbol;

                txtDato.Clear();
                MessageBox.Show("Se elimino el nodo", "Nodo eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ingrese un numero valido.", "Numero invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAltura_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();

            if (miRaiz == null)
            {
                MessageBox.Show("El arbol esta vacio.", "Arbol vacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int altura = miArbol.Altura(miRaiz);

            lblAltura.Text = "La altura del arbol es: " + altura;
        }

        private void btnContarHojas_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();

            if (miRaiz == null)
            {
                MessageBox.Show("El arbol esta vacio.", "Arbol vacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int numeroDeHojas = miArbol.contarHojas(miRaiz);

            lblContarHojas.Text = "El numero de hojas es: " + numeroDeHojas;
        }

        private void btnContarNodos_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();

            if (miRaiz == null)
            {
                MessageBox.Show("El arbol esta vacio.", "Arbol vacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int numeroDeNodos = miArbol.contarNodos(miRaiz);

            lblContarNodos.Text = "El numero de nodos es: " + numeroDeNodos;
        }

        private void btnLleno_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();

            if (miRaiz == null)
            {
                MessageBox.Show("El arbol esta vacio.", "Arbol vacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool arbolLleno = miArbol.esLleno(miRaiz);

            lblLleno.Text = "El arbol es lleno? " + arbolLleno;
        }

        private void btnRecorridoN_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();

            if (miRaiz == null)
            {
                MessageBox.Show("El arbol esta vacio", "Arbol vacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            miArbol.recorridoNiveles(miRaiz, ref miArbol.strRecorrido);

            lblRecorridoN.Text = miArbol.strRecorrido;
        }

        private void btnCompleto_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();

            if (miRaiz == null)
            {
                MessageBox.Show("El arbol esta vacio.", "Arbol vacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool arbolCompleto = miArbol.esCompleto(miRaiz);

            lblCompleto.Text = "El arbol es completo? " + arbolCompleto;
        }
    }
}
