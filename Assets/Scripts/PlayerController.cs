using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("GameObject:")]
    public GameObject PizzaPrefab;

    //Private variables:
    [SerializeField] private float _speed = 17.5f;
    private float _inputHorizontal;

    void Start()
    {

    }

    void Update()
    {
        switch (transform.position.x)
        {
            case < - 12:
                transform.position = new Vector3(-12, transform.position.y, transform.position.z);
                break;
            case > 12:
                transform.position = new Vector3(12, transform.position.y, transform.position.z);
                break;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(PizzaPrefab, transform.position, PizzaPrefab.transform.rotation);
        }

        _inputHorizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * _inputHorizontal * Time.deltaTime * _speed);
    }
}
