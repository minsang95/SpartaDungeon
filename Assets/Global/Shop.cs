using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public List<Item> ShopItemList;
    private void Awake()
    {
        ShopItemList = new List<Item>();
    }
}
