using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed;

    private CharacterController _characterController;

    private void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        float xInput = Input.GetAxisRaw("Horizontal");
        float zInput = Input.GetAxisRaw("Vertical");
        Vector3 inputDirection = new Vector3(xInput, 0, zInput);
        inputDirection.Normalize();

        // transform.Translate(inputDirection * _speed * Time.deltaTime);
        _characterController.Move(inputDirection * _speed * Time.deltaTime);
    }
}
