using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SlimeState_Idle : SlimeStateBase
{
    public float timeToWalk;

    private float currentTime;

    public override void Enter()
    {
        base.Enter();
        currentTime = timeToWalk;
        Debug.Log("Me quede quieto");

    }

    public override void Logic()
    {
        base.Logic();

        if (DetectPlayer())
        {
            Controller.stateMachine.SwitchState(Controller.states.followPlayer);
        }

        currentTime -= Time.deltaTime;
        if (currentTime <= 0)
        {
            Controller.stateMachine.SwitchState(Controller.states.patrol);
        }
    }
}
