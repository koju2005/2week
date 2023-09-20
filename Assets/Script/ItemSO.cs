using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Item", menuName = "Scriptable Object/Item", order = int.MinValue)]
public class ItemSO : ScriptableObject
{
    [Header("Item Info")]
    public string Name;
    public int Atk;
    public int Def;
    public int Hp;
    public int Cri;
    public int Money;
    public Sprite Sprite;
}
