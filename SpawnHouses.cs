using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHouses : MonoBehaviour
{
    public GameObject house;
    float randX;
    Vector2 SpawnPlace;
    public float SpawnRate = 5f;
    float NextSpawn = 0.0f;

    void Start()
    {

    }

    void Update()
    {
        if(Time.time > NextSpawn)
        {
            NextSpawn = Time.time + SpawnRate;
            randX = Random.Range(-8.4f, 8.4f);
            SpawnPlace = new Vector2(randX, transform.position.y);
            Instantiate(house, SpawnPlace, Quaternion.identity);
        }
    }
}