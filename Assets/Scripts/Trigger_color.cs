using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_color : MonoBehaviour
{
    public GameObject the_capsule;
    void OnTriggerEnter(Collider target)
    {
        if(target.tag == "Player")
            {   
                the_capsule.GetComponent<Renderer>().material.color =
                new Color(
                Random.Range(0.0f, 1.0f),
                Random.Range(0.0f, 1.0f),
                Random.Range(0.0f, 1.0f)
            );
        }

    }

}
