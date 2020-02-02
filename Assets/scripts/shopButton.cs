using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shopButton : MonoBehaviour
{
    public int id;
    public Text priceText;
    public SpriteRenderer spriteObj;
    private bool isUnique = true;

    void Start()
    {
        CheckSkinsForBough();
        CheckForActiveSkin();
    }

    private void CheckSkinsForBough ()
    {
        SkinItem obj = Main.skins[id];
        int price = obj.price;
        spriteObj.sprite = obj.skin;
        for (int i = 0; i < Main.skins.Count; i++)
        {
            if (Main.boughtedSkins.Count > i)
            {
                if (Main.boughtedSkins[i].id == obj.id)
                {
                    isUnique = false;
                    break;
                }
            }
        }
        if (isUnique)
            priceText.text = price.ToString() + "$";
        else
            priceText.text = "Bought";

    }

    public void Click()
    {
        if (Main.coins >= Main.skins[id].price && isUnique)
        {
            Main.coins -= Main.skins[id].price;
            Main.boughtedSkins.Add(Main.skins[id]);
            //print(Main.boughtedSkins[0].id);
            //for (int i = 0; i < Main.boughtedSkins.Count; i++)
            //{
              //  print(Main.boughtedSkins[i].id);
            //}
            CheckSkinsForBough();
        } else if (!isUnique)
        {
            player.CurrentSkin = Main.skins[id];
            CheckForActiveSkin();
            //setSkin as default
        }
    }

    public void CheckForActiveSkin()
    {
        //print (player.CurrentSkin.id);
        if (id == player.CurrentSkin.id)
            priceText.text = "Equiped";
        else
        {
            for (int i = 0; i < Main.boughtedSkins.Count; i++)
            {
                if (Main.boughtedSkins[i].id == id)
                    priceText.text = "Bought";
                else 
                    for (int j = 0; j < Main.skins.Count; i++)
                    {
                        if (Main.skins[j].id == id)
                            priceText.text = Main.skins[j].price.ToString();

                    }

            }
        }
    }

    void Update()
    {
        
    }
}
