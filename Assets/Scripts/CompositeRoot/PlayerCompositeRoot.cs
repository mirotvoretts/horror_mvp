using UnityEngine;

namespace CompositeRoot
{
    public class PlayerCompositeRoot : CompositeRoot
    {
        [SerializeField] private Transform _camera;

        private PlayerCamera _playerCamera;
        private PlayerMovement _playerMovement;
        private KeysCollector _keysCollector;

        public override void Compose()
        {
            _playerCamera = new PlayerCamera(transform, _camera);
            _playerMovement = new PlayerMovement(transform);
            _keysCollector = new KeysCollector();
        }

        private void Update()
        {
            _playerCamera.Update(Time.deltaTime);
        }

        private void FixedUpdate()
        {
            _playerMovement.FixedUpdate(Time.fixedDeltaTime);
        }

        private void OnCollisionEnter(Collision collision)
        {
            _keysCollector.OnCollisionEnter(collision);
        }
    }
}