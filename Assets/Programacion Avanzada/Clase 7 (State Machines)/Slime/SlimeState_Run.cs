using UnityEngine;

namespace Clases.PA2024.StateMachines
{
    [System.Serializable]
    public class SlimeState_Run : SlimeStateBase
    {
        [SerializeField] private float m_speed = 2;

        public override void Enter()
        {
            base.Enter();

            var state = Controller.States.Idle;
            Controller.StateMachine.SwitchState(state);
        }
    }
}
