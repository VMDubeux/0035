using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [Header("GameObject:")]
    public GameObject[] AnimalPrefabs;
    
    //Private Variables:
    private sbyte _rangeX = 11;
    private sbyte _rangeZ = 20;
    private sbyte _spawnDelay = 2;
    private float _spawnRepeatTime = 1.5f;
   
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", _spawnDelay, _spawnRepeatTime);
    }

    void Update()
    {

    }

    void SpawnRandomAnimal() 
    {
        int _animalIndex = Random.Range(0, AnimalPrefabs.Length);
        Vector3 _animalStartPosition = new Vector3(Random.Range(-_rangeX, _rangeX), 0, _rangeZ);

        Instantiate(AnimalPrefabs[_animalIndex], _animalStartPosition, AnimalPrefabs[_animalIndex].transform.rotation);
    }
}
