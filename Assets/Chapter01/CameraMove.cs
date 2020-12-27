using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] KeyCode KeyForward;
    [SerializeField] KeyCode KeyBack;
    [SerializeField] KeyCode KeyLeft;
    [SerializeField] KeyCode KeyRight;
    [SerializeField] KeyCode KeyUp;
    [SerializeField] KeyCode KeyDown;
    [SerializeField] float moveSpeed;

    // Update is called once per frame
    void Update()
    {
        ProcessKeyInput();
        ProcessMouseInput();
    }

    private void ProcessKeyInput()
    {
        Vector3 direction = Vector3.zero;

        if(Input.GetKey(KeyForward))
            direction += Time.deltaTime * moveSpeed * Vector3.forward;
        if(Input.GetKey(KeyBack))
            direction += Time.deltaTime * moveSpeed * Vector3.back;
        if(Input.GetKey(KeyLeft))
            direction += Time.deltaTime * moveSpeed * Vector3.left;
        if(Input.GetKey(KeyRight))
            direction += Time.deltaTime * moveSpeed * Vector3.right;
        if(Input.GetKey(KeyUp))
            direction += Time.deltaTime * moveSpeed * Vector3.up;
        if(Input.GetKey(KeyDown))
            direction += Time.deltaTime * moveSpeed * Vector3.down;

        transform.Translate(direction, Space.Self);
    }

    private void ProcessMouseInput()
    {
        // mouse right click
        if(Input.GetMouseButton(1))
        {

        }   
    }
}
