using UnityEngine;

public class HintController : MonoBehaviour
{
    [SerializeField] private Canvas hintCanvas;
    [SerializeField] private DialogueController dialogueController;

    private Transform player;
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out ViewController vc))
        {
            hintCanvas.gameObject.SetActive(true);
            player = vc.cameraTransform;
            dialogueController.enabled = true;
        }
    }

    private void Update()
    {
        if (player != null)
        {
            hintCanvas.transform.LookAt(player.position);
            hintCanvas.transform.eulerAngles += new Vector3(0, 180, 0);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        DisableHint();
    }

    public void DisableHint()
    {
        hintCanvas.gameObject.SetActive(false);
        dialogueController.enabled = false;
    }
}
