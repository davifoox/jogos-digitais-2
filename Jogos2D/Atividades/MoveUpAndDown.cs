using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpAndDown : MonoBehaviour
{
    float speed = 1f;
    int direction = 1;
    public float limitRigh = 12f;
    public float limitLeft = -12f;

    private void Update()
    {
        if (transform.position.x > limitRigh)
            direction = -1;
        else if(transform.position.x < limitLeft)
            direction = 1;

        transform.position += new Vector3(speed * direction * Time.deltaTime, Mathf.Sin(Time.time) /65, 0);
    }
}
