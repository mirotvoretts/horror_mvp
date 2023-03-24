using UnityEngine;

public abstract class Transformable
{
    protected Transform Transform { get; }

    protected Transformable(Transform transform)
    {
        Transform = transform;
    }

    public virtual void Update(float deltaTime) { }
    public virtual void FixedUpdate(float fixedDeltaTime) { }
}
