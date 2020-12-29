using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] KeyCode KeyForward = KeyCode.W;
    [SerializeField] KeyCode KeyBack = KeyCode.S;
    [SerializeField] KeyCode KeyLeft = KeyCode.A;
    [SerializeField] KeyCode KeyRight = KeyCode.D;
    [SerializeField] KeyCode KeyUp = KeyCode.Q;
    [SerializeField] KeyCode KeyDown = KeyCode.E;
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float rotSpeed = 10f;

    [SerializeField] bool xMoveLock;
    [SerializeField] bool yMoveLock;
    [SerializeField] bool zMoveLock;
    [SerializeField] bool rotLock;

    // Update is called once per frame
    void Update()
    {
        ProcessKeyInput();
        ProcessMouseInput();
    }

    private void ProcessKeyInput()
    {
        
        Vector3 direction = Vector3.zero;

        if(Input.GetKey(KeyForward) && !zMoveLock)
            direction += Time.deltaTime * moveSpeed * Vector3.forward;
        if(Input.GetKey(KeyBack) && !zMoveLock)
            direction += Time.deltaTime * moveSpeed * Vector3.back;
        if(Input.GetKey(KeyLeft) && !xMoveLock)
            direction += Time.deltaTime * moveSpeed * Vector3.left;
        if(Input.GetKey(KeyRight) && !xMoveLock)
            direction += Time.deltaTime * moveSpeed * Vector3.right;
        if(Input.GetKey(KeyUp) && !yMoveLock)
            direction += Time.deltaTime * moveSpeed * Vector3.up;
        if(Input.GetKey(KeyDown) && !yMoveLock)
            direction += Time.deltaTime * moveSpeed * Vector3.down;

        transform.Translate(direction, Space.Self);
    }

    private void ProcessMouseInput()
    {
        // mouse right click
        if(Input.GetMouseButton(1) && !rotLock)
        {
            float kh = Input.GetAxis("Horizontal");
            float kv = Input.GetAxis("Vertical");

            transform.Rotate(kv * Time.deltaTime * -rotSpeed, kh * Time.deltaTime * rotSpeed, 0f);
            transform.rotation = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y, 0f);
        }
    }
}
