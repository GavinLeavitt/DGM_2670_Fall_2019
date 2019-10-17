using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class ControlMovement : ScriptableObject
{
    public float moveSpeed = 8.0f, jumpSpeed = 30.0f, gravity = 3.0f;
    private Vector3 position;
    public IntData jumpData;

    public void MoveCharacter(CharacterController controller)
    {
        position.x = moveSpeed * Input.GetAxis("Horizontal");
        position.z = moveSpeed * Input.GetAxis("Vertical");
        position.y -= gravity;

        if (Input.GetButtonDown("Jump") && jumpData.value < jumpData.maxValue)
        {
            position.y = jumpSpeed;
            jumpData.value++;
        } else if (controller.isGrounded)
        {
            position.y = 0;
            jumpData.value = 0;
        }

        controller.Move((position) * Time.deltaTime);
    }
}