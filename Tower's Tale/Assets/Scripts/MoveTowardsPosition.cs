using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class MoveTowardsPosition : MonoBehaviour
{
    public PositionData destinationPosition;
    public CharacterController characterController;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        if (characterController.transform.position != destinationPosition.positionVector)
        {
            characterController.Move(destinationPosition.positionVector);
        }
    }
}
