using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EquipmentType
{
    Helmet,
    Armor,
    Boots,
    Weapon,
    ring,
}
public enum AddStat
{
    Atk,
    Def,
    Health,
    Speed,
}

[CreateAssetMenu(fileName = "EquipmentItemData", menuName = "SpartaDungeonSO/Item/Equipment")]
public class EquipmentItemSO : ItemSO
{
    public EquipmentType equipmentType;
    public AddStat addStat;
    public Sprite addStatSprite;
    public float addSize;
}
