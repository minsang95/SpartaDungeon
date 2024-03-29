using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    [Header("Player")]
    [SerializeField] private GameObject Player;
    public SpriteRenderer CharacterSprite;
    public PlayerStatusHandler _playerStatusHandler;
    [Header("Inventory")]
    public int InventoryMaxSpace = 30;
    [SerializeField] private GameObject ItemSlot;
    public Transform ItemSlotTransform;
    public List<Item> Inventory;
    [Header("Shop")]
    public List<Item> ShopItemList;
    [SerializeField] private GameObject ShopItemSlot;
    [SerializeField] private Transform ShopTransform;
    [Header("-")]
    [SerializeField] private GameObject UIManager;
    public int equipIndex;
    public int itemIndex;

    public static GameManager Instance;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);

        _playerStatusHandler = Player.GetComponent<PlayerStatusHandler>();
    }
    // 인벤토리, 상점 슬롯 생성
    private void Start()
    {
        for(int i = 0; i < InventoryMaxSpace; i++)
        {
            Instantiate(ItemSlot, ItemSlotTransform);
        }

        for(int i = 0; i < ShopItemList.Count; i++)
        {
            Instantiate(ShopItemSlot, ShopTransform);
        }
        UIManager.SetActive(true);
        Player.SetActive(true);
    }
}
