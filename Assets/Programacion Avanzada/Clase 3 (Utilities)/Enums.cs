using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Clases.PA2024.Utilities.Enums
{
    // Los enums son un tipo que nos permite guardar identificadores para posteriormente compararlos. 
    public class Enums : MonoBehaviour
    {
        // Para crear uno, se debe usar la palabra enum, el nombre y los valores.
        public enum Nombre
        {
            // Si ponen el mouse encima de los nombres, veran que tienen numeros asignados en orden de arriba hacia abajo.
            Rodrigo,
            Gonzalo,
            Marcelo,
            Perejil,
            Yogurlavia,

            // Pero si quisieran, podrian ponerle un indice ustedes mismos.
            Pikachu = 100
        }

        // Luego, al ser un tipo, podremos crear una variable de tipo enumerador, si no se le da ningun valor, el valor por defecto será 0, Rodrigo en este caso.
        public Nombre nombre;

        // En cambio si se le da un valor, ese será el valor por defecto.
        public Nombre nombre1 = Nombre.Marcelo;


        private void Start()
        {
            // Para utilizarlos, basta con hacer comparaciones, por ejemplo:
            // Si la variable nombre es igual al valor Rodrigo del enumerador Nombre, se ejecutará lo de dentro.
            if (nombre == Nombre.Rodrigo)
            {
                Debug.Log("Soy el profe");
            }

            // En cambio, si es Pikachu, se ejecutará el siguiente debug.
            else if (nombre == Nombre.Pikachu)
            {
                Debug.Log("Soy amarillo");
            }


            // Tambien lo pueden hacer dentro de un switch: 
            switch (nombre)
            {
                // En este caso si la variable nombre es Rodrigo, se ejecutará el debug y luego se dejará de ejecutar el switch gracias a break.
                case Nombre.Rodrigo:

                    Debug.Log("Soy el profe");
                    break;

                // En este caso, si es Pikachu, Gonzalo, o Marcelo, se ejecutará el siguiente debug.
                case Nombre.Pikachu:
                case Nombre.Gonzalo:
                case Nombre.Marcelo:
                    Debug.Log("Soy pikachu, gonzalo y marcelo");
                    break;

                // Y en el caso de no ser ninguno, ocurrirá esto.
                default:
                    Debug.Log("No soy ninguno jaja xd");
                    break;

            }


            // Esta es una manera un poco mas compleja pero rapida de implementar un switch.
            // Esto es algo mas nuevo y en versiones antiguas de visual studio (creo que < 2022) da error de compilación.

            // En este caso, crearé una variable de tipo string llamada texto y le asignaré su valor dependiendo del valor actual de la variable nombre.
            string texto = nombre switch
            {
                // Si nombre es igual a Nombre.Rodrigo, la variable texto valdrá "Me llamo rodrigo".
                Nombre.Rodrigo => "Me llamo rodrigo",
                Nombre.Gonzalo => "Soy gonzalo",

                // Y si no es ninguno de los anteriores, valdrá lo siguiente.
                _ => "No soy ninguno",
            };

            Debug.Log(texto);


            // Luego, pueden establecer el valor de la variable solo escribiendo:
            nombre = Nombre.Rodrigo;

            // Pero, tambien pueden convertir el numero asignado a cada valor utilizando una conversión
            // Las conversiones siempre se hacen utilizando parentesis y el tipo al que quieran convertir antes del valor.

            // En este caso, como Rodrigo es el indice 0, nombre valdrá Rodrigo.
            nombre = (Nombre)0;


            // Para obtener un arreglo de strings con cada uno de los identificadores, por ejemplo: ["Rodrigo", "Gonzalo", "Marcelo", ...]
            // se hace de la siguiente manera:
            //      Primero se crea la variable.
            //      Luego utilizamos la clase Enum de la libreria System y accedemos a la función GetNames.
            //      Dentro de esta le daremos el tipo del cual queremos obtener el arreglo, pero para ello no podemos utilizar solo el nombre del enumerador,
            //        ya que debe haber si o si una conversión utilizando la palabra clave "typeof"
            string[] nombresStrings = System.Enum.GetNames(typeof(Nombre));

            // Y en el caso de querer recibir un arreglo de los numeros de cada valor, seria: 
            int[] nombresInts = System.Enum.GetValues(typeof(Nombre)) as int[];

            // Posteriormente pueden recorrer todos los valores de ese arreglo con un foreach o con un for.
            // Esta no es la idea, ya que es preferible utilizar enums.
            foreach (string item in nombresStrings)
            {
                Debug.Log(item);
            }

            // La real utilidad, es que con ese arreglo, pueden obtener el numero total de enums.
            int total = nombresStrings.Length;
        }
    }
}