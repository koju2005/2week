using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Status", menuName = "Scriptable Object/Status", order = int.MaxValue)]
public class Status : ScriptableObject
{
    [Header("PlayerStatus")]
    public int ATK;
    public int DEF;
    public int HP;
    public int CRI;
    public int MONEY;
}
