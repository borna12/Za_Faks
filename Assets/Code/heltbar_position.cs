using UnityEngine;
using System.Collections;

public class heltbar_position : MonoBehaviour
{
    public GameObject objectTarget;
    public Vector3 screenPosition = new Vector3(0, 0, 20);

    // Use this for initialization
    void Update()
    {

        if (objectTarget != null)
        {
            objectTarget.transform.position = camera.ScreenToWorldPoint(screenPosition);
        }

    }
}
