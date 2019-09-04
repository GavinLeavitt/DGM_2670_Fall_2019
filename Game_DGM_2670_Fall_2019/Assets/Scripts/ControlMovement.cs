using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.UIElements;

public class ControlMovement : MonoBehaviour
{
    public float speed = 1.0f;
    private CharacterController characterController;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
    }
    
    // Update is called once per frame
    private void Update()
    {
        var moveDirection = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);
        moveDirection *= speed;
        characterController.Move(moveDirection * Time.deltaTime);
    }
}