using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observador : MonoBehaviour
{
    public Transform playerTransform;
    public float speedMovement = 0.2f;

    void Update()
    {
        Vector3 relativePos = playerTransform.position - transform.position;

        float angle = Mathf.Atan2(relativePos.y, relativePos.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        transform.position = Vector2.Lerp(transform.position, playerTransform.position,
            Time.deltaTime * speedMovement);
    }
}
