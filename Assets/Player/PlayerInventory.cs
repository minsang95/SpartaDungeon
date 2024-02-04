using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public List<Item> Inventory;
    public int maxSpace = 60;
    private void Awake()
    {
        Inventory = new List<Item>();
    }
}
