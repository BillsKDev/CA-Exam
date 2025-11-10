using System;
using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshController : MonoBehaviour
{
    public GameObject Target;
    private NavMeshAgent agent;
    public GameObject Sword;
    Animator animator;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }
    void Update()
    {

        agent.destination = Target.transform.position;
        if (agent.remainingDistance <= agent.stoppingDistance)
            animator.SetBool("IsWalking", false);

    }

    private void OnTriggerEnter(Collider other)     
    {
            Destroy(other.gameObject);
            Debug.Log("Hit");
    }

    void OnTriggerStay(Collider other)
    {
            Destroy(other.gameObject);
            Debug.Log("Hit");
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Target")
        {           
        }
    }

}
