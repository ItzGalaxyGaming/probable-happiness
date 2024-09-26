using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Clases.PA2024.Dictionaries
{
    public class Diccionarios : MonoBehaviour
    {
        // Un diccionario es una lista pero a la que le pueden dar un identificador a cada item
        // Los diccionarios no son serializables, por lo tanto, no se van a ver en el inspector

        private EnemyController enemyPrefab;

        // Para crear un diccionario se debe utilizar el tipo Dictionary y darle dos parametros genericos:
        //  El primero, Key, seria el tipo de identificador con el que vamos a obtener el valor de la "lista",
        //      en este caso, al utilizar string, yo podria obtener un enemigo utilizando "Javier", en vez de el indice.
        // El segundo, Value, sería el objeto que guardaré en la "lista". 
        private Dictionary<string, EnemyController> enemyDictionary;

        private void Start()
        {
            // Acá por ejemplo, instanciaré un enemigo desde el prefab y lo añadiré al diccionario con el identificador "Rodrigo"
            EnemyController enemy1 = Instantiate(enemyPrefab);
            enemyDictionary.Add("Rodrigo", enemy1);

            // Acá instanciaré otro y lo añadiré al diccionario con el identificador "Gonzalo"
            EnemyController enemy2 = Instantiate(enemyPrefab);
            enemyDictionary.Add("Gonzalo", enemy2);

            // Acá instanciaré otro y lo añadiré al diccionario con el identificador "Marcelo"
            EnemyController enemy3 = Instantiate(enemyPrefab);
            enemyDictionary.Add("Marcelo", enemy3);

            // Entonces, ahora yo podré obtener el enemigo que yo quiera dependiendo de su nombre
            // La función TryGetValue devuelve un booleano con el que podremos comparar si se encontró un objeto o no con ese identificador
            // Y si es asi, gracias a la palabra clave, out, nos devolverá una nueva variable de tipo EnemyController llamado item.
            if (enemyDictionary.TryGetValue("Marcelo", out EnemyController item))
            {
                // Acá mostraré un debug de la vida del enemigo 3, identificado en el diccionario como Marcelo.
                item.ShowHealth();
            }

            // Luego hay ciertas funciones utiles, por ejemplo:

            // Obtener la cuenta de cuantos objetos hay en nuestro diccionario.
            int enemyCount = enemyDictionary.Count;

            // Obtener una lista solo de Keys, en este caso, strings.
            var keys = enemyDictionary.Keys;

            // Obtener una lista solo de Values, en este caso, todos los EnemyControllers.
            var values = enemyDictionary.Values;
        }

    }

    public class EnemyController : MonoBehaviour
    {
        public int health;

        public void ShowHealth()
        {
            Debug.Log(health);
        }
    }
}