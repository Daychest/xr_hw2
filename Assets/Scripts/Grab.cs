using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Grab : MonoBehaviour
{
    public InputActionReference action;
    public Transform controller;
    public Transform thingToGrab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        action.action.Enable();


        if (action.action.IsPressed())
        {
            thingToGrab.position = controller.position;
            thingToGrab.rotation = controller.rotation;
            thingToGrab.Rotate(90, 0, 0);
        }

    }
}
