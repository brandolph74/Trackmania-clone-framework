using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof (CarController))]
    public class CarUserControl : MonoBehaviour
    {
        private CarController m_Car; // the car controller we want to use
        public float h, v, handbrake, r, reverse, airbrake, reset;
        public Rigidbody rb;
        bool sentinel = false;
        public WheelCollider fR, fL, rR, rL;
        
        public Vector3 spawnPoint;
        public Quaternion spawnRotation;
        
        public static PlayerControls controls;
        
        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
            controls = new PlayerControls();
            controls.Enable();
            rb = GetComponent<Rigidbody>();
            spawnPoint = this.transform.position;
            spawnRotation = this.transform.rotation;
        }

        private void Update()
        {
            h = controls.Driving.Steering.ReadValue<float>();
            v = controls.Driving.Acceleration.ReadValue<float>();
            r = controls.Driving.Brake.ReadValue<float>();
            
            reverse = controls.Driving.Reverse.ReadValue<float>() * -1;
            //airbrake = controls.Driving.Airbrake.ReadValue<float>();
            
            reset = controls.Driving.Reset.ReadValue<float>();



            float direction = 0f;
            direction += v;
            direction -= r;
            v = direction;

            if (reverse != 0)
            {
                v = -1;
            }
            
        }

        private void FixedUpdate()
        {

            // pass the input to the car!
            if (v < 0 && reverse != -1)
            {
                handbrake = 1;
                if (rb.velocity.magnitude <= 5f)
                {
                    rb.velocity = Vector3.zero;
                    v = -0.00000001f;
                }
                
                //airbrake functionality
                if (fR.isGrounded == false && fL.isGrounded == false && rR.isGrounded == false && rL.isGrounded == false)
                {
                    rb.angularVelocity = rb.angularVelocity * .75f;
                }

            }
            else
            {
                handbrake = 0;
            }
            
            if (reverse == -1)
            {
                v = -1;
                handbrake = 0;
            }

            if (reset == 1)
            {
                this.transform.position = spawnPoint;
                this.transform.rotation = spawnRotation;
                rb.velocity = Vector3.zero;
                handbrake = 1;
                
            }
            /*  airbrake functionality moved to normal brake
            if (airbrake != 0 && fR.isGrounded == false && fL.isGrounded == false && rR.isGrounded == false && rL.isGrounded == false)
            {
                rb.angularVelocity = rb.angularVelocity * .75f;
            }
            */
#if !MOBILE_INPUT


            m_Car.Move(h, v, v, handbrake);
#else
            m_Car.Move(h, v, v, 0f);
#endif
        }
    }
}
