using UnityEngine;

namespace Clases.PA2024.StateMachines
{
    [System.Serializable]
    public class SlimeState_Idle : SlimeStateBase
    {
        [SerializeField] private float m_idleTime = 2;

        public override void Enter()
        {
            base.Enter();

            var state = Controller.States.Run;
            Controller.StateMachine.SwitchState(state);
        }
    }
}
