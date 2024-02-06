using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemBuy : MonoBehaviour
{
    public void Buy()
    {
        if (GameManager.Instance._playerStatusHandler.currentStatus.statusSO.gold >= GameManager.Instance.ShopItemList[transform.GetSiblingIndex()].itemSO.price)
        {
            if (GameManager.Instance.Inventory.Count < GameManager.Instance.InventoryMaxSpace)
            {
                GameManager.Instance._playerStatusHandler.currentStatus.statusSO.gold -= GameManager.Instance.ShopItemList[transform.GetSiblingIndex()].itemSO.price;
                EquipmentItemSO cloneSO = Instantiate(GameManager.Instance.ShopItemList[transform.GetSiblingIndex()].itemSO);
                Item addItem = Instantiate(GameManager.Instance.ShopItemList[transform.GetSiblingIndex()]);
                addItem.itemSO = cloneSO;
                GameManager.Instance.Inventory.Add(addItem);
                GameManager.Instance.ItemSlotTransform.GetChild(GameManager.Instance.itemIndex).GetComponent<Button>().enabled = true;
                GameManager.Instance.ItemSlotTransform.GetChild(GameManager.Instance.itemIndex).GetChild(0).gameObject.SetActive(true);
                GameManager.Instance.itemIndex++;
                UIManager.Instance.OnPopup("����", "���Ÿ� �Ϸ��Ͽ����ϴ�.", true);
                UIManager.Instance.SetStatusUI();
                UIManager.Instance.SetInventory();
            }
            else
            {
                UIManager.Instance.OnPopup("���Ž���", "�κ��丮�� ��á���ϴ�.", false);
            }
        }
        else
        {
            UIManager.Instance.OnPopup("���Ž���", "���� ��尡 �����մϴ�.", false);
        }
    }
}
