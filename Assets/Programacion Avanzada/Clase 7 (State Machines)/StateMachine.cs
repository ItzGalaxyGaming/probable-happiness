using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StateMachine<TState, TController> : MonoBehaviour
where TState : StateBase<TController>
where TController : MonoBehaviour
{
    [SerializeField] private bool m_debugMode = false;

    private TState currentState;

    public void SwitchState(TState newState)
    {
        if (m_debugMode)
        {
            Debug.Log($"{gameObject.name} changed its state from: {currentState} to {newState}");
        }

        if (currentState != null) currentState.Exit();
        currentState = newState;
        if (currentState != null) currentState.Enter();
    }

    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    private void Update()
    {
        if (currentState != null)
        {
            currentState.Logic();
        }
    }

    /// <summary>
    /// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
    /// </summary>
    private void FixedUpdate()
    {
        if (currentState != null)
        {
            currentState.FixedLogic();
        }
    }
}