using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DefaultStatusData", menuName = "SpartaDungeonSO/Status/Default")]
public class CharacterStatusSO : ScriptableObject
{
    [Header("CharacterSprite")]
    public Sprite characterSprite;
    [Header("Status")]
    public int maxHealth;
    public int atk;
    public int def;
    public int speed;
    public int level;
    public float exp;
    public int gold;
    public bool equipHelmet = false;
    public bool equipArmor = false;
    public bool equipBoots = false;
    public bool equipWeapon = false;
    public bool equipRing = false;
    public bool equipRing2 = false;
}
