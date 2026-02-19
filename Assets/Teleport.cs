using UnityEngine;
using UnityEngine.InputSystem;

public class Teleport : MonoBehaviour
{
    public InputActionReference action;
    public Vector3 teleportLocation = new Vector3(-12, 0, 5);
    public Vector3 teleportRotation = new Vector3(0, 270, 0);
    
    void Start()
    {
        action.action.Enable();
        action.action.performed += ctx =>
        {
            transform.position = teleportLocation;
            transform.rotation = Quaternion.Euler(teleportRotation);
            action.action.Disable();
        };
    }
}
