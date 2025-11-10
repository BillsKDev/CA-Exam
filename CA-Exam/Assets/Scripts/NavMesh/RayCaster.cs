using UnityEngine;

public class RayCaster : MonoBehaviour
{
    [SerializeField] GameObject target;
    private Camera cam;
    [SerializeField] Animator animator;
    
    void Start()
    {
        cam = Camera.main;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                target.transform.position = hit.point;
                animator.SetBool("IsWalking", true);
            }       
        }
    }
}
