Caso de Estudio: Árboles y Grafos en C#
Materia: Programacion Estructurada
Nombre: Kate Valentina Ramirez Urbina.

Sistema de Jerarquía y Rutas del Parque Tecnológico “Innovatec”
Este proyecto fue desarrollado como parte del curso de Programación Estructurada, con el objetivo de implementar dos estructuras fundamentales:
Árbol general → para representar la jerarquía organizativa del parque.
Grafo ponderado → para modelar las rutas internas entre edificios.
Incluye aplicación de Estructuras de Datos, recorridos, búsquedas, algoritmos, y un diseño visual en Windows Forms.

Estructura del Proyecto:
El proyecto está organizado de forma clara y separada:

Archivo / Carpeta	Función
Arbol.cs	Lógica del árbol general: inserción, búsqueda, eliminación, recorridos y nivel.
Grafo.cs	Implementación del grafo: edificios, conexiones, distancias y cálculo de rutas.
FormArbol.cs	Interfaz gráfica para administrar la jerarquía del parque.
FormGrafos.cs	Interfaz gráfica para gestionar edificios y rutas del parque.
Program.cs	Punto de entrada de la aplicación.
Diseñadores (.Designer.cs)	Elementos visuales de la interfaz.

Parte A — Árbol: Jerarquía Organizativa
El árbol representa la estructura interna del parque, permitiendo organizar cargos, roles o departamentos de forma jerárquica.
✔️ Funcionalidades Principales
🔹 Inserción de Cargos
El primer cargo se establece como raíz.
Los siguientes pueden agregarse como:
Hijos del nodo seleccionado
Hijos directos de la raíz
No se permiten duplicados.

🔹 Búsqueda
El sistema busca cargos de forma recursiva.
La búsqueda no distingue mayúsculas/minúsculas.
El nodo encontrado puede ser resaltado visualmente en el árbol.

🔹 Eliminación de Nodos
Permite eliminar:
Un solo cargo
Un cargo con todos sus descendientes
La raíz completa
El árbol se actualiza automáticamente en pantalla.

🔹 Recorridos Disponibles
Pre-Orden
Post-Orden
Por niveles (BFS)
Los resultados se muestran en un ListBox dedicado.

🔹 Otros Cálculos del Árbol
Nivel de un nodo (en qué “piso” se encuentra dentro de la jerarquía).
Altura total del árbol.

🕸️ Parte B — Grafo: Sistema de Rutas Internas
El grafo modela los edificios del parque y los caminos que los conectan, incluyendo sus distancias.
✔️ Representación Interna
Se utiliza una lista de adyacencia, donde:
Cada edificio es una clave (string)
Cada clave contiene una lista de edificios conectados y su distancia (double)
Esto permite una estructura organizada, accesible y eficiente para consultas.

✔️ Funcionalidades del Grafo
🔹 Agregar Edificios
Valida que el nombre no esté vacío.
No permite duplicados.
Se agregan de manera dinámica según la necesidad.

🔹 Registrar Rutas
Conexiones bidireccionales (A ↔ B).
Se requieren distancias numéricas positivas.
El sistema crea automáticamente edificios inexistentes si se ingresan durante el registro de rutas.

🔹 Mostrar Conexiones
Lista todos los edificios y sus rutas.
Evita duplicados (A–B se muestra una sola vez).
Es posible visualizar el grafo completo en el ListBox.
🔹 Validar Conexidad del Parque
Verifica si todos los edificios están comunicados directa o indirectamente.

🔹 Ruta Más Corta
Implementa el algoritmo de Dijkstra:
Calcula la distancia mínima entre dos edificios.
Muestra la ruta completa paso a paso.
Indica si no existe conexión.

🖥️ Interfaz Gráfica (Windows Forms)
✔️ Módulo Árbol
Incluye:
TextBox para agregar cargos
Botones para buscar, recorrer, eliminar y calcular nivel
Un TreeView visual y dinámico
Mensajes amigables para el usuario

✔️ Módulo Grafo
Incluye:
Registro de edificios
Registro de rutas con distancias
ListBox donde se muestra toda la información del grafo
Botones para calcular rutas, actualizar conexiones y limpiar todo
Indicadores del estado del grafo
Todo el sistema está diseñado con un estilo moderno y colores personalizados.

Conclusión
El proyecto integra dos estructuras fundamentales de la programación:
✔ Árbol general, ideal para representar jerarquías.
✔ Grafo ponderado, perfecto para modelar rutas y caminos reales.
Ambas estructuras trabajan de manera coordinada dentro de una aplicación intuitiva, visual y completamente funcional.
