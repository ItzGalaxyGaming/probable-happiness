using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Clases.PA2024.Generics
{
    public class BreakableBehaviour : MonoBehaviour, IDamageable
    {
        // Variables

        // Methods
        /// <summary>
        /// Break the pot when receives damage and drop a loot.
        /// </summary>
        public void GetDamage()
        {
            Destroy(gameObject);
        }
    }
}
