using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public List<Item> Inventory;
    public int maxSpace = 30;
    private void Awake()
    {
        Inventory = new List<Item>();
    }
}
