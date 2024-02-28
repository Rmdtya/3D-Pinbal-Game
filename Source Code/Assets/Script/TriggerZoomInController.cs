using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoomInController : MonoBehaviour
{
    // Start is called before the first frame update
    public Collider bola;
    public CameraController cameraController;
    public float length;
    private void OnTriggerEnter(Collider other)
    {
        if (other == bola)
        {
            cameraController.FollowAtTarget(bola.transform, length);
        }
    }
}
