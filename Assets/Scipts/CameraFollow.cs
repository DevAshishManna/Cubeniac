﻿using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform target;
    public float smoothSpeed = 10f;
    public Vector3 offset;
    private Vector3 velocity = Vector3.zero;

    private void FixedUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothPosition = Vector3.SmoothDamp(transform.position,desiredPosition,ref velocity,smoothSpeed * Time.deltaTime);
        transform.position = smoothPosition;

        transform.LookAt(target);
    }
}
