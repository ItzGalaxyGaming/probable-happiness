using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeController : MonoBehaviour
{
    public SlimeStateMachine stateMachine;
    public SlimeStateFactory states;

    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        states.Initialize(this);
        stateMachine.SwitchState(states.idle);
    }

    public void GetDamage()
    {
        Debug.Log("Solo tengo un punto de vida asi que me mori");
        stateMachine.SwitchState(states.death);
    }
}
