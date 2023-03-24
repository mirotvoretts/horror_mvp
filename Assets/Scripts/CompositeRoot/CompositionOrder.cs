using System.Collections.Generic;
using UnityEngine;

namespace CompositeRoot
{
    internal class CompositionOrder : MonoBehaviour
    {
        [SerializeField] private List<CompositeRoot> _order;

        private void Awake()
        {
            KeysCollector.ResetBalance();
            Time.timeScale = 1f;
            
            foreach (var compositionRoot in _order)
            {
                compositionRoot.Compose();
                compositionRoot.gameObject.SetActive(true);
            }
        }
    }
}