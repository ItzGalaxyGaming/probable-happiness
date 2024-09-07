using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Lambda nos permite crear funciones anonimas que no requieren de un nombre y nos permite hacer cosas de esta manera.
public class Lambda : MonoBehaviour
{
    public List<Vehicle> vehicles;

    public void Update()
    {
        // Si quisieramos mostrar la variable nombre de cada vehiculo, deberiamos hacer un foreach.
        foreach (var vehicle in vehicles)
        {
            Debug.Log(c.nombre);
        }

        // Y si quisieramos desactivar todos los objetos de la lista, seria asi:
        foreach (var vehicle in vehicles)
        {
            vehicle.gameObject.SetActive(false);
        }

        // Pero, en listas, podemos utilizar lambda para crear un foreach de una sola linea o incluso mas.
        // Aca se utiliza la función ForEach, y nos permite:
        //     Por cada item dentro de la lista, crear una variable llamada c de tipo Vehicle.
        //     Luego utilizaremos la expresión lambda => para ejecutar una funcion anonima posterior al simbolo.
        //     En este caso, haré un debug con la variable nombre de cada vehiculo, en este caso, c
        vehicles.ForEach(c => Debug.Log(c.nombre));

        //      Y acá seria lo mismo pero en vez de mostrar un debug, desactivaré el gameObject de cada c.
        vehicles.ForEach(c => c.gameObject.SetActive(false));


        // Otra funcionalidad está en los eventos de C#
        // Si nosotros quisieramos utilizar un evento de C#, deberiamos crear una función con el o los parametro requeridos.
        Enemy.OnHealthChange += Lambda_OnHealthChange;


        // En cambio, si quisieramos crear funciones anonimas, podemos hacerlo
        // En esta funcion, desactivaré mi objeto cuando reciba que el enemigo murio.
        Enemy.OnDead += () => gameObject.SetActive(false);

        // En este caso, estoy suscribiendome al evento de C# y le estoy diciendo que, el parametro que recibiré 
        // se llamará c, y haré un debug con ese parametro.
        Enemy.OnHealthChange += (c) => Debug.Log(c);

        // Y si es mas de un parametro:
        Enemy.OnStateChange += (c, d) => Debug.Log($"El enemigo llamado: {c}, cambio su estado a {(d ? "vivo" : "muerto")}");


        // Y por ultimo, y el mas complejo, es cuando quieres usar una función con mas de los parametros requeridos.
        Enemy.OnStateChange += (c, d) => Lambda_OnEnemyStateChange(c, d, gameObject);

    }

    private void Lambda_OnHealthChange(int health)
    {
        health++;
    }

    private void Lambda_OnEnemyStateChange(string name, bool dead, GameObject thisObject)
    {
        Debug.Log($"El enemigo llamado: {c}, cambio su estado a {(d ? "vivo" : "muerto")} y el nombre de mi objeto es: {thisObject.name} ");
    }
}


public class Vehicle : MonoBehaviour
{
    public string nombre;
}

public class Enemy : MonoBehaviour
{
    public static event System.Action OnDead;
    public static event System.Action<int> OnHealthChange;
    public static event StateChangeCallback OnStateChange;

    public delegate void StateChangeCallback(string name, bool dead);
}