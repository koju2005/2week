using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class Item : MonoBehaviour
{
    public ItemSO itemSO;
//    private string name;
    private int atk;
    private int def;
    private int hp;
    private int cri;
    private int money;
    private bool IsEquip= false;
    private GameObject player;
    private GameObject EqSymbol;
    private GameObject sprite;
    private void Awake()
    {
        itemSO = GetComponent<Item>().itemSO;
        EqSymbol = GameObject.Find("Symbol");
        EqSymbol.SetActive(false);
        sprite = GameObject.Find("image");
    }
    private void Start()
    {
        player = GameManager.instance.Player;
        sprite.GetComponent<Image>().sprite = itemSO.Sprite;
        ItemStat();
    }

    private void ItemStat()
    {
        atk = itemSO.Atk;
        def = itemSO.Def;
        hp = itemSO.Hp;
        cri = itemSO.Cri;
        money = itemSO.Money;
      
    }

    public void Equip()
    {
        if (IsEquip == false)
        {
            player.GetComponent<Player>().OnItemEquipped?.Invoke(atk, def, hp, cri);
            EqSymbol.SetActive(true);
            IsEquip = true;
        }
        else if (IsEquip == true)
        {
            player.GetComponent<Player>().OnItemEquipped?.Invoke(-atk, -def, -hp, -cri);
            EqSymbol.SetActive(false);
            IsEquip = false;
        }
    }


}
