using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class TransformInterpolation : MonoBehaviour
{
    // Variables
    [Header("References")]
    [SerializeField] private Transform m_toInterpolate;
    [Space]
    [SerializeField] private Transform m_originPoint;
    [SerializeField] private Transform m_destinationPoint;

    [Header("Variables")]
    [SerializeField][Range(0, 1f)] private float m_interpolationValue;

    // Methods
    /// <summary>
    /// This function is called when the object becomes enabled and active.
    /// </summary>
    private void OnEnable()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.update += Update;
#endif
    }

    /// <summary>
    /// This function is called when the behaviour becomes disabled or inactive.
    /// </summary>
    private void OnDisable()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.update -= Update;
#endif
    }

    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    private void Update()
    {
        if (!m_toInterpolate) return;
        if (!m_originPoint) return;
        if (!m_destinationPoint) return;

        m_toInterpolate.position = Vector3.Lerp(m_originPoint.position, m_destinationPoint.position, m_interpolationValue);
    }
}