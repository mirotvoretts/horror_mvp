using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneMenuView : MonoBehaviour
{
    [SerializeField] private Button _startButton;
    [SerializeField] private Button _quitButton;

    private const int MainSceneIndex = 1;

    private void Start()
    {
        _startButton.onClick.RemoveAllListeners();
        _startButton.onClick.AddListener(OnStartClick);
        
        _quitButton.onClick.RemoveAllListeners();
        _quitButton.onClick.AddListener(OnQuitClick);
    }

    private void OnStartClick()
    {
        SceneManager.LoadScene(MainSceneIndex);
    }
    
    private void OnQuitClick()
    {
        Application.Quit();
    }
}
