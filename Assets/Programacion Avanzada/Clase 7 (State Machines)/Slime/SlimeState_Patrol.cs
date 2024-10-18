using UnityEngine;

[System.Serializable]
public class SlimeState_Patrol : SlimeStateBase
{
    public float walkTime;

    private float currentTime;

    public override void Enter()
    {
        base.Enter();
        currentTime = walkTime;
        Debug.Log("Me estoy empezando a mover aleatoriamente hacia un punto");
    }

    public override void Logic()
    {
        base.Logic();

        if (DetectPlayer())
        {
            Controller.stateMachine.SwitchState(Controller.states.followPlayer);
        }

        Debug.Log("Me estoy moviendo");

        currentTime -= Time.deltaTime;
        if (currentTime <= 0)
        {
            Controller.stateMachine.SwitchState(Controller.states.idle);
        }
    }
}

