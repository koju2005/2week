using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Progress;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI ATKtext;
    [SerializeField] private TextMeshProUGUI DEFtext;
    [SerializeField] private TextMeshProUGUI HPtext;
    [SerializeField] private TextMeshProUGUI CRItext;
    [SerializeField] private TextMeshProUGUI Moneytext;
    [SerializeField] private TextMeshProUGUI EXPtext;
    private UIManager i;
    private GameObject statusUI;
    private GameObject itemUI;
    private GameObject Btns;
    private GameObject player;
    private void Awake()
    {
        i = this;
        statusUI = GameObject.Find("Status");
        itemUI = GameObject.Find ("Inventory");
        Btns = GameObject.Find("Btns");
        player = GameManager.instance.Player;
        player.GetComponent<Player>().OnItemEquipped += UpdateText;
    }

    private void Start()
    {
        statusUI.SetActive(false);
        itemUI.SetActive(false);
        UpdateText(player.GetComponent<Player>().ATK, player.GetComponent<Player>().DEF, player.GetComponent<Player>().HP, player.GetComponent<Player>().CRI);
        MoneyUI();
    }

    public void stausUIActive()
    {
        statusUI.SetActive(true);
        Btns.SetActive(false);
    }
    public void stausUIActiveFalse()
    {
        statusUI.SetActive(false);
        Btns.SetActive(true);
    }
    public void InventoryUIActive()
    {
        itemUI.SetActive(true);
        Btns.SetActive(false);
    }
    public void InventoryUIActivefalse()
    {
        itemUI.SetActive(false);
        Btns.SetActive(true);
    }

    private void UpdateText(int atk,int def,int hp,int cri)
    {
        ATKtext.text = player.GetComponent<Player>().ATK.ToString();
        DEFtext.text = player.GetComponent<Player>().DEF.ToString();
        HPtext.text = player.GetComponent<Player>().HP.ToString();
        CRItext.text = player.GetComponent<Player>().CRI.ToString();
    }

    private void MoneyUI()
    {
        Moneytext.text = player.GetComponent<Player>().MONEY.ToString();
    }
}
