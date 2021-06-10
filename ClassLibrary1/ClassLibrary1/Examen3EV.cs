using System.Collections.Generic;
using System;

namespace Examen3EV_NS
{
    /// <summary>
    /// Clase que calculará las Estadísticas de un conjunto de notas 
    /// </summary>

    public class EstadisticaNotasJOB2021  // esta clase nos calcula las estadísticas de un conjunto de notas 
    {
        private int tSuspensos;       // Suspensos
        private int tAprobados;       // Aprobados
        private int tNotables;        // Notables
        private int tSobresalientes;  // Sobresalientes
        private double tMedia;        // Nota media

        public const string listaVacia = "La lista no contiene ninguna nota";    // Excepcion lista vacía
        public const string notasFueraRango = "Las notas en la lista son menores que 0 y mayores que 10"; // Excepción notas fuera de rango

        public int SuspensosJOB2021                     // Devuelve todos los suspenso en la lista
        {
            get { return tSuspensos; }
            set { tSuspensos = value; }
        }

        public int Aprobadosjob2021                     // Devuelve todos los aprobados por debajo de 7 de la lista
        {
            get { return tAprobados; }
            set { tAprobados = value; }
        }

        public int NotablesJOB2021                // Devuelve todos los notables de la lista
        {
            get { return tNotables; }
            set { tNotables = value; }
        }

        public int SobresalientesJOB2021                // Devuelve todos los sobresalientes de la lista 
        {
            get { return tSobresalientes; }
            set { tSobresalientes = value; }
        }

        public double MediaJOB2021                      // Devuelve la media de todas las  notas 
        {
            get { return tMedia; }
            set { tMedia = value; }
        }

        // Constructor vacío

        /// <summary>
        /// Constructor vacío en el que ponene todos los atributos a 0.
        /// </summary>

        public EstadisticaNotasJOB2021()
        {
            tSuspensos = tAprobados = tNotables = tSobresalientes = 0;  // inicializamos las variables
            tMedia = 0.0;
        }

        // Constructor a partir de un array, calcula las estadísticas al crear el objeto

        /// <summary>
        /// Constructor que rellena los métodos a partir de la función CalcularEstadistica así se validarán también las notas
        /// </summary>
        /// <param name="listaNotas"> Una lista que contiene notas que en este caso son double </param>

        public EstadisticaNotasJOB2021(List<double> listaNotas)
        {
            CalcularEstadisticaJOB2021(listaNotas);
        }


        // Para un conjunto de listnot, calculamos las estadísticas
        // calcula la media y el número de suspensos/aprobados/notables/sobresalientes
        //
        // El método devuelve -1 si ha habido algún problema, la media en caso contrario	

        /// <summary>
        /// Función que valida las notas, las separa en aprobados, suspensos, notables y sobresalientes
        /// Y saca la media de todas las notas introducidas
        /// </summary>
        /// <exception cref="listaVacia"> Excepción que se produce cuando la lista no contiene nada </exception>
        /// <exception cref="notasFueraRango"> Excepción que se produce cuando la lista comprende notas por encima de 10 o por debajo de 0 </exception>
        /// <param name="listaNotas"> Una lista que contiene notas que en este caso son double </param>

        public void CalcularEstadisticaJOB2021(List<double> listaNotas)
        {                                 
            tMedia = 0.0;

            // TODO: hay que modificar el tratamiento de errores para generar excepciones
        
            if (listaNotas.Count <= 0)                           // Si la lista no contiene elementos, devolvemos un error
                throw new SystemException(listaVacia);

            for (int i = 0; i < listaNotas.Count; i++)
            {
                if (listaNotas[i] < 0 || listaNotas[i] > 10)      // comprobamos que las not están entre 0 y 10 (mínimo y máximo), si no, error
                    throw new ArgumentOutOfRangeException(notasFueraRango);
            }
            for (int i = 0; i < listaNotas.Count; i++)
            {
                if (listaNotas[i] < 5)
                    tSuspensos++;                                        // Por debajo de 5 suspenso
                else if (listaNotas[i] >= 5 && listaNotas[i] < 7)
                    tAprobados++;                                        // Nota para aprobar: 5
                else if (listaNotas[i] >= 7 && listaNotas[i] < 9)
                    tNotables++;                                         // Nota para notable: 7
                else if (listaNotas[i] >=9)
                    tSobresalientes++;                                   // Nota para sobresaliente: 9

                tMedia += listaNotas[i];
            }

            tMedia /=listaNotas.Count;
        }
    }
}
