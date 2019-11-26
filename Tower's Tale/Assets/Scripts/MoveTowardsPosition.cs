using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class MoveTowardsPosition : MonoBehaviour
{
    public PositionData destinationPosition;
    public CharacterController characterController;
    public float speed = 1.0f;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        if (!(Vector3.Distance(characterController.transform.position, destinationPosition.positionVector) > 0.001f)) return;
        // Lerp movetowards
        //characterController.Move((destinationPosition.positionVector-characterController.transform.position)/40);

        // Non-interpolated movetowards
        var step = speed * Time.deltaTime;
        Transform transform1;
        (transform1 = characterController.transform).position = Vector3.MoveTowards(characterController.transform.position, destinationPosition.positionVector, step);
    }
}