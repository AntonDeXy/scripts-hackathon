using System;
using System.Collections    ;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class houses : MonoBehaviour
{
    public List<Item> houseList = new List<Item>();
    private void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while(!player.lose)
        {
            int index = Random.Range(0, houseList.Count);
            Instantiate(houseList[index].house, new Vector2 (Random.Range(-2f, 2f), 5.5f), Quaternion.identity);
            yield return new WaitForSeconds(0.5f);
        }
    }
}
[Serializable]
public class Item
{
    public GameObject house;
    public bool destroyeded;
}
