using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxBG : MonoBehaviour
{

    public GameObject cam;
    private float length;
    private float startPosition;
    public float parallaxEffect;

    void Start () {

    startPosition = transform.position.x;
    length = GetComponent<SpriteRenderer>().bounds.size.x;
    
    }

    private void FixedUpdate()
    {
        float temp = (cam.transform.position.x *(1- parallaxEffect))
        float dist = (cam.transform.position.x * parallaxEffect);

        transform.position = new Vector3(startPosition + dist, transform.position.y, transform.position.z);
        
        if (temp > startPosition + length)
            startPosition += length;
        else if (temp < startPosition - length)
            startPosition -= length;
        
    }
}
