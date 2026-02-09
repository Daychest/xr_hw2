using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnifyingGlass : MonoBehaviour
{
    public Transform mainCamera;
    public Transform magnifyingGlassCameraTransform;
    public Camera magnifyingGlassCameraCamera;
    public Transform lens;
    public Transform lens2;
    // Start is called before the first frame update
    void Start()
    {        
        lens.transform.rotation = Quaternion.Inverse(lens.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        magnifyingGlassCameraTransform.LookAt(lens);
        lens.LookAt(magnifyingGlassCameraTransform);
        magnifyingGlassCameraCamera.nearClipPlane = Vector3.Distance(magnifyingGlassCameraTransform.position, lens.position);
    }
}
