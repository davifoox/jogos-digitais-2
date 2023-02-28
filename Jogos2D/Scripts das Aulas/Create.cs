using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour
{
    public GameObject dog;
    public int numDogs = 5;

    void Start()
    {
        for(int i = 0; i < numDogs; i++)
        {
            Instantiate(dog, new Vector3(0.2f + (i * 2),
                (0.03f * i), 0f),
                Quaternion.identity);
        }
    }
}
