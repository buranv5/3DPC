using UnityEngine;

public class MovementController : MonoBehaviour
{
    [SerializeField] private float walkSpeed;
    [SerializeField] private float runSpeed;
    [SerializeField] private Animator animator;
    [SerializeField] private ViewController viewController;

    private void Update()
    {
        if (viewController.inDialogue)
            return;

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        if (x != 0 || z != 0)
            animator.SetBool("IsMove", true);
        else
            animator.SetBool("IsMove", false);
        
        transform.Translate(new Vector3(x, 0f, z) * (Input.GetKey(KeyCode.LeftShift)? runSpeed : walkSpeed) * Time.deltaTime);
    }

}
