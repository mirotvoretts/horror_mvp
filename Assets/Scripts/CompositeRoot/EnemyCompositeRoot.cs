using UnityEngine;

namespace CompositeRoot
{
    public class EnemyCompositeRoot : CompositeRoot
    {
        [SerializeField] private Transform _target;

        private EnemyMovement _enemyMovement;

        public override void Compose()
        {
            _enemyMovement = new EnemyMovement(transform, _target);
        }

        private void Update()
        {
            _enemyMovement.Update(Time.deltaTime);
        }
    }
}
