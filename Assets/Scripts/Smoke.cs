using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smoke : MonoBehaviour
{
    public Vector3 speed;
    public Vector3 acceleration;
    public Vector3 randomness;
    Vector3 rotationSpeed;
    public float rotationMultiplier;

    public float lifeTime;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = lifeTime;

        acceleration.x += Random.Range(-randomness.x, randomness.x);
        acceleration.y += Random.Range(-randomness.y, randomness.y);
        acceleration.z += Random.Range(-randomness.z, randomness.z);

        rotationSpeed.x += Random.Range(-randomness.x, randomness.x) * rotationMultiplier;
        rotationSpeed.y += Random.Range(-randomness.y, randomness.y) * rotationMultiplier;
        rotationSpeed.z += Random.Range(-randomness.z, randomness.z) * rotationMultiplier;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += speed * Time.deltaTime;
        speed += acceleration * Time.deltaTime;
        timer -= Time.deltaTime;
        transform.Rotate(rotationSpeed * Time.deltaTime);

        if (timer < 0)
        {
            Destroy(gameObject);
        }
    }
}
