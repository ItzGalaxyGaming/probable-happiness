using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Clases.PA2024.Generics
{
    [CreateAssetMenu(menuName = "Clase/PA2024/Generics/Ingredient", fileName = "Ingredient")]
    public class SOIngredient : SOItem
    {
        // Variables
        [Header("Settings")]
        [SerializeField] private string m_name;
        [SerializeField] private Sprite m_icon;
        [SerializeField] private int m_defaultCount;

        // Properties
        public string Name => m_name;
        public Sprite Icon => m_icon;
        public int DefaultCount => m_defaultCount;
    }
}
