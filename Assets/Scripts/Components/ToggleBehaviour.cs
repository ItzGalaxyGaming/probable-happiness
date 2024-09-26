using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleBehaviour : MonoBehaviour
{
    // Variables
    [SerializeField] private KeyCode m_key = KeyCode.Space;
    [SerializeField] private GameObject m_toAlternate;

    // Methods
    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    private void Update()
    {
        if (Input.GetKeyDown(m_key))
        {
            bool state = !m_toAlternate.activeSelf;
            m_toAlternate.SetActive(state);
        }
    }
}
