using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject _markerDefineStatus;
    [SerializeField] private GameObject _background;

    public void ShowBackground()
    {
        _background.SetActive(true);
        _markerDefineStatus.SetActive(false);
    }

    public void HideBackground()
    {
        _background.SetActive(false);
        _markerDefineStatus.SetActive(true);
    }
}
