using System;
using UnityEngine;

public class Trigger : MonoBehaviour
{

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("Player"))
            Debug.Log("Hit " + hit.gameObject.name);
    }

    void OnCollisionEnter(Collision other)
    {
        Debug.Log("Hit");
    }
}
