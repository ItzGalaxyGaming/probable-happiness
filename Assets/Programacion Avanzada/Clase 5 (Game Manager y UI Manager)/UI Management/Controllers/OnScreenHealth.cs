using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Clases.PA2024.Management
{
    public class OnScreenHealth : MonoBehaviour
    {
        // Variables
        [Header("References")]
        [SerializeField] private Image m_healthFill;

        // Methods
        /// <summary>
        /// This function is called when the object becomes enabled and active.
        /// </summary>
        private void OnEnable()
        {
            PlayerController.OnHealthChange += OnHealthChange;
        }

        /// <summary>
        /// This function is called when the behaviour becomes disabled or inactive.
        /// </summary>
        private void OnDisable()
        {
            PlayerController.OnHealthChange -= OnHealthChange;
        }

        // Esta funcion se ejecuta cuando cambia la vida del jugador.
        private void OnHealthChange(int health, int maxHealth)
        {
            m_healthFill.fillAmount = (float)health / maxHealth;
        }
    }
}