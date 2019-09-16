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
        var mouseAxis = System.Convert.ToSingle(Input.GetMouseButton(0)) - System.Convert.ToSingle(Input.GetMouseButton(1));
        var moveDirection = new Vector3(Input.GetAxis("Horizontal"), mouseAxis, Input.GetAxis("Vertical"));
        moveDirection *= speed;
        characterController.Move(moveDirection * Time.deltaTime);
    }
}