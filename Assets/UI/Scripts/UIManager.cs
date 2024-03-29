using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TMP_Text characterType;
    [SerializeField] private TMP_Text playerName;
    [SerializeField] private TMP_Text characterLevel;
    [SerializeField] private TMP_Text characterExp;
    [SerializeField] private TMP_Text playerGold;
    [SerializeField] private TMP_Text atk;
    [SerializeField] private TMP_Text def;
    [SerializeField] private TMP_Text hp;
    [SerializeField] private TMP_Text speed;
    [SerializeField] private RectTransform currentExpBar;
    [SerializeField] private GameObject inventory;
    [SerializeField] private TMP_Text inventoryText;
    [SerializeField] private GameObject shopItemList;
    [SerializeField] private GameObject Popup;
    [SerializeField] private TMP_Text popupName;
    [SerializeField] private TMP_Text popupMessage;
    [SerializeField] private Button popupConfirmBtn;
    [SerializeField] private Button popupCancelBtn;
    [SerializeField] private GameObject equipPopup;
    [SerializeField] private Image equipItemSprite;
    [SerializeField] private TMP_Text equipItemText;
    [SerializeField] private Image equipItemStatSprite;
    [SerializeField] private TMP_Text equipItemStatText;

    public static UIManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        SetStatusUI();
        SetInventory();
        SetShop();
    }
    // UI 활성화, 비활성화
    public void OnOffUI(GameObject ui)
    {
        ui.SetActive(!ui.activeSelf);
    }
    // 팝업 활성화
    public void OnPopup(string popupname, string message, bool confirmOrCancel)
    {
        Popup.SetActive(true);
        popupName.text = popupname;
        popupMessage.text = message;
        if (confirmOrCancel)
        {
            popupConfirmBtn.gameObject.SetActive(true);
            popupCancelBtn.gameObject.SetActive(false);
        }
        else
        {
            popupConfirmBtn.gameObject.SetActive(false);
            popupCancelBtn.gameObject.SetActive(true);
        }
    }
    // 장착 팝업 활성화
    public void OnEquipPopup(int index)
    {
        equipPopup.SetActive(true);
        equipItemSprite.sprite = GameManager.Instance.Inventory[index].itemSO.itemSprite;
        equipItemText.text = $"<size=48><b>{GameManager.Instance.Inventory[index].itemSO.itemName}</size></b>\n{GameManager.Instance.Inventory[index].itemSO.itemDescription}";
        equipItemStatSprite.sprite = GameManager.Instance.Inventory[index].itemSO.addStatSprite;
        equipItemStatText.text = $"<size=24>{GameManager.Instance.Inventory[index].itemSO.addStat}</size>\n{GameManager.Instance.Inventory[index].itemSO.addSize}";
    }
    // 스테이터스 UI 초기화
    public void SetStatusUI()
    {
        GameManager.Instance.CharacterSprite.sprite = GameManager.Instance._playerStatusHandler.currentStatus.statusSO.characterSprite;
        characterType.text = GameManager.Instance._playerStatusHandler.currentStatus.characterType.ToString();
        playerName.text = GameManager.Instance._playerStatusHandler.currentStatus.name;
        characterLevel.text = "Lv " + GameManager.Instance._playerStatusHandler.currentStatus.statusSO.level.ToString();
        characterExp.text = GameManager.Instance._playerStatusHandler.currentStatus.statusSO.exp.ToString() + " / " + GameManager.Instance._playerStatusHandler.currentStatus.maxExp.ToString();
        playerGold.text = GameManager.Instance._playerStatusHandler.currentStatus.statusSO.gold.ToString();
        atk.text = "공격력\n" + GameManager.Instance._playerStatusHandler.currentStatus.statusSO.atk.ToString();
        def.text = "방어력\n" + GameManager.Instance._playerStatusHandler.currentStatus.statusSO.def.ToString();
        hp.text = "체력\n" + GameManager.Instance._playerStatusHandler.currentStatus.statusSO.maxHealth.ToString();
        speed.text = "이동속도\n" + GameManager.Instance._playerStatusHandler.currentStatus.statusSO.speed.ToString();
        currentExpBar.localScale = new Vector3(GameManager.Instance._playerStatusHandler.currentStatus.statusSO.exp / GameManager.Instance._playerStatusHandler.currentStatus.maxExp, 1, 1);
        inventoryText.text = $"Inventory  <color=#FF7500>{GameManager.Instance.Inventory.Count}<color=#767676> / {GameManager.Instance.InventoryMaxSpace}";
    }
    // 인벤토리 UI 초기화
    public void SetInventory()
    {
        for(int i = 0; i < GameManager.Instance.Inventory.Count; i++)
        {
            inventory.transform.GetChild(i).GetChild(0).gameObject.SetActive(true);
            inventory.transform.GetChild(i).GetChild(0).GetComponent<Image>().sprite = GameManager.Instance.Inventory[i].itemSO.itemSprite;
            if (GameManager.Instance.Inventory[i].itemSO.equip)
                inventory.transform.GetChild(i).GetChild(1).gameObject.SetActive(true);
            else
                inventory.transform.GetChild(i).GetChild(1).gameObject.SetActive(false);
        }
    }
    // 상점 UI 초기화
    public void SetShop()
    {
        for(int i = 0; i < GameManager.Instance.ShopItemList.Count; i++)
        {
            shopItemList.transform.GetChild(i).GetChild(0).GetComponent<Image>().sprite = GameManager.Instance.ShopItemList[i].itemSO.itemSprite;
            shopItemList.transform.GetChild(i).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = 
                $"<color=#003582> {GameManager.Instance.ShopItemList[i].itemSO.itemName}\n<color=#823A00><size=36>{GameManager.Instance.ShopItemList[i].itemSO.itemDescription}";
            shopItemList.transform.GetChild(i).GetChild(2).GetComponent<Image>().sprite = GameManager.Instance.ShopItemList[i].itemSO.addStatSprite;
            shopItemList.transform.GetChild(i).GetChild(2).GetChild(0).GetComponent<TMP_Text>().text = $"+{GameManager.Instance.ShopItemList[i].itemSO.addSize}";
            shopItemList.transform.GetChild(i).GetChild(3).GetChild(0).GetComponent<TMP_Text>().text = $"{GameManager.Instance.ShopItemList[i].itemSO.price}";
        }
    }
}
