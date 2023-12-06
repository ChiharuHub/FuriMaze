using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour
{
    void Update()
    {
        this.transform.position +=
             this.transform.position * 0.01f;
    }

    void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.tag == "Wall")
        {
            if(Random.Range(1,10) < 6)
            {
                this.transform.Rotate(0, 90, 0);
            }
            else
            {
                this.transform.Rotate(0, -90, 0);
            }
        }
    }
}
