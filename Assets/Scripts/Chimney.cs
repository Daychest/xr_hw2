using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chimney : MonoBehaviour
{
    public GameObject smokePoint;
    public GameObject smokeObject;
    public float smokeCooldown;
    float timer = 0;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            timer = smokeCooldown;
            Instantiate(smokeObject, smokePoint.transform.position, Quaternion.identity);
        }

        

        
    }
}
