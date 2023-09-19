using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
   private UIManager i;
    private GameObject statusUI;
    private GameObject Btns;
    private void Awake()
    {
        i = this;
        statusUI = GameObject.Find("Status");
        Btns = GameObject.Find("Btns");
    }

    private void Start()
    {
       statusUI.SetActive(false);
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
}
