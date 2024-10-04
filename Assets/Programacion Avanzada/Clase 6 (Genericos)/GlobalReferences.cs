using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Clases.PA2024.Generics
{
    // Este componente podria ser utilizado para obtener todos los scriptables
    // existentes en mi juego sin la necesidad de referenciarlos en distintos scripts.
    // Es mejor tener un lugar donde obtener todos los assets centralizados, a que 
    // tener 10 listas de lo mismo por distintos objetos, sumado a que si añadimos
    // un nuevo asset, deberemos ponerlo en las distintas listas, y no queremos eso.
    public class GlobalReferences : Singleton<GlobalReferences>
    {
        // Variables
        // Las listas son clases genericas.
        [SerializeField] private List<SOMaterial> materials;
        [SerializeField] private List<SOWeapon> weapons;
        [SerializeField] private List<SOIngredient> ingredients;

        protected override bool Persistent => false;

        // Properties

        // Methods
        // Gracias a esta funcion generica, yo podre buscar en cada una de las listas
        // existentes un item en especifico que se llame igual a la variable ID.

        // public T             Esta funcion sera publica y nos devolvera un objeto de tipo T
        // Get<T>               Esto nos permite convertir una funcion en una funcion generica
        // List<T>              Esta sera la lista en la que buscaremos el objeto que queramos
        // where T : SOItem     Esto limitará a que el generico si o si debe heredar de SOItem
        //                      lo que nos permitirá acceder a las variables que esten implementadas
        //                      en SOItem, por ejemplo, un ID, un total, etcetera.
        public T Get<T>(List<T> list, string ID) where T : SOItem
        {
            // Luego esto me permitira recorrer cada uno de los objetos de la lista 
            // y nos devolverá el primer objeto en el cual el valor de su variable
            // ID sea equivalente al ID que estamos buscando.
            foreach (T item in list)
            {
                if (item.ID == ID) return item;
            }

            // Si no encuentra nada, nos devolvera null.
            return null;
        }

        // Luego gracias a esto, solo creamos nuevas funciones para el tipo especifico
        // de SOItem que estemos buscando y ejecutamos la funcion Get.
        public SOMaterial GetMaterial(string ID) => Get(materials, ID);
        public SOWeapon GetWeapon(string ID) => Get(weapons, ID);
        public SOIngredient GetIngredient(string ID) => Get(ingredients, ID);

        // Si no utilizaramos genericos esto se veria asi, y a pesar de que funciona,
        // piensen en hacer esto pero con 15 tipos de scriptables distintos.

        // public SOMaterial GetMaterial(string ID)
        // {
        //     foreach (SOMaterial item in materials)
        //     {
        //         if (item.ID == ID) return item;
        //     }

        //     return null;
        // }

        // public SOIngredient GetIngredient(string ID)
        // {
        //     foreach (SOIngredient item in ingredients)
        //     {
        //         if (item.ID == ID) return item;
        //     }

        //     return null;
        // }

        // public SOWeapon GetWeapon(string ID)
        // {
        //     foreach (SOWeapon item in weapons)
        //     {
        //         if (item.ID == ID) return item;
        //     }

        //     return null;
        // }

    }
}
