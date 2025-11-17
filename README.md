📘 Caso de Estudio: Árboles y Grafos en C#

Materia: Programación Estructurada

Estudiante: Kate Valentina Ramírez Urbina

🏢 Sistema de Jerarquía y Rutas del Parque Tecnológico “Innovatec”

Este proyecto fue desarrollado como parte del curso de Programación Estructurada, con el objetivo de implementar dos estructuras fundamentales:

Árbol general (N-ario) → Representa la jerarquía organizativa del parque.

Grafo ponderado → Modela las rutas internas entre edificios y permite calcular la ruta más corta.

El sistema incluye estructuras de datos, búsquedas, recorridos, algoritmos y una interfaz visual hecha en Windows Forms.

📂 Estructura del Proyecto

Archivo / Carpeta	Función

Arbol.cs	Lógica del árbol: insertar, buscar, eliminar, recorrer, calcular niveles.

Grafo.cs	Implementación del grafo: edificios, rutas, distancias y Dijkstra.

FormArbol.cs	Interfaz gráfica del módulo Árbol.

FormGrafos.cs	Interfaz gráfica del módulo Grafos.

Program.cs	Punto de entrada de la aplicación.

.Designer.cs / .resx	Componentes visuales de Windows Forms.

🌳 Parte A — Árbol: Jerarquía Organizativa

El árbol permite organizar la estructura interna del parque: cargos, departamentos, áreas, oficinas, etc.

✔️ Funcionalidades Principales
🔹 Inserción de Cargos

El primer cargo se convierte en la raíz del árbol.

Los siguientes pueden agregarse como:

Hijos del nodo seleccionado.

Hijos directos de la raíz.

Se impiden registros duplicados.

🔹 Búsqueda Recursiva

No distingue mayúsculas/minúsculas.

Recorre todo el árbol hasta encontrar coincidencias.

El nodo encontrado puede resaltarse en el TreeView.

🔹 Eliminación de Nodos

Permite borrar:

Un único cargo

Un nodo con todos sus hijos (subárbol completo)

La raíz del árbol

El árbol se actualiza automáticamente en pantalla.

🔹 Recorridos Implementados

Pre-Orden

Post-Orden

Por niveles (BFS)

Los resultados se muestran en un ListBox.

🔹 Cálculos Adicionales

Nivel de un nodo: indica en qué profundidad se encuentra dentro de la jerarquía.

Altura del árbol: cantidad total de niveles.

##🕸️ Parte B — Grafo: Sistema de Rutas Internas

El grafo modela los edificios del parque y las rutas que los conectan, junto con sus distancias.

✔️ Representación Interna

Se utiliza una lista de adyacencia, donde:

Cada edificio es una clave (string).

Cada clave contiene una lista de edificios conectados y su distancia (double).

Esto permite una estructura eficiente y muy fácil de actualizar.

✔️ Funcionalidades del Grafo
🔹 Agregar Edificios

Valida entradas vacías.

Evita duplicados.

Los edificios se agregan dinámicamente.

🔹 Registrar Rutas

Las conexiones son bidireccionales: A ↔ B.

La distancia debe ser mayor que cero.

Si un edificio no existe, puede añadirse automáticamente.

🔹 Mostrar Conexiones

Lista todos los edificios.

Muestra todas las rutas sin duplicar (A–B se muestra una sola vez).

La información se muestra en un ListBox.

🔹 Validar Conexidad

Permite saber si todos los edificios están comunicados entre sí.

🔹 Ruta Más Corta (Dijkstra)

El sistema es capaz de:

Calcular la distancia mínima entre dos edificios.

Mostrar la ruta completa paso a paso.

Indicar si no existe camino posible.

##🖥️ Interfaz Gráfica (Windows Forms)
#✔️ Módulo Árbol

Incluye:

TextBox para agregar cargos

Botones para buscar, recorrer, eliminar y calcular nivel

TreeView dinámico

ListBox para mostrar recorridos

Mensajes claros para el usuario

#✔️ Módulo Grafo

Incluye:

Registro de edificios

Registro de rutas con distancias

Verificación de conexidad

Cálculo de ruta mínima

Limpieza total del grafo

ListBox para mostrar conexiones y rutas

Diseño moderno con paneles y colores personalizados

##📌 Conclusión

Este proyecto integra de manera práctica dos estructuras esenciales:

✔ Árbol general, ideal para jerarquías y organización.

✔ Grafo ponderado, excelente para rutas, caminos y distancias.

Ambas estructuras funcionan dentro de una interfaz amigable, moderna y completamente funcional.
