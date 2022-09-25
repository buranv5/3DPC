using DG.Tweening;
using System;
using UnityEngine; 
 
public class ViewController : MonoBehaviour 
{ 
    [SerializeField] private new Camera camera;
    [SerializeField] private float sensitivity;
    [SerializeField] private float cameraMovingTime;

    [HideInInspector] public bool inDialogue = false;

    private float cameraDistance = -5;
    public Transform cameraTransform => camera.transform;
    private Transform cameraParent => camera.transform.parent;
    private Transform body => cameraParent.parent;

    private void Update()
    {
        if (inDialogue)
            return;

        body.Rotate(0, Input.GetAxis("Mouse X") * sensitivity, 0);
        cameraParent.localEulerAngles += new Vector3(-Input.GetAxis("Mouse Y") * sensitivity, 0, 0);
         
        cameraDistance += Input.mouseScrollDelta.y / 50;
        cameraTransform.DOLocalMove(new Vector3(1, 0, cameraDistance), Time.deltaTime * 5);
        cameraTransform.DOLocalRotate(Vector3.zero, Time.deltaTime * 5);
    }

    public void SetDialogueMode(bool isModeActive)=>
        inDialogue = isModeActive;

    public void MoveToDialoduePosition(Transform transform, Action callback = null)
    {
        cameraTransform.DOMove(transform.position, cameraMovingTime);
        cameraTransform.DORotate(transform.eulerAngles, cameraMovingTime);
    }
}
