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
                UIManager.Instance.OnPopup("구매", "구매를 완료하였습니다.", true);
            }
            else
            {
                UIManager.Instance.OnPopup("구매실패", "인벤토리가 꽉찼습니다.", false);
            }
        }
        else
        {
            UIManager.Instance.OnPopup("구매실패", "소지 골드가 부족합니다.", false);
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
