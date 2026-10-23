using UnityEngine;
using UnityEngine.InputSystem;

public class Player : Entity
{
    [SerializeField] private InputActionReference moveAction;

    private Vector2 moveDirection = Vector2.zero;

    private void OnEnable()
    {
        moveAction.action.Enable();
    }

    private void OnDisable()
    {
        moveAction.action.Disable();
    }

    private void Update()
    {
        moveDirection = moveAction.action.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        Vector3 finalDir = (transform.forward * moveDirection.y) + (transform.right * moveDirection.x);

        characterController.Move(speed * Time.deltaTime * finalDir);
    }
}
