using System.Linq;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lambda : MonoBehaviour
{
    List<Vehicle> vehicles;

    public void Update()
    {
        foreach (var c in vehicles)
        {
            Debug.Log(c.name);
        }

        vehicles.ForEach(c => Debug.Log(c.name));

        vehicles.ForEach(c => c.gameObject.SetActive(false));

        OnHealthChange += Lambda_OnHealthChange;
        OnHealthChange += health => health++;


        // Linq
        // ordenar de 0 hacia arriba
        vehicles = vehicles.OrderBy( c => c.score ).ToList();

        // ordenamos de arriba hacia abajo (0)
        vehicles = vehicles.OrderByDescending( c => c.score ).ToList();

        // crear una lista utilizando todos los vehiculos que estan muertos
        List<Vehicle> deadVehicles = vehicles.FindAll( c => c.isDead == true ).ToList();

        // contar cuantos vehiculos estan muertos
        int vehiclesDeadsCount = vehicles.Count( c => c.isDead );

        // buscar un objeto que se llame rodrigo
        Vehicle rodrigoVehicle = vehicles.Find( c => c.name == "Rodrigo" );

    }

    private void Lambda_OnHealthChange(int health)
    {
        health ++;
    }


    public event System.Action<int> OnHealthChange;

}


public class Vehicle : MonoBehaviour
{
    public float score;
    public bool isDead;
    public string nombre;

    private void Update()
    {
        score += Time.deltaTime;
    }
}
