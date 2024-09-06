using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using UnityEngine;

public class IEnumerables : MonoBehaviour
{
    public List<string> list;
    public string[] arreglo;

    void Start()
    {
        // no va a funcionar porque me esta pidiendo una lista y le estoy pasando un arreglo.
        Mostrar(arreglo);
        MostrarArreglo(list);

        // pero, al ser ienumerable con un generico de strings, le podre pasar las dos sin problemas.
        MostrarLoQueSea(arreglo);
        MostrarLoQueSea(list);
    }


    public void Mostrar(List<string> listaRecibida)
    {
        foreach (var item in listaRecibida)
        {
            Debug.Log(item);
        }
    }

    public void MostrarArreglo(string[] arregloRecibido)
    {
        foreach (var item in arregloRecibido)
        {
            Debug.Log(item);
        }
    }

    public void MostrarLoQueSea(IEnumerable<string> enumerablesRecibidos)
    {
        foreach (var item in enumerablesRecibidos)
        {
            Debug.Log(item);
        }

        // lo que no pueden hacer es for y count
        // for (int i = 0; enumerablesRecibidos.Count?.Length
    }

}