// GENERATED AUTOMATICALLY FROM 'Assets/Input/GameInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @GameInputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @GameInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameInputActions"",
    ""maps"": [
        {
            ""name"": ""Normal"",
            ""id"": ""efcef831-872e-40fb-a6a9-8984a2f35875"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""9411bc4f-2f8c-49fc-aad4-ba6872ebd0e3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ChangeColorRed"",
                    ""type"": ""Button"",
                    ""id"": ""56576b21-a47f-4392-86ca-3fceda80a303"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ChangeColorGreen"",
                    ""type"": ""Button"",
                    ""id"": ""ac7cd77f-5274-4d96-843b-204ae8465731"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ChangeColorBlue"",
                    ""type"": ""Button"",
                    ""id"": ""f7920f0b-3a95-4ef2-8083-324658c42bd7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ChangeColorPurple"",
                    ""type"": ""Button"",
                    ""id"": ""fbf32d1b-6fd6-447f-843f-0f2f543e333e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0a972a2b-85b0-44e1-ac86-c26c1880e840"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""52b64bdd-ccf4-4f4f-a02a-66766a37470e"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""ChangeColorRed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0f994302-c6a2-442a-9e7d-347c18cf4a64"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""ChangeColorGreen"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""22326d4a-74d2-4f00-b952-13f9d42420e3"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeColorBlue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bd22781b-c6b7-428d-8284-443b243ded05"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeColorPurple"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard & Mouse"",
            ""bindingGroup"": ""Keyboard & Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<VirtualMouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Normal
        m_Normal = asset.FindActionMap("Normal", throwIfNotFound: true);
        m_Normal_Jump = m_Normal.FindAction("Jump", throwIfNotFound: true);
        m_Normal_ChangeColorRed = m_Normal.FindAction("ChangeColorRed", throwIfNotFound: true);
        m_Normal_ChangeColorGreen = m_Normal.FindAction("ChangeColorGreen", throwIfNotFound: true);
        m_Normal_ChangeColorBlue = m_Normal.FindAction("ChangeColorBlue", throwIfNotFound: true);
        m_Normal_ChangeColorPurple = m_Normal.FindAction("ChangeColorPurple", throwIfNotFound: true);
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

    // Normal
    private readonly InputActionMap m_Normal;
    private INormalActions m_NormalActionsCallbackInterface;
    private readonly InputAction m_Normal_Jump;
    private readonly InputAction m_Normal_ChangeColorRed;
    private readonly InputAction m_Normal_ChangeColorGreen;
    private readonly InputAction m_Normal_ChangeColorBlue;
    private readonly InputAction m_Normal_ChangeColorPurple;
    public struct NormalActions
    {
        private @GameInputActions m_Wrapper;
        public NormalActions(@GameInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_Normal_Jump;
        public InputAction @ChangeColorRed => m_Wrapper.m_Normal_ChangeColorRed;
        public InputAction @ChangeColorGreen => m_Wrapper.m_Normal_ChangeColorGreen;
        public InputAction @ChangeColorBlue => m_Wrapper.m_Normal_ChangeColorBlue;
        public InputAction @ChangeColorPurple => m_Wrapper.m_Normal_ChangeColorPurple;
        public InputActionMap Get() { return m_Wrapper.m_Normal; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(NormalActions set) { return set.Get(); }
        public void SetCallbacks(INormalActions instance)
        {
            if (m_Wrapper.m_NormalActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_NormalActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_NormalActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_NormalActionsCallbackInterface.OnJump;
                @ChangeColorRed.started -= m_Wrapper.m_NormalActionsCallbackInterface.OnChangeColorRed;
                @ChangeColorRed.performed -= m_Wrapper.m_NormalActionsCallbackInterface.OnChangeColorRed;
                @ChangeColorRed.canceled -= m_Wrapper.m_NormalActionsCallbackInterface.OnChangeColorRed;
                @ChangeColorGreen.started -= m_Wrapper.m_NormalActionsCallbackInterface.OnChangeColorGreen;
                @ChangeColorGreen.performed -= m_Wrapper.m_NormalActionsCallbackInterface.OnChangeColorGreen;
                @ChangeColorGreen.canceled -= m_Wrapper.m_NormalActionsCallbackInterface.OnChangeColorGreen;
                @ChangeColorBlue.started -= m_Wrapper.m_NormalActionsCallbackInterface.OnChangeColorBlue;
                @ChangeColorBlue.performed -= m_Wrapper.m_NormalActionsCallbackInterface.OnChangeColorBlue;
                @ChangeColorBlue.canceled -= m_Wrapper.m_NormalActionsCallbackInterface.OnChangeColorBlue;
                @ChangeColorPurple.started -= m_Wrapper.m_NormalActionsCallbackInterface.OnChangeColorPurple;
                @ChangeColorPurple.performed -= m_Wrapper.m_NormalActionsCallbackInterface.OnChangeColorPurple;
                @ChangeColorPurple.canceled -= m_Wrapper.m_NormalActionsCallbackInterface.OnChangeColorPurple;
            }
            m_Wrapper.m_NormalActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @ChangeColorRed.started += instance.OnChangeColorRed;
                @ChangeColorRed.performed += instance.OnChangeColorRed;
                @ChangeColorRed.canceled += instance.OnChangeColorRed;
                @ChangeColorGreen.started += instance.OnChangeColorGreen;
                @ChangeColorGreen.performed += instance.OnChangeColorGreen;
                @ChangeColorGreen.canceled += instance.OnChangeColorGreen;
                @ChangeColorBlue.started += instance.OnChangeColorBlue;
                @ChangeColorBlue.performed += instance.OnChangeColorBlue;
                @ChangeColorBlue.canceled += instance.OnChangeColorBlue;
                @ChangeColorPurple.started += instance.OnChangeColorPurple;
                @ChangeColorPurple.performed += instance.OnChangeColorPurple;
                @ChangeColorPurple.canceled += instance.OnChangeColorPurple;
            }
        }
    }
    public NormalActions @Normal => new NormalActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard & Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    public interface INormalActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnChangeColorRed(InputAction.CallbackContext context);
        void OnChangeColorGreen(InputAction.CallbackContext context);
        void OnChangeColorBlue(InputAction.CallbackContext context);
        void OnChangeColorPurple(InputAction.CallbackContext context);
    }
}
