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

    private void OnTriggerEnter(Collider other) //Destr�i objeto ap�s colidir com outro objeto colisor.
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
