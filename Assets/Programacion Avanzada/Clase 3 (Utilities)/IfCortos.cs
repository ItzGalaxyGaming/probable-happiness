using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Clases.PA2024.Utilities.IfTernary
{
    public class IfCortos : MonoBehaviour
    {
        Rigidbody enemigo1;
        Rigidbody enemigo2;

        public void Start()
        {
            bool activo = true;
            string texto = null;

            // Este seria un if largo, que nos permite asignar a texto un valor dependiendo de si está activado o no.
            if (activo)
            {
                texto = "Estoy activado";
            }

            else
            {
                texto = "Estoy desactivado";
            }

            // Y este es un if corto, que nos permite hacer lo mismo.
            // Lo primero es tener una condicion, por ejemplo un bool, un int menor que algo, un string igual a "Hola", etcetera.
            // Luego se utiliza ? para decir, si esto es true, texto será igual a "Estoy activado"
            // Y, utilizando el : seria en el caso de que no lo fuera, seria esto otro.
            texto = activo ? "Estoy activado" : "Estoy desactivado";

            // Aca se puede crear un bool, para definir si es true siempre y cuando el valor aleatorio sea 0, si es 1, será false.
            // Jamas será dos, ya que el Random.Range de tipo Int, tendrá su segundo valor como exclusivo, no inclusivo, lo que hace que solo dará valores
            //     aleatorios de 0 y 1.
            bool hola = Random.Range(0, 2) == 0;

            // Luego, dependiendo del bool, definiremos que un Rigidbody es igual a enemigo1 si es true, o enemigo2 si es false.
            Rigidbody seleccionado = hola ? enemigo1 : enemigo2;

        }
    }
}