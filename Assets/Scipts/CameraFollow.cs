using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform target;
    public float smoothSpeed = 10f;
    public Vector3 offset;
    private Vector3 velocity = Vector3.zero;
    float lockPos = 0f;
    private Vector3 newPos;

    /*
    private void LateUpdate()
    {
        transform.rotation = Quaternion.Euler(lockPos, lockPos, lockPos);
    }
    */

    private void Start()
    {

        transform.rotation = Quaternion.Euler(lockPos, lockPos, lockPos);
        newPos.y = offset.y;
        newPos.z = offset.z;
    }

    private void LateUpdate()
    {
        
        newPos.x = target.position.x + offset.x;
        

        //transform.rotation = Quaternion.Euler(lockPos, lockPos, lockPos);
        Vector3 smoothPosition = Vector3.SmoothDamp(transform.position, newPos, ref velocity, smoothSpeed * Time.deltaTime);

        //Vector3 smoothPosition = Vector3.Lerp(transform.position, newPos, smoothSpeed);

        transform.position = smoothPosition;
        

    }
}
