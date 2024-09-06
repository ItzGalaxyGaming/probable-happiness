using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventoComun : MonoBehaviour
{
    public static event System.Action<int, int, int> OnDamageReceived;

    public int maxHealth;
    public int health;

    public void GetDamage(int damage)
    {
        OnDamageReceived?.Invoke(damage, health, maxHealth);
    }
}



public class Delegates : MonoBehaviour
{
    public static event DamageReceivedCallback OnDamageReceived;

    public int maxHealth;
    public int health;

    public void GetDamage(int damage)
    {
        OnDamageReceived?.Invoke(damage, health, maxHealth);
    }
    
    public delegate void DamageReceivedCallback(int damage, int health, int maxHealth);
}