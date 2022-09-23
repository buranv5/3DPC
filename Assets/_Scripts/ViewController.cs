using DG.Tweening; 
using UnityEngine; 
 
public class ViewController : MonoBehaviour 
{ 
    [SerializeField] private new Camera camera; 
    [SerializeField] private Transform cameraTarget;
    
    public float Sensitivity;

    private float cameraDistance;
    private Transform cameraTransform => camera.transform;
    private Transform cameraParent => camera.transform.parent;
    private Transform body => cameraTarget.parent;
     
    private void Update() 
    {
        body.Rotate(0, Input.GetAxis("Mouse X") * Sensitivity, 0);
        cameraParent.localEulerAngles += new Vector3(-Input.GetAxis("Mouse Y") * Sensitivity, 0, 0);

        cameraDistance += Input.mouseScrollDelta.y / 50;
        cameraTransform.localPosition = new Vector3(cameraTransform.localPosition.x, cameraTransform.localPosition.y, cameraDistance);
    } 
} 
 