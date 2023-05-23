using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    private float _topBound = 30.0f;
    private float _bottomBound = -10.0f;

    void Start()
    {

    }

    void Update()
    {
        if (transform.position.z > _topBound) //Destr�i objeto ap�s passar da borda superior.
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < _bottomBound) //Destr�i objeto ap�s passar da borda inferior e, quando acontece, faz aparecer a mensagem "Game Over".
        {
            Debug.Log("Game Over");
            Destroy(gameObject);
        }
    }
}
