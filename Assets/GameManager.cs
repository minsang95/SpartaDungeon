using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    public PlayerStatusHandler _playerStatusHandler;
    [SerializeField] private GameObject UIManager;

    public static GameManager Instance;
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);

        _playerStatusHandler = Player.GetComponent<PlayerStatusHandler>();
    }
    private void Start()
    {
        UIManager.SetActive(true);
        Player.SetActive(true);



    }
}
