using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonOrbit : MonoBehaviour
{
    public Transform transform;
    float angle = 0;
    float radius = 4;

    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        angle -= 1f * Time.deltaTime;
        Vector3 position = transform.parent.position;
        position.x += Mathf.Cos(angle) * radius;
        position.z += Mathf.Sin(angle) * radius;
        transform.position = position;

    }
}
