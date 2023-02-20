using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TauLeave : MonoBehaviour
{

    public Transform target;

    [SerializeField] private Animator animator;
    private NavMeshAgent agent;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (agent.velocity.magnitude > 0.1f)
        {
            animator.SetBool("Walking", true);
        }
        else
        {
            animator.SetBool("Walking", false);
        }
    }
        public void Leave()
    {
        if (target != null)
        {
            agent.SetDestination(target.position);
        }
    }
}

