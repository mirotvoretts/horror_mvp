using UnityEngine;

public class PlayerCamera : Transformable
{
    private readonly Transform _camera; 
    private float _xRotation;

    public PlayerCamera(Transform transform, Transform camera) : base(transform)
    {
        _camera = camera;
        
        Cursor.lockState = CursorLockMode.Locked;
    }

    public override void Update(float deltaTime)
    {
        var mouseX = Input.GetAxis(AxesNames.MouseX) * Config.MouseSensitivity;
        var mouseY = Input.GetAxis(AxesNames.MouseY) * Config.MouseSensitivity;
        
        _xRotation -= mouseY;
        _xRotation = Mathf.Clamp(_xRotation, Config.MinCameraRotationAngle, Config.MaxCameraRotationAngle);
        
        _camera.localRotation = Quaternion.Euler(_xRotation, 0f, 0f);

        _camera.Rotate(mouseY * Vector3.left * deltaTime);
        Transform.Rotate(mouseX * Vector3.up);
    }
}
