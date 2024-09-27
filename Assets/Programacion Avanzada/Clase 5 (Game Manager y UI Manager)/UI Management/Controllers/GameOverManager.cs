using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Clases.PA2024.Management
{
    // Este GameOverManager cambiará nuestro panel de la UI a "Game Over"
    // cuando detecte que el estado del GameManager cambio a GameOver.
    public class GameOverManager : MonoBehaviour
    {
        private void OnEnable()
        {
            GameManager.OnStateChange += OnStateChange;
        }

        private void OnDisable()
        {
            GameManager.OnStateChange -= OnStateChange;
        }

        private void OnStateChange(GameState state)
        {
            if (state == GameState.GameOver)
            {
                UIManager.Instance.SwitchPanel("Game Over");
            }
        }
    }
}