using UnityEngine;

public class PlayerMovement : Transformable
{
    public PlayerMovement(Transform transform) : base(transform) {}

    public override void FixedUpdate(float fixedDeltaTime)
    {
        var horizontal = Input.GetAxis(AxesNames.Horizontal);
        var vertical = Input.GetAxis(AxesNames.Vertical);

        var direction = new Vector3(horizontal, 0f, vertical);
        
        Transform.Translate(direction * Config.PlayerSpeed * fixedDeltaTime);
    }
}
