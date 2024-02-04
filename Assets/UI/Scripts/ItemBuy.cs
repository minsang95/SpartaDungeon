using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBuy : MonoBehaviour
{
    public void Buy()
    {
        if (GameManager.Instance._playerStatusHandler.currentStatus.statusSO.gold >= GameManager.Instance._shop.ShopItemList[transform.GetSiblingIndex()].itemSO.price)
        {
            if (GameManager.Instance._playerInventory.Inventory.Count < GameManager.Instance._playerInventory.maxSpace)
            {
                GameManager.Instance._playerStatusHandler.currentStatus.statusSO.gold -= GameManager.Instance._shop.ShopItemList[transform.GetSiblingIndex()].itemSO.price;
                GameManager.Instance._playerInventory.Inventory.Add(GameManager.Instance._shop.ShopItemList[transform.GetSiblingIndex()]);
                UIManager.Instance.OnPopup("����", "���Ÿ� �Ϸ��Ͽ����ϴ�.", true);
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

    public void SetStatusUI()
    {
        UIManager.Instance.SetStatusUI();
    }
    public void SetInventory()
    {
        UIManager.Instance.SetInventory();
    }
}
