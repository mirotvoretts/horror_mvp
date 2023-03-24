using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace CompositeRoot
{
    public class CollisionsRecordsCompositeRoot : CompositeRoot
    {
        [SerializeField] private GameEndWindowView _gameEndWindow;

        [SerializeField] private Transform _enemy;
        [SerializeField] private Transform _player;

        public event Action GameEnd;

        private const int MainMenuSceneIndex = 0;

        public override void Compose() { }

        private void OnEnable()
        {
            GameEnd += OnGameEnd;
        }

        private void OnDisable()
        {
            GameEnd -= OnGameEnd;
        }

        private void Update()
        {
            if (EnemyCanAttackPlayer() || PlayerCollectedEnoughKeys())
            {
                GameEnd?.Invoke();
            }
        }

        public void OnGameEnd()
        {
            Time.timeScale = 0f;
            
            _gameEndWindow.Show(RestartGame, BackToMainMenu);

            Cursor.lockState = CursorLockMode.None;
        }
        
        private void RestartGame()
        {
            Cursor.lockState = CursorLockMode.Locked;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        private void BackToMainMenu()
        {
            SceneManager.LoadScene(MainMenuSceneIndex);
        }
        
        private bool EnemyCanAttackPlayer()
        {
            return Vector3.Distance(_enemy.position, _player.position) <= Config.EnemyAttackRange;
        }

        private bool PlayerCollectedEnoughKeys()
        {
            return KeysCollector.Balance >= Config.KeysToCollect;
        }
    }
}