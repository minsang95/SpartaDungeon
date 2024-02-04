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

    private void Awake()
    {

    }
    private void Start()
    {
        SetStatusUI();
    }
    public void SetStatusUI()
    {
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
    }
    public void OnOffUI(GameObject ui)
    {
        ui.SetActive(!ui.activeSelf);
    }
}
