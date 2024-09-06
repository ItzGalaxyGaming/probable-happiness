using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diccionarios : MonoBehaviour
{
    // es una lista pero a la que le pueden dar un identificador a cada item
    // los diccionarios no son serializables, por lo tanto, no se van a ver en el inspector

    private EnemyController enemyPrefab;
    private Dictionary<string, EnemyController> enemyDictionary;

    private void Start()
    {
        var enemy1 = Instantiate(enemyPrefab);
        enemyDictionary.Add("Rodrigo", enemy1);

        var enemy2 = Instantiate(enemyPrefab);
        enemyDictionary.Add("Gonzalo", enemy2);

        var enemy3 = Instantiate(enemyPrefab);
        enemyDictionary.Add("Marcelo", enemy3);



        if (enemyDictionary.TryGetValue("Marcelo", out EnemyController item))
        {
            item.ShowHealth();
        }

        // obtener el total
        enemyDictionary.Count;

        // un arreglo de llaves, identificadores, strings
        enemyDictionary.Keys;

        // un arreglo con todos los valores, en este caso, enemigos
        enemyDictionary.Values

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
