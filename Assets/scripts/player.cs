using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public static bool lose = false;

    public int lives = 3;
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    public GameObject Restart;
    public static SkinItem CurrentSkin;
    public SpriteRenderer Skin;
    private Animator anim;

    public AudioClip bomb, heal;

    private void Awake()
    {
        // CurrentSkin = Main.boughtedSkins[0]  ;
        // Skin = gameObject.GetComponent<SpriteRenderer>(); 
        lose = false;
        Restart.SetActive(false);
        // Skin.sprite = CurrentSkin.skin;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "bomb") {
            Main.PlayAudio(bomb);
            // other.gameObject.SetActive(false);
            anim = other.gameObject.GetComponent<Animator>();
            anim.SetTrigger("boom");
            StartCoroutine(DeleteObj(other.gameObject));
            lives--;
            updateHearts();
        } else if (other.gameObject.tag == "heal")
        {
            Main.PlayAudio(heal);
            StartCoroutine(DeleteObj(other.gameObject));
            if (lives < 3)
                lives++;
            updateHearts();
        }
    }

    private void updateHearts()
    {
        if (lives <= 0)
        {
            lose = true;
            Restart.SetActive(true);
        }
        if (lives == 3)
        {
            heart3.SetActive(true);
            heart2.SetActive(true);
            heart1.SetActive(true);
        }
        if (lives == 2)
        {
            heart3.SetActive(false);
        }
        else if (lives == 1)
        {
            heart3.SetActive(false);
            heart2.SetActive(false);
        }
        else if (lives <= 0)
        {
            heart3.SetActive(false);
            heart2.SetActive(false);
            heart1.SetActive(false);
        }
    }

    IEnumerator DeleteObj(GameObject obj) {
        yield return new WaitForSeconds(0.5f);
        obj.SetActive(false);
    }
}
