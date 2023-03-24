using UnityEngine;

public class EnemyMovement : Transformable
{
    private readonly Transform _target;

    public EnemyMovement(Transform transform, Transform target) : base(transform)
    {
        _target = target;
    }

    public override void Update(float deltaTime)
    {
        var movementDirection = new Vector3(0f, 0f, Config.EnemySpeed * deltaTime);
        
        Transform.LookAt(_target.transform);
        Transform.Translate(movementDirection);
    }
}
