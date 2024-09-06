using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using UnityEngine;

public class IfCortos : MonoBehaviour
{
    Rigidbody enemigo1;
    Rigidbody enemigo2;

    public void Start()
    {
        bool activo = true;
        string texto = null;

        // esto
        if (activo)
        {
            texto = "Estoy activado";
        }

        else
        {
            texto = "Estoy desactivado";
        }

        // y esto, son lo mismo
        texto = activo ? "Estoy activado" : "Estoy desactivado";
 
        bool hola = Random.Range(0, 2) == 0;
        Rigidbody seleccionado = hola ? enemigo1 : enemigo2;
        
    }

}