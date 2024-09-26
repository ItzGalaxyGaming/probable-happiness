using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Clases.PA2024.Delegates
{
    // Esta seria una clase la cual utiliza un evento de C# comun y corriente
    // el problema aqui es que:
    public class EventoComun : MonoBehaviour
    {
        // Este evento, donde quiero recibir 3 enteros, por ejemplo, daño, vida actual, vida maxima, es muy dificil de entender.
        // Y si por ejemplo, copiara este evento en otra clase, si lo quisiera modificar, tendria que hacerlo en los dos (o mas) scripts a la vez.
        public static event System.Action<int, int, int> OnDamageReceived;

        public int maxHealth;
        public int health;

        public void GetDamage(int damage)
        {
            // Para ejecutar el evento, solo se debe utilizar el Invoke y enviar el numero de parametros pedidos.
            // El signo ? significa, siempre y cuando no sea null, en este caso, para que solo se ejecute si hay mas de 0 clases suscritas a este evento.
            OnDamageReceived?.Invoke(damage, health, maxHealth);
        }
    }


    // En cambio, dentro de esta clase crearemos un delegate, el cual por decirlo de una manera muy resumida
    // es una manera de juntar eventos iguales, ponerles un nombre y mostrar que significa cada parametro.
    public class Delegates : MonoBehaviour
    {
        // Para crearlo solo hay que crear una función sin contenido pero antes poner delegate, de esta manera:
        public delegate void DamageReceivedCallback(int damage, int health, int maxHealth);

        // Y luego para utilizarlo, en vez de System.Action<int, int, int> se utilizaria el nombre de la función delegate que creamos anteriormente
        public static event DamageReceivedCallback OnDamageReceived;

        public int maxHealth;
        public int health;

        public void GetDamage(int damage)
        {
            // Y para ejecutarlo, se hace de la misma manera que un System.Action
            OnDamageReceived?.Invoke(damage, health, maxHealth);
        }
    }
}