using UnityEngine;
using UnityEngine.Events;

public class ControlMovement : MonoBehaviour
{
    public float speed = 1.0f;
    private CharacterController characterController;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        var moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        moveDirection *= speed;
        characterController.Move(moveDirection * Time.deltaTime);
    }
}