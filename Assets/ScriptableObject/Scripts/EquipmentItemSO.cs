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

[CreateAssetMenu(fileName = "DefaultItemData", menuName = "SpartaDungeonSO/Item/Default")]
public class EquipmentItemSO : ItemSO
{
    public EquipmentType equipmentType;
    public int atk;
    public int def;
    public int health;
    public float speed;
}
