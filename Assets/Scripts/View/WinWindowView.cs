using System;
using UnityEngine;
using UnityEngine.UI;

public class WinWindowView : MonoBehaviour
{
    [SerializeField] private Button _restartButton;
    [SerializeField] private Button _backToMainMenuButton;
    
    public void Show(Action onReloadClick, Action onBackToMenuClick)
    {
        _restartButton.onClick.RemoveAllListeners();
        _restartButton.onClick.AddListener(() => onReloadClick());
        
        _backToMainMenuButton.onClick.RemoveAllListeners();
        _backToMainMenuButton.onClick.AddListener(() => onBackToMenuClick());
        
        gameObject.SetActive(true);
    }
}
