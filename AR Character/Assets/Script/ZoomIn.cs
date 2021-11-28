using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomIn : MonoBehaviour
{
    public float objectScale;

    // Update is called once per frame
    void Update()
    {
        Zoom();
    }

    void Zoom()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            transform.localScale = new Vector3(transform.localScale.x + objectScale, transform.localScale.y + objectScale, transform.localScale.z + objectScale);
        }

        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            transform.localScale = new Vector3(transform.localScale.x - objectScale, transform.localScale.y - objectScale, transform.localScale.z - objectScale);
        }
    }
}
