using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles_Grafos
{
    public class Arbol
    {
        public class Nodo
        {
            public string Valor { get; set; }
            public List<Nodo> Hijos { get; } = new List<Nodo>();

            public Nodo(string valor)
            {
                Valor = valor;
            }
        }

        // Raíz del árbol
        public Nodo Raiz { get; private set; }

        // Inserta un nuevo cargo. Si padre es null y el árbol está vacío -> nueva raíz.
        // Si padre es null y ya hay raíz -> se agrega como hijo directo de la raíz.
        public bool Insertar(string valor, string padre = null)
        {
            if (string.IsNullOrWhiteSpace(valor))
                return false;

            // Evitar duplicados (mismo texto)
            if (BuscarNodo(valor) != null)
                return false;

            if (Raiz == null)
            {
                Raiz = new Nodo(valor);
                return true;
            }

            // Sin padre explícito -> lo cuelgo de la raíz
            if (string.IsNullOrEmpty(padre))
            {
                Raiz.Hijos.Add(new Nodo(valor));
                return true;
            }

            // Buscar nodo padre
            var nodoPadre = BuscarNodo(padre);
            if (nodoPadre == null)
                return false;

            nodoPadre.Hijos.Add(new Nodo(valor));
            return true;
        }

        // Buscar: devuelve true si existe un nodo con ese valor
        public bool Buscar(string valor)
        {
            return BuscarNodo(valor) != null;
        }

        private Nodo BuscarNodo(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor) || Raiz == null)
                return null;

            return BuscarProfundo(Raiz, valor);
        }

        private Nodo BuscarProfundo(Nodo actual, string valor)
        {
            if (actual == null) return null;

            if (string.Equals(actual.Valor, valor, StringComparison.OrdinalIgnoreCase))
                return actual;

            foreach (var hijo in actual.Hijos)
            {
                var encontrado = BuscarProfundo(hijo, valor);
                if (encontrado != null)
                    return encontrado;
            }

            return null;
        }

        // Contar todos los cargos del árbol
        public int Contar()
        {
            return ContarSubarbol(Raiz);
        }

        private int ContarSubarbol(Nodo nodo)
        {
            if (nodo == null) return 0;

            int total = 1;
            foreach (var hijo in nodo.Hijos)
                total += ContarSubarbol(hijo);

            return total;
        }

        // Eliminar un cargo y todo su subárbol.
        // Devuelve la cantidad de nodos eliminados.
        public int Eliminar(string valor)
        {
            if (Raiz == null || string.IsNullOrWhiteSpace(valor))
                return 0;

            // Si la raíz es el nodo a eliminar, se borra todo
            if (string.Equals(Raiz.Valor, valor, StringComparison.OrdinalIgnoreCase))
            {
                int cuantos = ContarSubarbol(Raiz);
                Raiz = null;
                return cuantos;
            }

            return EliminarDesde(Raiz, valor);
        }

        private int EliminarDesde(Nodo padre, string valor)
        {
            for (int i = 0; i < padre.Hijos.Count; i++)
            {
                var hijo = padre.Hijos[i];

                if (string.Equals(hijo.Valor, valor, StringComparison.OrdinalIgnoreCase))
                {
                    int cantidad = ContarSubarbol(hijo);
                    padre.Hijos.RemoveAt(i);
                    return cantidad;
                }

                int sub = EliminarDesde(hijo, valor);
                if (sub > 0)
                    return sub;
            }

            return 0;
        }

        // InOrden para árbol general: primero un hijo, luego el nodo, luego el resto
        public void RecorridoInOrden(Nodo nodo, List<string> salida)
        {
            if (nodo == null) return;

            if (nodo.Hijos.Count > 0)
                RecorridoInOrden(nodo.Hijos[0], salida);

            salida.Add(nodo.Valor);

            for (int i = 1; i < nodo.Hijos.Count; i++)
                RecorridoInOrden(nodo.Hijos[i], salida);
        }

        // PreOrden: nodo -> hijos
        public void RecorridoPreOrden(Nodo nodo, List<string> salida)
        {
            if (nodo == null) return;

            salida.Add(nodo.Valor);
            foreach (var hijo in nodo.Hijos)
                RecorridoPreOrden(hijo, salida);
        }

        // PostOrden: hijos -> nodo
        public void RecorridoPostOrden(Nodo nodo, List<string> salida)
        {
            if (nodo == null) return;

            foreach (var hijo in nodo.Hijos)
                RecorridoPostOrden(hijo, salida);

            salida.Add(nodo.Valor);
        }

        // Por niveles (BFS)
        public void RecorridoPorNiveles(List<string> salida)
        {
            salida.Clear();
            if (Raiz == null) return;

            var cola = new Queue<Nodo>();
            cola.Enqueue(Raiz);

            while (cola.Count > 0)
            {
                var actual = cola.Dequeue();
                salida.Add(actual.Valor);

                foreach (var hijo in actual.Hijos)
                    cola.Enqueue(hijo);
            }
        }

        // Nivel 0 = raíz, 1 = hijos de la raíz, etc.
        public int ObtenerNivelNodo(string valor)
        {
            if (Raiz == null || string.IsNullOrWhiteSpace(valor))
                return -1;

            var cola = new Queue<(Nodo nodo, int nivel)>();
            cola.Enqueue((Raiz, 0));

            while (cola.Count > 0)
            {
                var (nodo, nivel) = cola.Dequeue();

                if (string.Equals(nodo.Valor, valor, StringComparison.OrdinalIgnoreCase))
                    return nivel;

                foreach (var hijo in nodo.Hijos)
                    cola.Enqueue((hijo, nivel + 1));
            }

            return -1; // no encontrado
        }

        // Altura del árbol = número de niveles
        public int ObtenerAltura()
        {
            return ObtenerAlturaRec(Raiz);
        }

        private int ObtenerAlturaRec(Nodo nodo)
        {
            if (nodo == null) return 0;

            int maxHijo = 0;
            foreach (var hijo in nodo.Hijos)
            {
                int altHijo = ObtenerAlturaRec(hijo);
                if (altHijo > maxHijo)
                    maxHijo = altHijo;
            }

            return maxHijo + 1;
        }
    }
}