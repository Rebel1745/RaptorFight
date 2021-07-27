using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputSprint : MonoBehaviour
{
    [SerializeField] RaptorController raptorController;

    public float SprintSpeed = 10f;

    public void Sprint(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            if (raptorController.CanSprint)
                raptorController.playerInputMove.currentSpeed = SprintSpeed;
        }

        if (context.canceled)
        {
            raptorController.playerInputMove.currentSpeed = raptorController.playerInputMove.WalkSpeed;
        }
    }
}
