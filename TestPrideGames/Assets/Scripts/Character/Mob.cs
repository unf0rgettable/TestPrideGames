using UnityEngine;
using UnityEngine.AI;

namespace Character
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class Mob : Character
    {
        private NavMeshAgent _navMeshAgent;
        
        public override void Awake()
        {
            base.Awake();
            
            CharacterInput = GetComponent<AIInput>();
            _navMeshAgent = GetComponent<NavMeshAgent>();
        }

        private void Update()
        {
            if (CharacterInput.PointMove != Vector3.zero)
            {
                _navMeshAgent.SetDestination(CharacterInput.PointMove);
            }
            Animator.SetFloat("Speed", _navMeshAgent.velocity.magnitude);
        }
    }
}