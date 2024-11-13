using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_No_Lineales
{
    public class ArbolBusqueda
    {
        NodoBinario Raiz;
        public String strArbol;
        public String strRecorrido;

        public ArbolBusqueda()
        {
            Raiz = null;
            strArbol = "";
        }

        public Boolean EstaVacio()
        {
            if (Raiz == null)
                return true;
            else
                return false;
        }
        public NodoBinario RegresaRaiz()
        {
            return Raiz;
        }

        public void InsertaNodo(int Dato, ref NodoBinario Nodo)
        {            
            if (Nodo == null)
            {
                Nodo = new NodoBinario(Dato);
               // Nodo.Dato = Dato;
                //Nodo.Izq = null;
                //Nodo.Der = null;
                //CAMBIO 2

                if (Raiz == null)
                    Raiz = Nodo;
            }
            else if (Dato < Nodo.Dato)
                InsertaNodo(Dato, ref Nodo.Izq);
            else if (Dato > Nodo.Dato)
                InsertaNodo(Dato, ref Nodo.Der);
            else
            {
                MessageBox.Show("El valor ingresado ya esta en el arbol", "Valor ya ingresado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void MuestraArbolAcostado(int nivel, NodoBinario nodo )
        {
            if (nodo == null)
                return;
            MuestraArbolAcostado(nivel + 1, nodo.Der);
            for(int i=0; i<nivel; i++)
            {
                strArbol = strArbol + "     ";
            }
            strArbol = strArbol + nodo.Dato.ToString() + "\r\n";
            MuestraArbolAcostado(nivel + 1, nodo.Izq); 
        }

        public String ToDot(NodoBinario nodo)
        {
            StringBuilder b = new StringBuilder();
            if (nodo.Izq != null)
            {
                b.AppendFormat("{0}->{1} [side=L] {2} ", nodo.Dato.ToString(), nodo.Izq.Dato.ToString(), Environment.NewLine);
                b.Append(ToDot(nodo.Izq));
            }

            if (nodo.Der != null)
            {
                b.AppendFormat("{0}->{1} [side=R] {2} ", nodo.Dato.ToString(), nodo.Der.Dato.ToString(), Environment.NewLine);
                b.Append(ToDot(nodo.Der));
            }
            return b.ToString();
        }

        public void PreOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            strRecorrido = strRecorrido + nodo.Dato + ", ";
            PreOrden(nodo.Izq);
            PreOrden(nodo.Der);

            return;
        }

        public void InOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            InOrden(nodo.Izq);
            strRecorrido = strRecorrido + nodo.Dato + ", ";
            InOrden(nodo.Der);

            return;
        }

        public void PostOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            PostOrden(nodo.Izq);
            PostOrden(nodo.Der);
            strRecorrido = strRecorrido + nodo.Dato + ", ";

            return;
        }

        public String BuscaNodo(int Valor)
        {
            if (Raiz == null)
            {
                return "El arbol esta vacio";
            }
            if (Busqueda(Valor, Raiz))
            {
                return "Se ha encontrado el dato: " + Valor;
            }
            else
            {
                return "El valor no fue encontrado";
            }

        }

        public Boolean Busqueda(int Valor, NodoBinario nodo)
        {
            if (nodo == null)
            {
                return false;
            }
            else if (Valor < nodo.Dato)
            {
                return Busqueda(Valor, nodo.Izq);
            }
            else if (Valor > nodo.Dato)
            {
                return Busqueda(Valor, nodo.Der);
            }
            else
            {
                return true;
            }
        }

        public void podarArbol(ref NodoBinario nodo)
        {
            if (nodo == null)
                return;
            podarArbol(ref nodo.Izq);

            podarArbol(ref nodo.Der);

            nodo = null;

            return;
        }

        public void Podar()
        {
            if (Raiz == null)
            {
                MessageBox.Show("El arbol ya esta vacio.", "Arbol vacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            podarArbol(ref Raiz);
            Raiz = null;
        }

        public void eliminarPredecesor(int dato, ref NodoBinario nodo)
        {
            if (nodo == null)
                return;

            if(dato< nodo.Dato)
            {
                eliminarPredecesor(dato, ref nodo.Izq);
            }
            else if (dato > nodo.Dato)
            {
                eliminarPredecesor(dato, ref nodo.Der);
            }
            else
            {
                if (nodo.Izq != null && nodo.Der != null)
                {
                    NodoBinario mayor = buscaMayor(nodo.Izq);
                    nodo.Dato = mayor.Dato;
                    eliminarPredecesor(mayor.Dato, ref nodo.Izq);
                }
                else
                {
                    NodoBinario temp = nodo;
                    if (nodo.Izq == null)
                        nodo = nodo.Der;
                    else if (nodo.Der == null)
                        nodo = nodo.Izq;

                    temp = null;
                }
            }
        }

        private NodoBinario buscaMayor(NodoBinario nodo)
        {
            if(nodo == null)
            {
                return null;
            }
            else if(nodo.Der == null)
            {
                return nodo;
            }
            else
            {
                return buscaMayor(nodo.Der);
            }
        }

        public void eliminarSucesor(int dato, ref NodoBinario nodo)
        {
            if (nodo == null)
                return;

            if (dato < nodo.Dato)
            {
                eliminarSucesor(dato, ref nodo.Izq);
            }
            else if(dato > nodo.Dato)
            {
                eliminarSucesor(dato, ref nodo.Der);
            }
            else
            {
                if (nodo.Izq != null && nodo.Der != null)
                {
                    NodoBinario menor = buscaMenor(nodo.Der);
                    nodo.Dato = menor.Dato;
                    eliminarSucesor(menor.Dato, ref nodo.Der);
                }
                else
                {
                    NodoBinario temp = nodo;
                    if (nodo.Izq == null)
                        nodo = nodo.Izq;

                    temp = null;
                }
            }
        }
        private NodoBinario buscaMenor(NodoBinario nodo)
        {
            if (nodo == null)
            {
                return null;
            }
            else if (nodo.Izq == null)
            {
                return nodo;
            }
            else
            {
                return buscaMayor(nodo.Izq);
            }
        }

        public int Altura(NodoBinario nodoPtr)
        {
            if (nodoPtr == null)
                return 0;

            int alturaIzquierda = Altura(nodoPtr.Izq);
            int alturaDerecha = Altura(nodoPtr.Der);

            return 1 + Math.Max(alturaIzquierda, alturaDerecha);
        }

        public int contarHojas(NodoBinario nodoPtr)
        {
            if (nodoPtr == null)
                return 0;

            if (nodoPtr.Der == null && nodoPtr.Izq == null)
                return 1;
            else
                return contarHojas(nodoPtr.Izq) + contarHojas(nodoPtr.Der);
        }

        public int contarNodos(NodoBinario nodoPtr)
        {
            if (nodoPtr == null)
                return 0;

            return 1 + contarNodos(nodoPtr.Izq) + contarNodos(nodoPtr.Der);
        }

        public bool esLleno(NodoBinario nodoPtr)
        {
            if (nodoPtr == null)
                return true;

            if (nodoPtr.Der == null && nodoPtr.Izq == null)
                return true;

            if (nodoPtr.Der != null && nodoPtr.Izq != null)
                return esLleno(nodoPtr.Izq) && esLleno(nodoPtr.Izq);

            return false;
        }

        public void recorridoNiveles(NodoBinario nodoPtr, ref string strRecorrido)
        {
            if (nodoPtr == null) return;

            Queue<NodoBinario> colaAuxiliar = new Queue<NodoBinario>();
            colaAuxiliar.Enqueue(nodoPtr);

            while (colaAuxiliar.Count > 0)
            {
                NodoBinario nodoAuxiliar = colaAuxiliar.Dequeue();
                strRecorrido += nodoAuxiliar.Dato + " - ";

                if (nodoAuxiliar.Izq != null)
                    colaAuxiliar.Enqueue(nodoAuxiliar.Izq);
                if (nodoAuxiliar.Der != null)
                    colaAuxiliar.Enqueue(nodoAuxiliar.Der);
            }
        }
        public bool esCompleto(NodoBinario nodoPtr)
        {
            if (nodoPtr == null)
                return false;

            NodoBinario nodoAuxiliar;
            Queue<NodoBinario> colaAuxiliar = new Queue<NodoBinario>();
            colaAuxiliar.Enqueue(nodoPtr);
            bool nodoNoLleno = false;

            while (colaAuxiliar.Count == 0)
            {
                nodoAuxiliar = colaAuxiliar.Dequeue();

                if (nodoAuxiliar.Izq != null)
                {
                    if (nodoNoLleno == true)
                        return false;
                    colaAuxiliar.Enqueue(nodoAuxiliar.Izq);
                }
                else
                {
                    nodoNoLleno = true;
                }
                if (nodoAuxiliar.Der != null)
                {
                    if (nodoNoLleno == true)
                        return false;
                    colaAuxiliar.Enqueue(nodoAuxiliar.Der);
                }
                else
                {
                    nodoNoLleno = true;
                }
            }
            return true;
        }
    }
}
