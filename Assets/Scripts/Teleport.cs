using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

enum positionState { INSIDE, OUTSIDE };

public class Teleport : MonoBehaviour
{
    public InputActionReference action;
    public Transform platformTransform;

    positionState positionState = positionState.INSIDE;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        action.action.Enable();
        action.action.performed += (ctx) =>
        {
            if (positionState == positionState.INSIDE)
            {
                positionState = positionState.OUTSIDE;
                transform.position = new Vector3(platformTransform.position.x, transform.position.y, platformTransform.position.z);
            }
            else
            {
                positionState = positionState.INSIDE;
                transform.position = new Vector3(0, 0, 0);
            }
        };
    }
}
