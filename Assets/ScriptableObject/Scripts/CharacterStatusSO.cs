using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DefaultStatusData", menuName = "SpartaDungeonSO/Status/Default")]
public class CharacterStatusSO : ScriptableObject
{
    [Header("CharacterSprite")]
    public Sprite characterSprite;
    [Header("Status")]
    public float maxHealth;
    public float atk;
    public float def;
    public float speed;
    public int level;
    public float exp;
    public float gold;
    public bool equipHelmet = false;
    public bool equipArmor = false;
    public bool equipBoots = false;
    public bool equipWeapon = false;
    public bool equipRing = false;
}
