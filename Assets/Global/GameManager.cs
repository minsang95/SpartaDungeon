using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject UIManager;
    [SerializeField] private GameObject Player;
    [SerializeField] private Item[] Items;
    public PlayerStatusHandler _playerStatusHandler;
    public PlayerInventory _playerInventory;
    [SerializeField] private GameObject ItemSlot;
    [SerializeField] private Transform Inventory;
    public Shop _shop;
    [SerializeField] private GameObject ShopItemSlot;
    [SerializeField] private Transform ShopTransform;

    public static GameManager Instance;
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);

        _playerStatusHandler = Player.GetComponent<PlayerStatusHandler>();
        _playerInventory = Player.GetComponent<PlayerInventory>();
        _shop = GetComponent<Shop>();
    }
    private void Start()
    {
        for(int i = 0; i < _playerInventory.maxSpace; i++)
        {
            Instantiate(ItemSlot, Inventory);
        }

        for(int i = 0; i < Items.Length; i++)
        {
            Instantiate(ShopItemSlot, ShopTransform);
            _shop.ShopItemList.Add(Items[i]);
        }
        UIManager.SetActive(true);
        Player.SetActive(true);
    }
}
