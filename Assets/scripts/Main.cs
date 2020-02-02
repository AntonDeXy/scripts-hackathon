using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    public static int coins;
    public GameObject playerObj;
    public Text coinsText;
    [SerializeField]
    public List<SkinItem> shopItems = new List<SkinItem>();
    public static List<SkinItem> boughtedSkins = new List<SkinItem>();
    public static List<SkinItem> skins;
    public GameObject ShopPanel;
    public GameObject Restart;
    //public AudioSource AudioSourceObj;
    public static AudioSource sounds;

    void Update () {
        updateCoinsCount();
    }
    private void Awake()
    {
        // skins = shopItems;
        // player.CurrentSkin = skins[0];
        // boughtedSkins.Add(skins[0]);
        updateCoinsCount();
    }
    public void ShowAndHideStore ()
    {
        playerObj.SetActive(ShopPanel.activeSelf); 
        player.lose = !ShopPanel.activeSelf;
        if (ShopPanel.activeSelf)
            SceneManager.LoadScene("main");
        print(player.lose);
        ShopPanel.SetActive(!ShopPanel.activeSelf);
    }
    private void Start()
    {
        sounds = GetComponent<AudioSource>();
    }

    public void updateCoinsCount ()
    {
        coinsText.text = coins.ToString();
    }

    public static void PlayAudio (AudioClip clip)
    {
        Main.sounds.PlayOneShot(clip); 
    }
}

[Serializable]
public class SkinItem {
    public int id;
    public Sprite skin;
    public GameObject prefab;
    public int price;
    public GameObject button;
}
