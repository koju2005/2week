using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.Events;
using static UnityEditor.Progress;

public class Player : MonoBehaviour
{
    [SerializeField] Status Playerstatus;
    public int ATK;
    public int DEF;
    public int HP;
    public int CRI;
    public int MONEY;
    public int EXP;
    public Action<int, int, int, int> OnItemEquipped;
    private void Awake()
    {
        OnItemEquipped += HandleItemEquipped;

    }
    private void Start()
    {
        UpdateStat();
    }
    private void UpdateStat()
    {
        ATK = Playerstatus.ATK;
        DEF = Playerstatus.DEF;
        HP = Playerstatus.HP;
        CRI = Playerstatus.CRI;
        MONEY = Playerstatus.MONEY;
    }
    private void HandleItemEquipped(int atkDelta, int defDelta, int hpDelta, int criDelta)
    {
        ATK += atkDelta;
        DEF += defDelta;
        HP += hpDelta;
        CRI += criDelta;
        AnimationManager.instance.EquipAnimation();
    }
}
