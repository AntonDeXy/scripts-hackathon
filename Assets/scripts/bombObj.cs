using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombObj : MonoBehaviour
{
    private Animator anim;

    void Start() => anim = GetComponent<Animator>();
    
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Player") {
            anim.SetTrigger("boom");
            Destroy(gameObject);
        }
    }
}
