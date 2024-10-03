using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Clases.PA2024.Generics
{
    [CreateAssetMenu(menuName = "Clase/PA2024/Generics/Weapon", fileName = "Weapon")]
    public class SOWeapon : SOItem
    {
        // Variables
        [Header("Settings")]
        [SerializeField] private string m_name;
        [SerializeField] private int m_rarity;
        [SerializeField] private int m_damage;

        // Properties
        public string Name => m_name;
        public int Rarity => m_rarity;
        public int Damage => m_damage;
    }
}
