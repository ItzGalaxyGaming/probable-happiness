using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MouseRaycaster : MonoBehaviour
{
    // Variables
    [Header("Events")]
    [SerializeField] private UnityEvent<Vector3> m_onTap;

    // Methods
    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePosition = Input.mousePosition;
            Ray ray = Camera.main.ScreenPointToRay(mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                m_onTap?.Invoke(hit.point);
            }
        }
    }
}
