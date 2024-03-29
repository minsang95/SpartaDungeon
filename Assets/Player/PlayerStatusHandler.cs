using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatusHandler : MonoBehaviour
{
    [SerializeField] private PlayerStatus baseStatus;

    public PlayerStatus currentStatus { get; private set; }
    public List<PlayerStatus> statusModifiers = new List<PlayerStatus>();

    private void Awake()
    {
        UpdateCharacterStatus();
    }

    private void UpdateCharacterStatus()
    {
        CharacterStatusSO statusSO = null;
        if(baseStatus.statusSO != null)
        {
            statusSO = Instantiate(baseStatus.statusSO);
        }
        currentStatus = new PlayerStatus { statusSO = statusSO };
        currentStatus.changeType = baseStatus.changeType;
        currentStatus.characterType = baseStatus.characterType;
        currentStatus.name = baseStatus.name;
        currentStatus.maxExp = baseStatus.maxExp;
    }
}
