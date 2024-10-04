using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Clases.PA2024.Generics
{
    public class EnemyBehaviour : MonoBehaviour, IDamageable
    {
        // Variables
        [SerializeField] private Drop m_drop;

        // Methods
        /// <summary>
        /// Receive damage and drop loot.
        /// </summary>
        public void GetDamage()
        {
            m_drop.Create();
            Destroy(gameObject);
        }
    }
}
