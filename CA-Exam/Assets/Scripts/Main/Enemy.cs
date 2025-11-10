using System;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    private NavMeshAgent agent;
    public GameObject Target;
    Animator animator;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Chasing");
            agent.destination = Target.transform.position - Vector3.back;
            if (agent.remainingDistance <= agent.stoppingDistance)
                animator.SetBool("IsWalking", false);
        }
    }
}
