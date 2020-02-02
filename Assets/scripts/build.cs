using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class build : MonoBehaviour
{
    private Animator anim;
    public AudioClip fix;
    void Start() => anim = GetComponent<Animator>();
    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Main.PlayAudio(fix);
            Main.coins += 10;
            anim.SetTrigger("fix");
        }
    }
}
