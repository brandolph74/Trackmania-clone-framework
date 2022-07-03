using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelController : MonoBehaviour
{

    public WheelCollider frontRight;
    public WheelCollider frontLeft;
    public WheelCollider backRight;
    public WheelCollider backLeft;

    public Transform frontRightTransform;
    public Transform frontLeftTransform;
    public Transform backRightTransform;
    public Transform backLeftTransform;

    public float acceleration = 500f;
    public float breakingForce = 300f;
    public float maxTurnAngle = 15f;

    private float currentAcceleration = 0f;
    private float currentBreakForce = 0f;
    private float currentTurnAngle = 0f;

    private void FixedUpdate()
    {
        
        
        
        
        frontRight.motorTorque = currentAcceleration;
        frontLeft.motorTorque = currentAcceleration;
        backRight.motorTorque = currentAcceleration;
        backLeft.motorTorque = currentAcceleration;
        
        frontRight.brakeTorque = currentBreakForce;
        frontLeft.brakeTorque = currentBreakForce;
        backRight.brakeTorque = currentBreakForce;
        backLeft.brakeTorque = currentBreakForce;

        
        frontLeft.steerAngle = currentTurnAngle;
        frontRight.steerAngle = currentTurnAngle;
        //backRight.steerAngle = currentTurnAngle;
        //backLeft.steerAngle = currentTurnAngle;

        UpdateWheel(frontLeft, frontLeftTransform);
        UpdateWheel(frontRight, frontRightTransform);
        UpdateWheel(backLeft, backLeftTransform);
        UpdateWheel(backRight, backRightTransform);
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentAcceleration = Input.GetAxis("Vertical") * acceleration;
        

        currentTurnAngle = maxTurnAngle * Input.GetAxis("Horizontal");

        if (Input.GetKey(KeyCode.Space))
        {
            currentBreakForce = breakingForce;
        }
        else
        {
            currentBreakForce = 0f;
        }
    }

    void UpdateWheel(WheelCollider col, Transform trans)
    {
        //get wheel collider state
        Vector3 position;
        Quaternion rotation;
        col.GetWorldPose(out position, out rotation);

        //trans.position = position;
        trans.rotation = rotation;
    }
}
