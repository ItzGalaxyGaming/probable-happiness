using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Dentro de la libreria linq, se pueden encontrar muchas funciones que nos sirven para muchas situaciones llenas de lambdas dentro de las listas o arreglos.
using System.Linq;

public class Lambda : MonoBehaviour
{
    List<Vehicle> vehicles;

    public void Update()
    {
        // Por ejemplo podemos:

        // Ordenar todos los vehiculos dependiendo de la puntuación de ellos.
        vehicles = vehicles.OrderBy(c => c.score).ToList();

        // Hacer lo mismo pero en orden descendente.
        vehicles = vehicles.OrderByDescending(c => c.score).ToList();

        // Crear una lista utilizando todos los vehiculos que estan muertos
        List<Vehicle> deadVehicles = vehicles.FindAll(c => c.isDead == true).ToList();

        // Contar cuantos vehiculos estan muertos
        int vehiclesDeadsCount = vehicles.Count(c => c.isDead);

        // Buscar un objeto que se llame rodrigo
        Vehicle rodrigoVehicle = vehicles.Find(c => c.nombre == "Rodrigo");

    }
}


public class Vehicle : MonoBehaviour
{
    public string nombre;
    public bool isDead;
    public float score;

    private void Update()
    {
        score += Time.deltaTime;
    }
}
