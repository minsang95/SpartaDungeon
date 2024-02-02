using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CharacterType
{
    Àü»ç,
    ±Ã¼ö,
}
public enum StatusChangeType
{
    Add,
    Multiple,
    Override,
}
[Serializable]
public class PlayerStatus
{
    public StatusChangeType changeType;
    public CharacterType characterType;
    public string name;
    public float maxExp;

    public CharacterStatusSO statusSO;

    public void Init()
    {
        statusSO.maxHealth = 100;
        statusSO.atk = 10;
        statusSO.def = 5;
        statusSO.speed = 5;
        statusSO.level = 1;
        statusSO.exp = 5;
        maxExp = 30;
        statusSO.gold = 20000;
    }
}
