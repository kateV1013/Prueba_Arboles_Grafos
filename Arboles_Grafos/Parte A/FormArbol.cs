using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arboles_Grafos
{
    public partial class FormArbol : Form
    {
        Arbol arbol = new Arbol();
        public FormArbol()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string valor = txtValor.Text.Trim();
                if (string.IsNullOrWhiteSpace(valor))
                {
                    lblEstadoArbol.Text = "Ingrese un cargo.";
                    return;
                }

                string padre = null;

                if (arbol.Raiz != null)
                {
                    if (treeArbol.SelectedNode == null)
                    {
                        lblEstadoArbol.Text = "Selecciona el cargo padre en el árbol antes de agregar.";
                        return; // ← evita colgar todo de la raíz por defecto
                    }
                    padre = treeArbol.SelectedNode.Text;
                }

                bool ok = arbol.Insertar(valor, padre);
                if (!ok)
                {
                    lblEstadoArbol.Text = "No se pudo agregar (cargo duplicado o padre inválido).";
                    return;
                }

                lblEstadoArbol.Text = $"Cargo agregado: {valor}";
                txtValor.Clear();
                txtValor.Focus();
                MostrarArbol();
            }
            catch (Exception ex)
            {
                lblEstadoArbol.Text = "Error al agregar: " + ex.Message;
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string valor = txtBuscar.Text.Trim();

            if (string.IsNullOrWhiteSpace(valor))
            {
                lblEstadoArbol.Text = "Debes ingresar un cargo para buscar.";
                return;
            }

            bool encontrado = arbol.Buscar(valor);

            lblEstadoArbol.Text = encontrado
                ? $"Cargo encontrado: {valor}"
                : $"El cargo \"{valor}\" no existe en la jerarquía.";
            txtValor.Clear();
            txtValor.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Solo vacía la lista de resultados/recorridos.
            lstArbol.Items.Clear();

            // (Opcional) Mensaje corto para el usuario:
            lblEstadoArbol.Text = "Lista de recorridos limpiada.";
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            int total = arbol.Contar();
            lblEstadoArbol.Text = $"Total de cargos: {total}";
        }

        private void btnRecorrido_Click(object sender, EventArgs e)
        {
            if (cmbRecorrido.SelectedItem == null)
            {
                lblEstadoArbol.Text = "Selecciona un tipo de recorrido.";
                return;
            }

            if (arbol.Raiz == null)
            {
                lblEstadoArbol.Text = "El árbol está vacío.";
                return;
            }

            string tipo = cmbRecorrido.SelectedItem.ToString();
            List<string> lista = new List<string>();

            switch (tipo)
            {
                case "InOrden":
                    arbol.RecorridoInOrden(arbol.Raiz, lista);
                    break;

                case "PreOrden":
                    arbol.RecorridoPreOrden(arbol.Raiz, lista);
                    break;

                case "PostOrden":
                    arbol.RecorridoPostOrden(arbol.Raiz, lista);
                    break;

                case "Por niveles":
                    arbol.RecorridoPorNiveles(lista);
                    break;
            }

            lstArbol.Items.Clear();
            foreach (var item in lista)
                lstArbol.Items.Add(item);

            lblEstadoArbol.Text = $"Recorrido {tipo} completo.";
        }
        private void MostrarArbol()
        {
            treeArbol.Nodes.Clear();

            if (arbol.Raiz == null)
                return;

            TreeNode nodoRaizVisual = new TreeNode(arbol.Raiz.Valor);
            treeArbol.Nodes.Add(nodoRaizVisual);

            AgregarHijosVisuales(nodoRaizVisual, arbol.Raiz);

            treeArbol.ExpandAll();
        }
        private void AgregarHijosVisuales(TreeNode nodoVisual, Arbol.Nodo nodoLogico)
        {
            foreach (var hijo in nodoLogico.Hijos)
            {
                TreeNode nodoHijoVisual = new TreeNode(hijo.Valor);
                nodoVisual.Nodes.Add(nodoHijoVisual);
                AgregarHijosVisuales(nodoHijoVisual, hijo);
            }
        }
        private void btnEliminarArbol_Click(object sender, EventArgs e)
        {
            arbol = new Arbol();
            treeArbol.Nodes.Clear();
            lstArbol.Items.Clear();
            lblEstadoArbol.Text = "Árbol eliminado completamente.";
        }

        private void treeArbol_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node == null)
                return;

            string valor = e.Node.Text;

            // Confirmar con el usuario
            var respuesta = MessageBox.Show(
                $"¿Desea eliminar el cargo \"{valor}\"?",
                "Eliminar cargo", MessageBoxButtons.YesNo, MessageBoxIcon.Question
            );

            if (respuesta != DialogResult.Yes)
                return;

            try
            {
                arbol.Eliminar(valor);   
                MostrarArbol();         
                lblEstadoArbol.Text = $"Cargo \"{valor}\" eliminado.";
            }
            catch (Exception ex)
            {
                lblEstadoArbol.Text = "Error al eliminar cargo: " + ex.Message;
            }
        }

        private void btnNivelNodo_Click(object sender, EventArgs e)
        {
            string valor = txtNivelNodo.Text.Trim();

            if (string.IsNullOrWhiteSpace(valor))
            {
                lblEstadoArbol.Text = "Debes ingresar un cargo para consultar su nivel.";
                return;
            }

            int nivel = arbol.ObtenerNivelNodo(valor);

            if (nivel == -1)
                lblEstadoArbol.Text = $"El cargo \"{valor}\" no existe en el árbol.";
            else
                lblEstadoArbol.Text = $"El cargo \"{valor}\" está en el nivel {nivel}.";
            txtNivelNodo.Clear();
            txtNivelNodo.Focus();

        }

        private void btnAlturaArbol_Click(object sender, EventArgs e)
        {
            int altura = arbol.ObtenerAltura();
            lblEstadoArbol.Text = $"El árbol tiene {altura} niveles.";
        }
        private void treeArbol_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lblEstadoArbol.Text = $"Padre seleccionado: {e.Node.Text}";
        }
    }
}
