//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Input/PlayerControls.inputactions
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

namespace Player
{
    public partial class @PlayerController : IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @PlayerController()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""PlayerControls"",
            ""id"": ""13d3ac5c-0408-423c-a7cb-3117c4f88f2b"",
            ""actions"": [
                {
                    ""name"": ""ActionSouth"",
                    ""type"": ""Button"",
                    ""id"": ""c9d3f877-8184-490b-8e84-9bf3252cb066"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""DpadLeft"",
                    ""type"": ""Button"",
                    ""id"": ""57861869-a483-412c-8631-a92a40f05135"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""DpadRight"",
                    ""type"": ""Button"",
                    ""id"": ""519f9571-139e-41cc-8798-285418337e6f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""L1"",
                    ""type"": ""Button"",
                    ""id"": ""b54355c8-5d9e-42bd-82a5-c166950160bd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""R1"",
                    ""type"": ""Button"",
                    ""id"": ""66b52a62-1ff3-4e00-ac4e-e9254dc2a867"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f298a716-9262-473c-aa08-8ecdc96ad310"",
                    ""path"": ""<HID::Sony Interactive Entertainment Controller>/button3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ActionSouth"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7aa10f99-5f3f-40d8-821a-82d44707792c"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ActionSouth"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a3135f54-1011-4047-b342-7b2d58b74e43"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": ""Hold"",
                    ""processors"": ""Invert"",
                    ""groups"": """",
                    ""action"": ""ActionSouth"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2cbe8fe8-2d3b-4f02-8f54-c0d42d6beb52"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ActionSouth"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b6f1bbed-50ec-4198-bf8a-6b97247860df"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ActionSouth"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""769c4522-04b5-44ff-837d-84e5aa415ff0"",
                    ""path"": ""<HID::Sony Interactive Entertainment Controller>/stick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DpadLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a516e285-b512-4f6f-a713-9b07fceca94b"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DpadLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""40158f21-c684-4bf2-9c92-65ca5eb7e056"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DpadLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b293cb12-b57b-4279-b25e-b7fd73808fe1"",
                    ""path"": ""<DualShockGamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DpadLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e387a9ed-03b9-48a9-afc2-61a07315a2d6"",
                    ""path"": ""<SwitchProControllerHID>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DpadLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""03c9c4b3-8500-4566-bf08-99928683fa8c"",
                    ""path"": ""<XInputController>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DpadLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b8b4305d-d7d4-4487-9439-69b258381231"",
                    ""path"": ""<XInputController>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DpadLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2cdacd4d-3ba8-4715-a7d2-d0d9861c7ea1"",
                    ""path"": ""<HID::Sony Interactive Entertainment Controller>/stick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DpadRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2a0e3956-b32d-47ef-9136-0f7ae1be7e65"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DpadRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bfe699bf-765d-4cc2-891d-34c0946c0a12"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DpadRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""85e86889-c059-40ae-a340-60bac203246d"",
                    ""path"": ""<DualShockGamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DpadRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9d7f27e2-f6fc-4604-b987-7fb676a4af4f"",
                    ""path"": ""<SwitchProControllerHID>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DpadRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fb3a564f-a88c-4056-99e1-54c831a70dcb"",
                    ""path"": ""<XInputController>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DpadRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0b403baa-7c07-4106-9c93-fd305ba9d3ec"",
                    ""path"": ""<XInputController>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DpadRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""71e95148-6aa9-4f39-9837-ceb2590784ff"",
                    ""path"": ""<HID::Sony Interactive Entertainment Controller>/button7"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""L1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""341fb5e7-4ced-4e98-9425-752625e18f2b"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""L1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""348c262e-2fea-4555-b5cc-9473e9310ae9"",
                    ""path"": ""<XInputController>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""L1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b2323eab-a776-40ba-b596-abd1e905c0cc"",
                    ""path"": ""<HID::Sony Interactive Entertainment Controller>/button8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""R1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b902a7d6-1bde-4c66-8b5e-c973139c607f"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""R1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9369e137-9b09-456a-9897-9f19ff938fd8"",
                    ""path"": ""<XInputController>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""R1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // PlayerControls
            m_PlayerControls = asset.FindActionMap("PlayerControls", throwIfNotFound: true);
            m_PlayerControls_ActionSouth = m_PlayerControls.FindAction("ActionSouth", throwIfNotFound: true);
            m_PlayerControls_DpadLeft = m_PlayerControls.FindAction("DpadLeft", throwIfNotFound: true);
            m_PlayerControls_DpadRight = m_PlayerControls.FindAction("DpadRight", throwIfNotFound: true);
            m_PlayerControls_L1 = m_PlayerControls.FindAction("L1", throwIfNotFound: true);
            m_PlayerControls_R1 = m_PlayerControls.FindAction("R1", throwIfNotFound: true);
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

        // PlayerControls
        private readonly InputActionMap m_PlayerControls;
        private IPlayerControlsActions m_PlayerControlsActionsCallbackInterface;
        private readonly InputAction m_PlayerControls_ActionSouth;
        private readonly InputAction m_PlayerControls_DpadLeft;
        private readonly InputAction m_PlayerControls_DpadRight;
        private readonly InputAction m_PlayerControls_L1;
        private readonly InputAction m_PlayerControls_R1;
        public struct PlayerControlsActions
        {
            private @PlayerController m_Wrapper;
            public PlayerControlsActions(@PlayerController wrapper) { m_Wrapper = wrapper; }
            public InputAction @ActionSouth => m_Wrapper.m_PlayerControls_ActionSouth;
            public InputAction @DpadLeft => m_Wrapper.m_PlayerControls_DpadLeft;
            public InputAction @DpadRight => m_Wrapper.m_PlayerControls_DpadRight;
            public InputAction @L1 => m_Wrapper.m_PlayerControls_L1;
            public InputAction @R1 => m_Wrapper.m_PlayerControls_R1;
            public InputActionMap Get() { return m_Wrapper.m_PlayerControls; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(PlayerControlsActions set) { return set.Get(); }
            public void SetCallbacks(IPlayerControlsActions instance)
            {
                if (m_Wrapper.m_PlayerControlsActionsCallbackInterface != null)
                {
                    @ActionSouth.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnActionSouth;
                    @ActionSouth.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnActionSouth;
                    @ActionSouth.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnActionSouth;
                    @DpadLeft.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnDpadLeft;
                    @DpadLeft.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnDpadLeft;
                    @DpadLeft.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnDpadLeft;
                    @DpadRight.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnDpadRight;
                    @DpadRight.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnDpadRight;
                    @DpadRight.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnDpadRight;
                    @L1.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnL1;
                    @L1.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnL1;
                    @L1.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnL1;
                    @R1.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnR1;
                    @R1.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnR1;
                    @R1.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnR1;
                }
                m_Wrapper.m_PlayerControlsActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @ActionSouth.started += instance.OnActionSouth;
                    @ActionSouth.performed += instance.OnActionSouth;
                    @ActionSouth.canceled += instance.OnActionSouth;
                    @DpadLeft.started += instance.OnDpadLeft;
                    @DpadLeft.performed += instance.OnDpadLeft;
                    @DpadLeft.canceled += instance.OnDpadLeft;
                    @DpadRight.started += instance.OnDpadRight;
                    @DpadRight.performed += instance.OnDpadRight;
                    @DpadRight.canceled += instance.OnDpadRight;
                    @L1.started += instance.OnL1;
                    @L1.performed += instance.OnL1;
                    @L1.canceled += instance.OnL1;
                    @R1.started += instance.OnR1;
                    @R1.performed += instance.OnR1;
                    @R1.canceled += instance.OnR1;
                }
            }
        }
        public PlayerControlsActions @PlayerControls => new PlayerControlsActions(this);
        public interface IPlayerControlsActions
        {
            void OnActionSouth(InputAction.CallbackContext context);
            void OnDpadLeft(InputAction.CallbackContext context);
            void OnDpadRight(InputAction.CallbackContext context);
            void OnL1(InputAction.CallbackContext context);
            void OnR1(InputAction.CallbackContext context);
        }
    }
}