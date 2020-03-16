using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    [SerializeField] private Transform target;
    [SerializeField] private Vector3 offsetPos = new Vector3(0,10,-10);
    [SerializeField] float moveSpeed = 5;
    [SerializeField] float turnSpeed = 10;
    [SerializeField] float smoothSpeed = 0.5f;

    Quaternion targetRotation;
    Vector3 targetPos;
    bool smoothRotating = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveWithTarget();
        LookAtTarget();
    }

    private void MoveWithTarget()
    {
        targetPos = target.position + offsetPos;
        transform.position = Vector3.Lerp(transform.position, targetPos, moveSpeed * Time.deltaTime);
    }

    void LookAtTarget()
    {
        targetRotation = Quaternion.LookRotation(target.position - transform.position);
    }
}
