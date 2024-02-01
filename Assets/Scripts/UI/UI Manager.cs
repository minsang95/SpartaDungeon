using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Transform _UIManager;
    [SerializeField] private GameObject MainScreen;

    UIManager Instance;
    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        Instantiate(MainScreen, _UIManager);
    }

}
