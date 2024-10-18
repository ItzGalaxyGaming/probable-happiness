using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Clases.PA2024.StateMachines
{
    [System.Serializable]
    public class SlimeStateFactory : StateFactory<SlimeController>
    {
        // Variables
        [SerializeField] private SlimeState_Idle m_idle;
        [SerializeField] private SlimeState_Run m_run;

        // Properties
        public SlimeState_Idle Idle => m_idle;
        public SlimeState_Run Run => m_run;

        // Methods
        public override void Initialize(SlimeController controller)
        {
            m_idle.Initialize(controller);
            m_run.Initialize(controller);
        }
    }
}