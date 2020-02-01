using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    public static int coins;
    public Text coinsText;

    void Update()
    {
        updateCoinsCount();
    }

    public void updateCoinsCount ()
    {
        coinsText.text = coins.ToString();
    }
}
