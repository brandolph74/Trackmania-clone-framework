//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/PlayerControls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Driving"",
            ""id"": ""ad26ac9f-3694-4f23-8f6c-c00a94582b68"",
            ""actions"": [
                {
                    ""name"": ""Acceleration"",
                    ""type"": ""Value"",
                    ""id"": ""ee7ff0ce-f543-429f-af3b-67ee5d96ff56"",
                    ""expectedControlType"": ""Analog"",
                    ""processors"": ""AxisDeadzone(min=0.05,max=0.925)"",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Steering"",
                    ""type"": ""PassThrough"",
                    ""id"": ""2403d523-48f3-4d44-995c-c83eca79258b"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Brake"",
                    ""type"": ""Value"",
                    ""id"": ""771f5c54-3dda-4d89-99e9-9059477a5eb1"",
                    ""expectedControlType"": ""Analog"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Reverse"",
                    ""type"": ""Value"",
                    ""id"": ""25119a01-1327-442c-a1c1-5fe843909482"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Airbrake"",
                    ""type"": ""Button"",
                    ""id"": ""cb9ba03d-df05-4c4f-b362-21b82259c3cc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Reset"",
                    ""type"": ""Button"",
                    ""id"": ""8e9515a2-263d-4fba-8050-7c3b734b4bf3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""84c8b5b0-5918-4b09-b06c-64078a8dc7bf"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Acceleration"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""45db9d8e-e23f-4971-988a-ab61f6b40bdd"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Acceleration"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8bd03790-2ece-4f48-8b44-10591003f337"",
                    ""path"": ""<Gamepad>/leftStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""04216aa1-dac7-4d89-a684-69800551ed19"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steering"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""7ee20646-ffed-406d-9366-d8d0785d7e6b"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""dd6948cb-bc90-4aca-9358-f9a3cdd0263b"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""68052163-3ddc-4b91-9265-e859fb991fb2"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""397d88d3-8f57-42a6-a0e6-7f3ac1f805e5"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f748dbb0-c017-47c9-b48c-f8a002b29bbc"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reverse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cf4e16b0-7418-4ed7-86aa-f405a50bfc01"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reverse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2bdbd79a-f2a3-4147-b889-a6513a813833"",
                    ""path"": ""<Gamepad>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Airbrake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bd644574-79eb-4432-bfd8-ce7627a8986c"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Airbrake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a42b0c92-26fa-4307-8775-16e2d9f6bdf9"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reset"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7e4e489b-b97d-4104-bec1-fa5478d1766a"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reset"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Driving
        m_Driving = asset.FindActionMap("Driving", throwIfNotFound: true);
        m_Driving_Acceleration = m_Driving.FindAction("Acceleration", throwIfNotFound: true);
        m_Driving_Steering = m_Driving.FindAction("Steering", throwIfNotFound: true);
        m_Driving_Brake = m_Driving.FindAction("Brake", throwIfNotFound: true);
        m_Driving_Reverse = m_Driving.FindAction("Reverse", throwIfNotFound: true);
        m_Driving_Airbrake = m_Driving.FindAction("Airbrake", throwIfNotFound: true);
        m_Driving_Reset = m_Driving.FindAction("Reset", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Driving
    private readonly InputActionMap m_Driving;
    private IDrivingActions m_DrivingActionsCallbackInterface;
    private readonly InputAction m_Driving_Acceleration;
    private readonly InputAction m_Driving_Steering;
    private readonly InputAction m_Driving_Brake;
    private readonly InputAction m_Driving_Reverse;
    private readonly InputAction m_Driving_Airbrake;
    private readonly InputAction m_Driving_Reset;
    public struct DrivingActions
    {
        private @PlayerControls m_Wrapper;
        public DrivingActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Acceleration => m_Wrapper.m_Driving_Acceleration;
        public InputAction @Steering => m_Wrapper.m_Driving_Steering;
        public InputAction @Brake => m_Wrapper.m_Driving_Brake;
        public InputAction @Reverse => m_Wrapper.m_Driving_Reverse;
        public InputAction @Airbrake => m_Wrapper.m_Driving_Airbrake;
        public InputAction @Reset => m_Wrapper.m_Driving_Reset;
        public InputActionMap Get() { return m_Wrapper.m_Driving; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DrivingActions set) { return set.Get(); }
        public void SetCallbacks(IDrivingActions instance)
        {
            if (m_Wrapper.m_DrivingActionsCallbackInterface != null)
            {
                @Acceleration.started -= m_Wrapper.m_DrivingActionsCallbackInterface.OnAcceleration;
                @Acceleration.performed -= m_Wrapper.m_DrivingActionsCallbackInterface.OnAcceleration;
                @Acceleration.canceled -= m_Wrapper.m_DrivingActionsCallbackInterface.OnAcceleration;
                @Steering.started -= m_Wrapper.m_DrivingActionsCallbackInterface.OnSteering;
                @Steering.performed -= m_Wrapper.m_DrivingActionsCallbackInterface.OnSteering;
                @Steering.canceled -= m_Wrapper.m_DrivingActionsCallbackInterface.OnSteering;
                @Brake.started -= m_Wrapper.m_DrivingActionsCallbackInterface.OnBrake;
                @Brake.performed -= m_Wrapper.m_DrivingActionsCallbackInterface.OnBrake;
                @Brake.canceled -= m_Wrapper.m_DrivingActionsCallbackInterface.OnBrake;
                @Reverse.started -= m_Wrapper.m_DrivingActionsCallbackInterface.OnReverse;
                @Reverse.performed -= m_Wrapper.m_DrivingActionsCallbackInterface.OnReverse;
                @Reverse.canceled -= m_Wrapper.m_DrivingActionsCallbackInterface.OnReverse;
                @Airbrake.started -= m_Wrapper.m_DrivingActionsCallbackInterface.OnAirbrake;
                @Airbrake.performed -= m_Wrapper.m_DrivingActionsCallbackInterface.OnAirbrake;
                @Airbrake.canceled -= m_Wrapper.m_DrivingActionsCallbackInterface.OnAirbrake;
                @Reset.started -= m_Wrapper.m_DrivingActionsCallbackInterface.OnReset;
                @Reset.performed -= m_Wrapper.m_DrivingActionsCallbackInterface.OnReset;
                @Reset.canceled -= m_Wrapper.m_DrivingActionsCallbackInterface.OnReset;
            }
            m_Wrapper.m_DrivingActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Acceleration.started += instance.OnAcceleration;
                @Acceleration.performed += instance.OnAcceleration;
                @Acceleration.canceled += instance.OnAcceleration;
                @Steering.started += instance.OnSteering;
                @Steering.performed += instance.OnSteering;
                @Steering.canceled += instance.OnSteering;
                @Brake.started += instance.OnBrake;
                @Brake.performed += instance.OnBrake;
                @Brake.canceled += instance.OnBrake;
                @Reverse.started += instance.OnReverse;
                @Reverse.performed += instance.OnReverse;
                @Reverse.canceled += instance.OnReverse;
                @Airbrake.started += instance.OnAirbrake;
                @Airbrake.performed += instance.OnAirbrake;
                @Airbrake.canceled += instance.OnAirbrake;
                @Reset.started += instance.OnReset;
                @Reset.performed += instance.OnReset;
                @Reset.canceled += instance.OnReset;
            }
        }
    }
    public DrivingActions @Driving => new DrivingActions(this);
    public interface IDrivingActions
    {
        void OnAcceleration(InputAction.CallbackContext context);
        void OnSteering(InputAction.CallbackContext context);
        void OnBrake(InputAction.CallbackContext context);
        void OnReverse(InputAction.CallbackContext context);
        void OnAirbrake(InputAction.CallbackContext context);
        void OnReset(InputAction.CallbackContext context);
    }
}
