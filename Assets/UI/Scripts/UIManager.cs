using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public void OnOffUI(GameObject ui)
    {
        ui.SetActive(!ui.activeSelf);
    }
}
