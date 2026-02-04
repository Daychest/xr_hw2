using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnifyingGlass : MonoBehaviour
{
    public Transform mainCamera;
    public Transform magnifyingGlassCamera;
    public Transform lense;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //magnifyingGlassCamera.rotation = mainCamera.rotation;
        magnifyingGlassCamera.LookAt(lense);
    }
}
