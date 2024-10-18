using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomController : MonoBehaviour
{
    public CustomStateMachine stateMachine;
    public CustomStateFactory states;

    private void Awake()
    {
        states.Initialize(this);
    }
}
