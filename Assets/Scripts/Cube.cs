using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public Transform target;

    void Start()
    {

    }


    void Update()
    {
        float dist = Vector3.Distance(transform.position, target.position);

        if (dist < 6)
        {
            transform.localScale = new Vector3(2, 2, 2);
        }
        else
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
