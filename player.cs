using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public static bool lose = false;
    public GameObject Restart;

    private void Awake()
    {
        lose = false;
        Restart.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "bomb") { 
            lose = true;
            Restart.SetActive(true);
        }
    }
}
