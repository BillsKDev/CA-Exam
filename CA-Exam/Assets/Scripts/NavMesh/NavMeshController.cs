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
        if (other.CompareTag("Sword"))
        {
            Debug.Log("Hit");
        }
        if (other.name == "Hammer")
        {
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Target")
        {           
            //edit here
        }
    }

}
