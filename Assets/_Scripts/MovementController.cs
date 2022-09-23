using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    [SerializeField] private float speed;

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(-transform.forward);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(-transform.right);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(transform.right);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(transform.forward);
        }
    }

}
