using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Clases.PA2024.Navigation
{
    public class AgentController : MonoBehaviour
    {
        // Variables
        [SerializeField] private NavMeshAgent m_agent;

        // Methods
        /// <summary>
        /// Reset is called when the user hits the Reset button in the Inspector's
        /// context menu or when adding the component the first time.
        /// </summary>
        private void Reset()
        {
            m_agent = GetComponent<NavMeshAgent>();
        }

        /// <summary>
        /// Set the destination point of the agent.
        /// </summary>
        public void MoveTo(Vector3 position)
        {
            m_agent.SetDestination(position);
        }
    }
}