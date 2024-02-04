using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject UIManager;
    [SerializeField] private GameObject Player;
    public PlayerStatusHandler _playerStatusHandler;
    public PlayerInventory _playerInventory;
    [SerializeField] private GameObject ItemSlot;
    public Transform Inventory;
    public List<Item> ShopItemList;
    [SerializeField] private GameObject ShopItemSlot;
    [SerializeField] private Transform ShopTransform;

    public int equipIndex;

    public static GameManager Instance;
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);

        _playerStatusHandler = Player.GetComponent<PlayerStatusHandler>();
        _playerInventory = Player.GetComponent<PlayerInventory>();
    }
    private void Start()
    {
        for(int i = 0; i < _playerInventory.maxSpace; i++)
        {
            Instantiate(ItemSlot, Inventory);
        }

        for(int i = 0; i < ShopItemList.Count; i++)
        {
            Instantiate(ShopItemSlot, ShopTransform);
        }
        UIManager.SetActive(true);
        Player.SetActive(true);
    }
}
