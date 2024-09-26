using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Clases.PA2024.IEnumerables
{
    // Los IEnumerable son una interface que nos permite acceder a los valores de un arreglo o de una lista sin la necesidad de especificar cual es.
    public class IEnumerables : MonoBehaviour
    {
        public List<string> list;
        public string[] arreglo;

        private void Start()
        {
            // No va a funcionar porque me esta pidiendo una lista y le estoy pasando un arreglo.
            //MostrarLista(arreglo);

            // No va a funcionar porque me esta pidiendo un arreglo y le estoy pasando una lista.
            //MostrarArreglo(list);

            // Pero, al ser ienumerable con un generico de strings, le podre pasar las dos sin problemas.
            MostrarLoQueSea(arreglo);
            MostrarLoQueSea(list);
        }

        // Aca se usa una lista.
        public void MostrarLista(List<string> listaRecibida)
        {
            foreach (var item in listaRecibida)
            {
                Debug.Log(item);
            }
        }

        // Aca se usa un arreglo.
        public void MostrarArreglo(string[] arregloRecibido)
        {
            foreach (var item in arregloRecibido)
            {
                Debug.Log(item);
            }
        }

        // Aca se usa un IEnumerable, lo cual nos permite mandar listas o arreglos.
        public void MostrarLoQueSea(IEnumerable<string> enumerablesRecibidos)
        {
            // Gracias a esto, podremos hacer un foreach iterando cada item del IEnumerable
            foreach (var item in enumerablesRecibidos)
            {
                Debug.Log(item);
            }

            // Pero, no se pueden hacer for, ni obtener el total ya que solo nos devuelve valores.
            // Aun asi, se puede utilizar linq, o sumar manualmente con lambda o sin lambda, por ejemplo:
            int totalForeach = 0;
            foreach (var item in enumerablesRecibidos)
            {
                totalForeach++;
            }

            // De este no estoy completamente seguro si se puede hacer, pero ojalá que si.
            // int totalForEach = 0;
            // enumerablesRecibidos.ForEach(c => totalForEach += item.Count);

            // Edit 26 de septiembre: no se puede.
        }
    }
}