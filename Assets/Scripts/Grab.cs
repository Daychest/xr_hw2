using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Grab : MonoBehaviour
{
    public InputActionReference action;
    public Transform controller;
    public Transform thingToGrab;
    Vector3 grabPositionOffset;
    Vector3 grabRotationOffset;

    // Start is called before the first frame update
    void Start()
    {
        grabPositionOffset = new Vector3(0, -0.02f, 0.2f);
        grabRotationOffset = new Vector3(90, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        action.action.Enable();


        if (action.action.IsPressed())
        {
            thingToGrab.position = controller.position;
            thingToGrab.rotation = controller.rotation;
            thingToGrab.Rotate(grabRotationOffset);
        }

    }
}
