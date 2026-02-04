using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnifyingGlass : MonoBehaviour
{
    public Transform mainCamera;
    public Transform magnifyingGlassCameraTransform;
    public Camera magnifyingGlassCameraCamera;
    public Transform lens;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //magnifyingGlassCamera.rotation = mainCamera.rotation;
        magnifyingGlassCameraTransform.LookAt(lens);
        magnifyingGlassCameraCamera.nearClipPlane = Vector3.Distance(magnifyingGlassCameraTransform.position, lens.position);
    }
}
