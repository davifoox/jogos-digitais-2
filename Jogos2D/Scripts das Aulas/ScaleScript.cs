using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleScript : MonoBehaviour
{

    private Transform transf;
    public float maxScale = 5.0f;
    public float minScale = 1.0f;
    private float shrinkSpeed = 2.0f;
    private float targetScale;
    private Vector3 vScale;

    void Update()
    {
        RaycastHit2D hit;

        if (Input.GetMouseButtonDown(1))
        {
            hit = Physics2D.Raycast
                (Camera.main.ScreenToWorldPoint(Input.mousePosition),
                Vector2.zero);
            if(hit.transform != null)
            {
                if(hit.transform == transform)
                {
                    print("player diminuindo");
                    transf = hit.transform;
                    targetScale = minScale;
                    vScale = new Vector2(targetScale, targetScale);
                }
                else
                {
                    print("nao encontrou o objeto");
                }
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition),
                Vector2.zero);
            if(hit.transform != null)
            {
                if(hit.transform == transform)
                {
                    print("player aumentando");
                    transf = hit.transform;
                    targetScale = maxScale;
                    vScale = new Vector2(
                        targetScale,
                        targetScale);
                }
                else
                {
                    print("nao encontrou o objeto");
                }
            }
        }

        if(transf != null)
        {
            transf.localScale = Vector3.Lerp(transf.localScale,
                vScale,
                Time.deltaTime * shrinkSpeed);
        }

    }

    
}
