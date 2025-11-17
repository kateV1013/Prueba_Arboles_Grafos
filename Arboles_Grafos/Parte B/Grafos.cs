using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles_Grafos
{
    public class Grafos
    {
        public class Grafo
        {
            // edificio -> (vecino -> distancia)
            private readonly Dictionary<string, Dictionary<string, double>> mapa =
                new Dictionary<string, Dictionary<string, double>>(StringComparer.OrdinalIgnoreCase);

            // Agrega un edificio. True si se creó, false si ya existía o es inválido
            public bool AgregarEdificio(string nombre)
            {
                if (string.IsNullOrWhiteSpace(nombre))
                    return false;

                if (mapa.ContainsKey(nombre))
                    return false;

                mapa[nombre] = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase);
                return true;
            }

            // Agrega una ruta no dirigida con peso
            public bool AgregarRuta(string a, string b, double distancia)
            {
                if (string.IsNullOrWhiteSpace(a) || string.IsNullOrWhiteSpace(b))
                    return false;

                if (a.Equals(b, StringComparison.OrdinalIgnoreCase))
                    return false;

                if (distancia <= 0)
                    return false;

                if (!mapa.ContainsKey(a) || !mapa.ContainsKey(b))
                    return false;

                mapa[a][b] = distancia;
                mapa[b][a] = distancia;
                return true;
            }

            // Texto para mostrar edificios y distancias
            public string ObtenerResumen()
            {
                if (mapa.Count == 0)
                    return "(grafo vacío)";

                var sb = new StringBuilder();

                var nodos = mapa.Keys
                    .OrderBy(n => n, StringComparer.OrdinalIgnoreCase)
                    .ToList();

                sb.AppendLine("Edificios:");
                sb.AppendLine(string.Join(", ", nodos));
                sb.AppendLine();
                sb.AppendLine("Distancias:");

                var vistos = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

                foreach (var a in nodos)
                {
                    foreach (var kv in mapa[a].OrderBy(p => p.Key, StringComparer.OrdinalIgnoreCase))
                    {
                        string b = kv.Key;
                        double d = kv.Value;

                        // clave ordenada para no repetir A-B y B-A
                        string menor = string.Compare(a, b, StringComparison.OrdinalIgnoreCase) <= 0 ? a : b;
                        string mayor = menor == a ? b : a;
                        string clave = menor + "|" + mayor;

                        if (vistos.Contains(clave)) continue;
                        vistos.Add(clave);

                        sb.AppendLine($"{menor} - {mayor} : {d}");
                    }
                }

                return sb.ToString().TrimEnd();
            }

            // Para saber si el grafo es conexo
            public bool EsConexo()
            {
                if (mapa.Count == 0)
                    return false;

                var visitados = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
                var cola = new Queue<string>();

                string inicio = mapa.Keys.First();
                visitados.Add(inicio);
                cola.Enqueue(inicio);

                while (cola.Count > 0)
                {
                    string actual = cola.Dequeue();

                    foreach (var vecino in mapa[actual].Keys)
                    {
                        if (visitados.Add(vecino))
                            cola.Enqueue(vecino);
                    }
                }

                return visitados.Count == mapa.Count;
            }

            // Dijkstra simplificado: devuelve (distancia, camino)
            public (double distancia, List<string> camino) RutaMinima(string origen, string destino)
            {
                var sinRuta = (distancia: double.PositiveInfinity, camino: new List<string>());

                if (!mapa.ContainsKey(origen) || !mapa.ContainsKey(destino))
                    return sinRuta;

                var dist = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase);
                var prev = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
                var visitado = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

                foreach (var n in mapa.Keys)
                {
                    dist[n] = double.PositiveInfinity;
                    prev[n] = null;
                }
                dist[origen] = 0;

                while (true)
                {
                    string actual = null;
                    double mejor = double.PositiveInfinity;

                    // elegir el nodo no visitado con menor distancia
                    foreach (var n in mapa.Keys)
                    {
                        if (visitado.Contains(n)) continue;
                        if (dist[n] < mejor)
                        {
                            mejor = dist[n];
                            actual = n;
                        }
                    }

                    if (actual == null || double.IsPositiveInfinity(mejor))
                        break;

                    if (string.Equals(actual, destino, StringComparison.OrdinalIgnoreCase))
                        break;

                    visitado.Add(actual);

                    foreach (var kv in mapa[actual])
                    {
                        string v = kv.Key;
                        double peso = kv.Value;
                        if (visitado.Contains(v)) continue;

                        double alt = dist[actual] + peso;
                        if (alt < dist[v])
                        {
                            dist[v] = alt;
                            prev[v] = actual;
                        }
                    }
                }

                if (double.IsPositiveInfinity(dist[destino]))
                    return sinRuta;

                var camino = new List<string>();
                string nodo = destino;
                while (nodo != null)
                {
                    camino.Insert(0, nodo);
                    prev.TryGetValue(nodo, out nodo);
                }

                return (dist[destino], camino);
            }

            public void Limpiar()
            {
                mapa.Clear();
            }
        }
    }
}
