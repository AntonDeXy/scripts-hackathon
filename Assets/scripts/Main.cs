using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    public static int coins;
    public Text coinsText;
    public List<Skin> shopItems = new List<Skin>();
    public Text[] shopItemsText;
    public List<Skin> boughtedSkins = new List<Skin>();

    private void Start()
    {
        
    }

    void Update()
    {
        updateCoinsCount();
    }

    public void updateCoinsCount ()
    {
        coinsText.text = coins.ToString();
    }
}

[Serializable]
public class Skin {
    public GameObject skin;
    public int price;
    public GameObject button;
}
