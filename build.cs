using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class build : MonoBehaviour
{
    private Animator anim;

    void Start() => anim = GetComponent<Animator>();

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "player")
        {
            Main.coins += 10;
            anim.SetTrigger("fix");
        }
    }
}
