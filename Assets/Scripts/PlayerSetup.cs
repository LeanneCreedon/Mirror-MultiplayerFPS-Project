using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class PlayerSetup : Mirror.NetworkBehaviour
{
    void Start()
    {
        if(isLocalPlayer)
        {
            Debug.Log("IN LOCAL PLAYER!!!");
        }
        else{
            Debug.Log("NOT LOCAL PLAYER!!!");
        }
    }

    public override void OnStartLocalPlayer()
    {
        Debug.Log("IN LOCAL PLAYER!!!");
    }

    void HandleMovement()
    {
        //Calculate movement velocity as a 3D vector
        // float _xMov = Input.GetAxisRaw("Horizontal");
        // float _zMov = Input.GetAxisRaw("Vertical");

        // Vector3 _moveHorizontal = transform.right * _xMov;
        // Vector3 _moveVertical = transform.forward * _zMov;

        // // Final movement vector
        // Vector3 _velocity = (_moveHorizontal + _moveVertical).normalized * speed;

        // // Apply movement
        // motor.Move(_velocity);

        // // Calculate rotation as a 3D vector (turning around)
        // float _yRot = Input.GetAxisRaw("Mouse X");

        // Vector3 _rotation = new Vector3(0f, _yRot, 0f) * lookSensitivity;

        // // Apply rotation
        // motor.Rotate(_rotation);

        // // Calculate camera rotation as a 3D vector (turning around)
        // float _xRot = Input.GetAxisRaw("Mouse Y");

        // Vector3 _cameraRotation = new Vector3(_xRot, 0f, 0f) * lookSensitivity;

        // // Apply rotation
        // motor.RotateCamera(_cameraRotation);

        // Other version

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal * 0.1f, moveVertical * 0.1f, 0);
        transform.position = transform.position + movement;
    }
            
    void Update()
    {
        HandleMovement();
    }
}
