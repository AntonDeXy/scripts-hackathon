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
        print("click");
        if (Main.coins >= Main.skins[id].price && isUnique)
        {
            Main.coins -= Main.skins[id].price;
            Main.boughtedSkins.Add(Main.skins[id]);
            print(Main.boughtedSkins[0].id);
            for (int i = 0; i < Main.boughtedSkins.Count; i++)
            {
                print(Main.boughtedSkins[i].id);
            }
            print("//////////");
            CheckSkinsForBough();
        }
    }
    void Update()
    {
        
    }
}
