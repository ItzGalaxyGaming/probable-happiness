using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Clases.PA2024.Management
{
    public class PlayerController : MonoBehaviour
    {
        // Variables
        [Header("Settings")]
        [SerializeField] private float m_speed = 4f;

        [Header("References")]
        [SerializeField] private CharacterController m_characterController;

        // Methods
        /// <summary>
        /// This function is called when the object becomes enabled and active.
        /// </summary>
        private void OnEnable()
        {
            GameManager.OnStateChange += OnStateChange;
        }

        /// <summary>
        /// This function is called when the behaviour becomes disabled or inactive.
        /// </summary>
        private void OnDisable()
        {
            GameManager.OnStateChange -= OnStateChange;
        }

        /// <summary>
        /// Update is called every frame, if the MonoBehaviour is enabled.
        /// </summary>
        private void Update()
        {
            if (GameManager.CurrentState != GameState.Gameplay) return;

            Vector3 input = Vector3.zero;
            input.x = Input.GetAxisRaw("Horizontal");
            input.z = Input.GetAxisRaw("Vertical");

            m_characterController.Move(input * m_speed * Time.deltaTime);

            if (Input.GetKeyDown(KeyCode.G))
            {
                OnDeath();
            }
        }

        public void OnDeath()
        {
            GameManager.SwitchState(GameState.GameOver);
        }

        private void OnStateChange(GameState state)
        {
            if (state == GameState.GameOver)
            {
                Debug.Log("Game over");
            }
            else if (state == GameState.Victory)
            {
                Debug.Log("Victory");
            }
        }
    }
}