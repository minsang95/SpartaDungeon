using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ItemEquip : MonoBehaviour
{
    public void EquipPopup()
    {
        GameManager.Instance.equipIndex = transform.GetSiblingIndex();
        if (!GameManager.Instance._playerInventory.Inventory[GameManager.Instance.equipIndex].itemSO.equip)
        {
            UIManager.Instance.OnEquipPopup(GameManager.Instance.equipIndex);
        }
        else
        {
            GameManager.Instance._playerInventory.Inventory[GameManager.Instance.equipIndex].itemSO.equip = false;
            switch (GameManager.Instance._playerInventory.Inventory[GameManager.Instance.equipIndex].itemSO.equipmentType)
            {
                case EquipmentType.Helmet:
                    GameManager.Instance._playerStatusHandler.currentStatus.statusSO.equipHelmet = false;
                    GameManager.Instance._playerStatusHandler.currentStatus.statusSO.def -= GameManager.Instance._playerInventory.Inventory[GameManager.Instance.equipIndex].itemSO.addSize;
                    break;
                case EquipmentType.Armor:
                    GameManager.Instance._playerStatusHandler.currentStatus.statusSO.equipArmor = false;
                    GameManager.Instance._playerStatusHandler.currentStatus.statusSO.def -= GameManager.Instance._playerInventory.Inventory[GameManager.Instance.equipIndex].itemSO.addSize;
                    break;
                case EquipmentType.Boots:
                    GameManager.Instance._playerStatusHandler.currentStatus.statusSO.equipBoots = false;
                    GameManager.Instance._playerStatusHandler.currentStatus.statusSO.speed -= GameManager.Instance._playerInventory.Inventory[GameManager.Instance.equipIndex].itemSO.addSize;
                    break;
                case EquipmentType.Weapon:
                    GameManager.Instance._playerStatusHandler.currentStatus.statusSO.equipWeapon = false;
                    GameManager.Instance._playerStatusHandler.currentStatus.statusSO.atk -= GameManager.Instance._playerInventory.Inventory[GameManager.Instance.equipIndex].itemSO.addSize;
                    break;
                case EquipmentType.Ring:
                    GameManager.Instance._playerStatusHandler.currentStatus.statusSO.equipRing = false;
                    if (GameManager.Instance._playerInventory.Inventory[GameManager.Instance.equipIndex].itemSO.addStat == AddStat.Atk)
                        GameManager.Instance._playerStatusHandler.currentStatus.statusSO.atk -= GameManager.Instance._playerInventory.Inventory[GameManager.Instance.equipIndex].itemSO.addSize;
                    if (GameManager.Instance._playerInventory.Inventory[GameManager.Instance.equipIndex].itemSO.addStat == AddStat.Health)
                        GameManager.Instance._playerStatusHandler.currentStatus.statusSO.maxHealth -= GameManager.Instance._playerInventory.Inventory[GameManager.Instance.equipIndex].itemSO.addSize;
                    break;
            }
            UIManager.Instance.OnPopup("장비해제", "장비를 해제하였습니다.", true);
        }
        UIManager.Instance.SetStatusUI();
        UIManager.Instance.SetInventory();
    }
    public void Equipment()
    {
        switch (GameManager.Instance._playerInventory.Inventory[GameManager.Instance.equipIndex].itemSO.equipmentType)
        {
            case EquipmentType.Helmet:
                if (!GameManager.Instance._playerStatusHandler.currentStatus.statusSO.equipHelmet)
                {
                    GameManager.Instance._playerInventory.Inventory[GameManager.Instance.equipIndex].itemSO.equip = true;
                    GameManager.Instance._playerStatusHandler.currentStatus.statusSO.equipHelmet = true;
                    GameManager.Instance._playerStatusHandler.currentStatus.statusSO.def += GameManager.Instance._playerInventory.Inventory[GameManager.Instance.equipIndex].itemSO.addSize;
                    UIManager.Instance.OnPopup("장착", "장비를 착용하였습니다.", true);
                }
                else
                {
                    UIManager.Instance.OnPopup("장착실패", "이미 착용중인 부위입니다.", false);
                }
                break;
            case EquipmentType.Armor:
                if (!GameManager.Instance._playerStatusHandler.currentStatus.statusSO.equipArmor)
                {
                    GameManager.Instance._playerInventory.Inventory[GameManager.Instance.equipIndex].itemSO.equip = true;
                    GameManager.Instance._playerStatusHandler.currentStatus.statusSO.equipArmor = true;
                    GameManager.Instance._playerStatusHandler.currentStatus.statusSO.def += GameManager.Instance._playerInventory.Inventory[GameManager.Instance.equipIndex].itemSO.addSize;
                    UIManager.Instance.OnPopup("장착", "장비를 착용하였습니다.", true);
                }
                else
                {
                    UIManager.Instance.OnPopup("장착실패", "이미 착용중인 부위입니다.", false);
                }
                break;
            case EquipmentType.Boots:
                if (!GameManager.Instance._playerStatusHandler.currentStatus.statusSO.equipBoots)
                {
                    GameManager.Instance._playerInventory.Inventory[GameManager.Instance.equipIndex].itemSO.equip = true;
                    GameManager.Instance._playerStatusHandler.currentStatus.statusSO.equipBoots = true;
                    GameManager.Instance._playerStatusHandler.currentStatus.statusSO.speed += GameManager.Instance._playerInventory.Inventory[GameManager.Instance.equipIndex].itemSO.addSize;
                    UIManager.Instance.OnPopup("장착", "장비를 착용하였습니다.", true);
                }
                else
                {
                    UIManager.Instance.OnPopup("장착실패", "이미 착용중인 부위입니다.", false);
                }
                break;
            case EquipmentType.Weapon:
                if (!GameManager.Instance._playerStatusHandler.currentStatus.statusSO.equipWeapon)
                {
                    GameManager.Instance._playerInventory.Inventory[GameManager.Instance.equipIndex].itemSO.equip = true;
                    GameManager.Instance._playerStatusHandler.currentStatus.statusSO.equipWeapon = true;
                    GameManager.Instance._playerStatusHandler.currentStatus.statusSO.atk += GameManager.Instance._playerInventory.Inventory[GameManager.Instance.equipIndex].itemSO.addSize;
                    UIManager.Instance.OnPopup("장착", "장비를 착용하였습니다.", true);
                }
                else
                {
                    UIManager.Instance.OnPopup("장착실패", "이미 착용중인 부위입니다.", false);
                }
                break;
            case EquipmentType.Ring:
                if (!GameManager.Instance._playerStatusHandler.currentStatus.statusSO.equipRing)
                {
                    GameManager.Instance._playerInventory.Inventory[GameManager.Instance.equipIndex].itemSO.equip = true;
                    GameManager.Instance._playerStatusHandler.currentStatus.statusSO.equipRing = true;
                    if (GameManager.Instance._playerInventory.Inventory[GameManager.Instance.equipIndex].itemSO.addStat == AddStat.Atk)
                        GameManager.Instance._playerStatusHandler.currentStatus.statusSO.atk += GameManager.Instance._playerInventory.Inventory[GameManager.Instance.equipIndex].itemSO.addSize;
                    if (GameManager.Instance._playerInventory.Inventory[GameManager.Instance.equipIndex].itemSO.addStat == AddStat.Health)
                        GameManager.Instance._playerStatusHandler.currentStatus.statusSO.maxHealth += GameManager.Instance._playerInventory.Inventory[GameManager.Instance.equipIndex].itemSO.addSize;
                    UIManager.Instance.OnPopup("장착", "장비를 착용하였습니다.", true);
                }
                else
                {
                    UIManager.Instance.OnPopup("장착실패", "이미 착용중인 부위입니다.", false);
                }
                break;
        }
        UIManager.Instance.SetStatusUI();
        UIManager.Instance.SetInventory();
    }
}
