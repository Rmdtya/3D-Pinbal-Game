using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public KeyCode input;
    private HingeJoint hinge;
    public float springPower;

    // Start is called before the first frame update
    private void Start()
    {
        hinge = GetComponent<HingeJoint>();
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
            joinSprint.spring = springPower;
        }
        else
        {
            joinSprint.spring = 0;
        }

        GetComponent<HingeJoint>().spring = joinSprint;
    }
}
