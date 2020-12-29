using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter01 : MonoBehaviour
{
    [SerializeField] GameObject capsule;
    public  float targetAngle =  0f;

    private GameObject sphere;
    private float buttonDownTime;

    public float sphereMagnitudeX = 2.0f;
    public float sphereMagnitudeY = 3.0f;
    public float sphereFrequency = 1.0f;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log(string.Format("mousePosition ({0:f}, {1:f})", Input.mousePosition.x, Input.mousePosition.y));

            targetAngle = GetRotationAngleByTargetPosition(Input.mousePosition);

            capsule.transform.eulerAngles = new Vector3(0f,0f,targetAngle);
        }
    }

    private float GetRotationAngleByTargetPosition(Vector3 mousePosition)
    {
        Vector3 selfScreenPoint = Camera.main.WorldToScreenPoint(capsule.transform.position);
        Vector3 diff = mousePosition - selfScreenPoint;
        Debug.Log(string.Format("diff: ({0:f}, {1:f})", diff.x, diff.y));
        float angle = Mathf.Atan2(diff.x, diff.y) * Mathf.Rad2Deg;
        Debug.Log(string.Format("angle: {0:f}", (-1f)*angle));

        return (-1f)*angle;
    }
}
