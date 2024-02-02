using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

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
    private void Start()
    {
        SetStatusUI();
    }
    public void OnOffUI(GameObject ui)
    {
        ui.SetActive(!ui.activeSelf);
    }
    public void SetStatusUI()
    {
        characterType.text = PlayerStatusHandler.Instance.currentStatus.characterType.ToString();
        playerName.text = PlayerStatusHandler.Instance.currentStatus.name;
        characterLevel.text = "Lv " + PlayerStatusHandler.Instance.currentStatus.statusSO.level.ToString();
        characterExp.text = PlayerStatusHandler.Instance.currentStatus.statusSO.exp.ToString() + " / " + PlayerStatusHandler.Instance.currentStatus.maxExp.ToString();
        playerGold.text = PlayerStatusHandler.Instance.currentStatus.statusSO.gold.ToString();
        atk.text = "공격력\n" + PlayerStatusHandler.Instance.currentStatus.statusSO.atk.ToString();
        def.text = "방어력\n" + PlayerStatusHandler.Instance.currentStatus.statusSO.def.ToString();
        hp.text = "체력\n" + PlayerStatusHandler.Instance.currentStatus.statusSO.maxHealth.ToString();
        speed.text = "이동속도\n" + PlayerStatusHandler.Instance.currentStatus.statusSO.speed.ToString();

        currentExpBar.localScale = new Vector3((PlayerStatusHandler.Instance.currentStatus.statusSO.exp / PlayerStatusHandler.Instance.currentStatus.maxExp), 1, 1);
    }
}
