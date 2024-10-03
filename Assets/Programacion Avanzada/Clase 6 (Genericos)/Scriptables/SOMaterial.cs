using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Clases.PA2024.Generics
{
    [CreateAssetMenu(menuName = "Clase/PA2024/Generics/Material", fileName = "Material")]
    public class SOMaterial : SOItem
    {
        // Variables
        [Header("Settings")]
        [SerializeField] private string m_name;
        [SerializeField] private int m_rarity;

        // Properties
        public string Name => m_name;
        public int Rarity => m_rarity;
    }
}
