using UnityEngine;

[System.Serializable]
public class SlimeState_FollowPlayer : SlimeStateBase
{
    public override void Enter()
    {
        base.Enter();

        //Controller.Rigidbody.velocity = Vector3.forward;
    }

    public override void Logic()
    {
        base.Logic();

        Debug.Log("Me estoy moviendo hacia el jugador");

        if (Random.Range(0, 10) == 0)
        {
            Debug.Log("Perdi de vista al jugador");
            Controller.stateMachine.SwitchState(Controller.states.idle);
        }
    }

    public override void Exit()
    {
        base.Exit();

        //Controller.Rigidbody.velocity = Vector3.zero;
    }
}