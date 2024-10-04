using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Clases.PA2024.Generics
{
    // Aca estoy creando una clase serializable (se puede ver en el inspector)
    // Y podre crear esta clase en cada uno de los objetos que yo quiera que dropeen loot en momentos especificos.
    // Puede ser al morir, como tambien puede ser en cada golpe que le demos a una roca gigante.
    [System.Serializable]
    public class Drop
    {
        // Classes
        // Aca estoy creando una clase generica que me permitira crear una variable
        // de tipo SOItem sin definir especificamente cual.
        // Al hacer esto, nos quita de encima tener que repetir codigo muchas veces 
        // por ejemplo, un LootMaterial, LootIngredient, LootWeapon.
        // Sumado a eso podemos añadir mas variables, por ejemplo, una cuenta total de 
        // objetos que seran dropeados o la chance de ser dropeados.
        [System.Serializable]
        public class Loot<T> where T : SOItem
        {
            // Variables
            [SerializeField] private T scriptable;
            [SerializeField] private int count;
            [SerializeField] private int chance;

            // Properties
            public T Scriptable => scriptable;
            public int Count => count;
            public int Chance => chance;
        }

        // Variables
        // Luego aca puedo crear una lista de loots y establecer especificamente
        // cada scriptable que quiero que ahora la instancia de la clase Loot tenga dentro.
        // Esto convertirá la T en SOMaterial
        [SerializeField] private List<Loot<SOMaterial>> materials;

        // Esto convertirá la T en SOIngredient
        [SerializeField] private List<Loot<SOIngredient>> ingredients;

        // Esto convertirá la T en SOWeapon
        [SerializeField] private List<Loot<SOWeapon>> weapons;

        // Methods
        // Posteriormente tendré una funcion llamada Create, la cual en la practica
        // será un instanciador de objetos, o los añadirá directamente a nuestro inventario.
        // y cada una de estas variables las podre utilizar dependiendo del valor que yo le haya dado.
        public void Create()
        {
            // Por ejemplo, aca estoy accediendo a cada uno de los Loot con un generico de tipo SOMaterial
            // Gracias a eso puedo utilizar las variables que estan dentro de cada scriptable siendo que nunca
            // especifique cual.
            foreach (Loot<SOMaterial> material in materials)
            {
                Debug.Log($"Cree {material.Count} materiales con el nombre {material.Scriptable.name}");
                Debug.Log($"La rareza de mi material actual es: {material.Scriptable.Rarity}");

                // Aca podria instanciar un prefab al que le asignaria el scriptable actual y cuantos has obtenido.
                // Lo que, al interactuar con este objeto, podria mostrar un texto y añadirlo al inventario.
                // Por ejemplo: "¡Has conseguido 10 de madera!"
            }

            // Puedo hacer lo mismo con los ingredientes
            foreach (Loot<SOIngredient> ingredient in ingredients)
            {
                Debug.Log($"Cree {ingredient.Count} ingredientes con el nombre {ingredient.Scriptable.name}");
            }

            // Y con las armas.
            foreach (Loot<SOWeapon> weapon in weapons)
            {
                Debug.Log($"Cree {weapon.Count} armas con el nombre {weapon.Scriptable.name}");
            }
        }

    }
}