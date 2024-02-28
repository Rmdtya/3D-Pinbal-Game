using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public KeyCode input;
    private HingeJoint hinge;
    private float targetPressed;
    private float targetRelease;

    // Start is called before the first frame update
    private void Start()
    {
        hinge = GetComponent<HingeJoint>();

        targetPressed = hinge.limits.max;
        targetRelease = hinge.limits.min;
    }

    // Update is called once per frame
    private void Update()
    {
        ReadInput();
    }

    private void ReadInput()
    {

        JointSpring joinSprint = hinge.spring;
        if (Input.GetKey(input))
        {
            joinSprint.targetPosition = targetPressed;
        }
        else
        {
            joinSprint.targetPosition = targetRelease;
        }

        GetComponent<HingeJoint>().spring = joinSprint;
    }
}
