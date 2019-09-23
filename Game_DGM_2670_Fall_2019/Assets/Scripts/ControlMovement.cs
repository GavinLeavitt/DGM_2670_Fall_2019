using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(CharacterController))]
public class ControlMovement : MonoBehaviour
{
    public float moveSpeed = 8.0f, jumpSpeed = 30.0f, gravity = 3.0f;
    private CharacterController characterController;
    private Vector3 position;
    public IntData jumpData;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        position.x = moveSpeed * Input.GetAxis("Horizontal");
        position.z = moveSpeed * Input.GetAxis("Vertical");
        position.y -= gravity;

        if (Input.GetButtonDown("Jump") && jumpData.value < jumpData.maxValue)
        {
            position.y = jumpSpeed;
            jumpData.value++;
        } else if (characterController.isGrounded)
        {
            position.y = 0;
        }

        characterController.Move((position) * Time.deltaTime);
    }
}