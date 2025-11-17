using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Arboles_Grafos.Grafos;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Arboles_Grafos
{
    public partial class FormGrafos : Form
    {
        private Grafo grafo = new Grafo();
        public FormGrafos()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Actualiza el ListBox (lstGrafos) mostrando:
        /// - Lista de edificios
        /// - Distancias entre ellos
        /// También actualiza el label de estado indicando si el grafo es conexo.
        /// </summary>
        private void ActualizarLista()
        {
            lstGrafos.Items.Clear();

            string texto = grafo.ObtenerResumen();
            foreach (var linea in texto.Split(new[] { Environment.NewLine }, StringSplitOptions.None))
            {
                lstGrafos.Items.Add(linea);
            }

            bool conexo = grafo.EsConexo();
            lblEstadoGrafo.Text = conexo
                ? "El parque ES conexo (todos los edificios están comunicados)."
                : "El parque NO es conexo (hay edificios aislados).";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtEdificio.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                lblEstadoGrafo.Text = "Ingresa el nombre del edificio.";
                return;
            }

            try
            {
                bool ok = grafo.AgregarEdificio(nombre);

                if (!ok)
                    lblEstadoGrafo.Text = "No se agregó. El edificio ya existe o el nombre no es válido.";
                else
                {
                    lblEstadoGrafo.Text = $"Edificio agregado: {nombre}";
                    txtEdificio.Clear();
                    ActualizarLista();
                }
            }
            catch (Exception ex)
            {
                lblEstadoGrafo.Text = "Error al agregar edificio: " + ex.Message;
            }
        }

        /// <summary>
        /// Botón "Agregar ruta".
        /// Registra una ruta (arista) entre dos edificios con una distancia (peso).
        /// </summary>
        private void btnRuta_Click(object sender, EventArgs e)
        {
            string origen = txtOrigenRuta.Text.Trim();
            string destino = txtDestinoRuta.Text.Trim();
            string textoDistancia = txtDistancia.Text.Trim();

            if (origen == "" || destino == "" || textoDistancia == "")
            {
                lblEstadoGrafo.Text = "Completa origen, destino y distancia.";
                return;
            }

            double distancia;
            if (!double.TryParse(textoDistancia, out distancia) || distancia <= 0)
            {
                lblEstadoGrafo.Text = "La distancia debe ser un número positivo.";
                return;
            }

            try
            {
                grafo.AgregarEdificio(origen);
                grafo.AgregarEdificio(destino);

                bool ok = grafo.AgregarRuta(origen, destino, distancia);

                if (!ok)
                {
                    lblEstadoGrafo.Text = "No se pudo registrar la ruta. Revisa los datos.";
                    return;
                }

                lblEstadoGrafo.Text = $"Ruta registrada: {origen} - {destino} ({distancia} m)";
                ActualizarLista();

                txtOrigenRuta.Clear();
                txtDestinoRuta.Clear();
                txtDistancia.Clear();
                txtOrigenRuta.Focus();
            }
            catch (Exception ex)
            {
                lblEstadoGrafo.Text = "Error al agregar ruta: " + ex.Message;
            }
        }
        /// <summary>
        /// Botón "Calcular".
        /// Calcula la ruta más corta entre dos edificios utilizando Dijkstra.
        /// </summary>
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string origen = txtEdificioOrigen.Text.Trim();
            string destino = txtEdificioDestino.Text.Trim();

            if (origen == "" || destino == "")
            {
                lblEstadoGrafo.Text = "Ingresa edificio origen y destino.";
                return;
            }

            var resultado = grafo.RutaMinima(origen, destino);

            if (double.IsPositiveInfinity(resultado.distancia) || resultado.camino.Count == 0)
            {
                lstGrafos.Items.Clear();
                lstGrafos.Items.Add("No existe ruta entre los edificios.");
                lblEstadoGrafo.Text = "No existe ruta entre esos edificios.";
                return;
            }

            lstGrafos.Items.Clear();
            lstGrafos.Items.Add("Ruta más corta:");
            lstGrafos.Items.Add(string.Join(" -> ", resultado.camino));
            lstGrafos.Items.Add($"Distancia mínima: {resultado.distancia}");

            lblEstadoGrafo.Text = $"Ruta más corta calculada entre {origen} y {destino}.";
        }

        private void btnMostrarConexiones_Click(object sender, EventArgs e)
        {
            ActualizarLista();
        }

        private void btnEliminarTodo_Click(object sender, EventArgs e)
        {
            grafo.Limpiar();
            lstGrafos.Items.Clear();

            txtEdificio.Clear();
            txtOrigenRuta.Clear();
            txtDestinoRuta.Clear();
            txtDistancia.Clear();
            txtOrigenRuta.Clear();
            txtDestinoRuta.Clear();

            lblEstadoGrafo.Text = "Se borraron todos los edificios y rutas.";
        }
    }
}
