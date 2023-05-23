using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
               
    }

    private void OnTriggerEnter(Collider other) //Destrói objeto após colidir com outro objeto colisor.
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
