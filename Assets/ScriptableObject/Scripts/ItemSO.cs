using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum ItemType
{
    Equipment,
    Consumables,
    Etc,
}
public class ItemSO : ScriptableObject
{
    public string itemName;
    public string itemDescription;
    public Sprite itemSprite;
    public ItemType itemType;
    public int price;
}
