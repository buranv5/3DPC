using UnityEngine;

public class DialogueController : MonoBehaviour
{
    [SerializeField] private GameObject questPanel;
    [SerializeField] private Transform dialogueCameraPosition;
    [SerializeField] private ViewController viewController;
    [SerializeField] private HintController hintController;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            StartDialogue();
        }
    }

    private void StartDialogue()
    {
        questPanel.SetActive(true);
        viewController.SetDialogueMode(true);
        viewController.MoveToDialoduePosition(dialogueCameraPosition);
        hintController.DisableHint();
    }

    public void EndDialogue()
    {
        questPanel.SetActive(false);
        viewController.SetDialogueMode(false);
    }
}
