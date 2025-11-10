using UnityEngine;

public class Player : MonoBehaviour
{
    Animator animator;
    float targetBlend = 0f;
    public float blendSpeed = 5f; 
    
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            targetBlend = 0f;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            targetBlend = 0.5f;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            targetBlend = 1f;
        }
        float currentBlend = animator.GetFloat("Blend");
        float newBlend = Mathf.Lerp(currentBlend, targetBlend, blendSpeed * Time.deltaTime);
        animator.SetFloat("Blend", newBlend);
    }
}