using TMPro;
using UnityEngine;

public class PlayerUIView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _balanceLabel;

    private void Update()
    {
        _balanceLabel.text = $"{KeysCollector.Balance} / {Config.KeysToCollect}";
    }
}
