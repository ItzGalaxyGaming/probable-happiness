using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Clases.PA2024.Generics
{
    public class EnemyBehaviour : MonoBehaviour, IDamageable
    {
        // Variables

        // Methods
        /// <summary>
        /// Receive damage and drop loot.
        /// </summary>
        public void GetDamage()
        {
            Destroy(gameObject);
        }
    }
}
