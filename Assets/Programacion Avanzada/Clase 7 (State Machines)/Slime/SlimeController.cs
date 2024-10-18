using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Clases.PA2024.StateMachines
{
    public class SlimeController : MonoBehaviour
    {
        // Variables
        [Header("States")]
        [SerializeField] private SlimeStateMachine stateMachine;
        [SerializeField] private SlimeStateFactory states;

        // Properties
        public SlimeStateMachine StateMachine => stateMachine;
        public SlimeStateFactory States => states;

        // Methods
        /// <summary>
        /// Start is called on the frame when a script is enabled just before
        /// any of the Update methods is called the first time.
        /// </summary>
        private void Start()
        {
            states.Initialize(this);
            stateMachine.SwitchState(states.Idle);
        }
    }
}