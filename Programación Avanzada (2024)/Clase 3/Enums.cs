using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Enums : MonoBehaviour
{
    public enum Nombre
    {
        Rodrigo,
        Gonzalo,
        Marcelo,
        Perejil,
        Yogurlavia,
        Pikachu
    }

    public Nombre nombre;

    private void Start()
    {
        // ifs
        if (nombre == Nombre.Rodrigo)
        {
            Debug.Log("Soy el profe");
        }
        else if (nombre == Nombre.Pikachu)
        {
            Debug.Log("Soy amarillo");
        }


        // Switch
        switch (nombre)
        {
            case Nombre.Rodrigo:

                Debug.Log("Soy el profe");
                break;

            case Nombre.Pikachu:
            case Nombre.Gonzalo:
            case Nombre.Marcelo:
                Debug.Log("Soy pikachu, gonzalo y marcelo");
                break;

            default:
                Debug.Log("No soy ninguno jaja xd");

        }


        // switch 2.0
        string texto = nombre switch
        {
            Nombre.Rodrigo => "Me llamo rodrigo",
            Nombre.Gonzalo => "Soy gonzalo",
            _ => "No soy ninguno",
        };

        Debug.Log(texto);


        // Conversion
        nombre = Nombre.Rodrigo;
        nombre = (Nombre)0;


        // Total
        string[] nombresStrings = System.Enum.GetNames( typeof( Nombre ) );

        foreach ( string item in nombresStrings )
        {
            Debug.Log(item);
        }
    }
}