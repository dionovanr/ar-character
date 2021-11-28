using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabRotation : MonoBehaviour
{
    public float rotationSpeed = 1f;

    private void OnMouseDrag()
    {
        float xRotation = Input.GetAxis("Mouse X") * rotationSpeed;
        transform.Rotate(Vector3.down, xRotation);
    }

   
}
