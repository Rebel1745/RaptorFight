// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""GameControls"",
            ""id"": ""5a06f747-3aba-43e4-b616-405022081f75"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""d9ff1bff-447e-4a21-ad39-9472b957517f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""b7f41d11-8dde-47b1-a0d1-0b7ac6fcfb18"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""11f1c626-42d1-4fe4-844e-65e02bfef468"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Leap"",
                    ""type"": ""Button"",
                    ""id"": ""6a9dffb3-d324-4efd-9efc-f0b53b799cbc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AttackLeft"",
                    ""type"": ""Button"",
                    ""id"": ""4c171fb5-00ce-4830-a00f-539f7d05452b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AttackRight"",
                    ""type"": ""Button"",
                    ""id"": ""b5fde96b-f9c6-4cd0-b14e-186420856b99"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AttackTailWhip"",
                    ""type"": ""Button"",
                    ""id"": ""4a6e9f36-cb82-4f30-9673-9c3933a8b6ca"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AttackKick"",
                    ""type"": ""Button"",
                    ""id"": ""e4e683d7-aaa6-4ce5-a4d1-78c659508e0f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AttackBiteForward"",
                    ""type"": ""Button"",
                    ""id"": ""490e70be-9e58-48d2-9f60-8d57949d1d28"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AttackBiteDown"",
                    ""type"": ""Button"",
                    ""id"": ""f0d46b44-1e91-41be-9d31-3c67632886ff"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""3127f792-9bc7-46bb-94bc-6b1b90579377"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""GroundSlam"",
                    ""type"": ""Button"",
                    ""id"": ""0838a644-ca49-401b-b5bd-cb4f3bf0c227"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""356c61bb-2417-4667-8fa6-ea07b64fdcc7"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""244ccd7d-db9f-4279-90eb-a8dfca232172"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""3012815f-3bd2-4088-9dae-fdb863359999"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""02ae0a96-f51e-4964-b345-3acf7324407a"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e255d797-91d2-48ae-b682-5fe906d9357d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""LeftStick"",
                    ""id"": ""6edbc5a4-1b82-40e0-92af-5482e3d08dfc"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""bb2ab8c8-ff2c-4d74-b78c-67abcf1dfb2d"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a68a8c1f-6743-4fc2-b100-d086a15e4ac1"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""995b5f44-e67d-4316-bde2-0fbc652b9497"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""3ec803c2-e6b0-4d16-9be9-87ee8f47a06c"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""54481355-4242-42a2-9fcf-02fd8da91dc2"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0a63f696-87d6-43a9-84d5-9f11dbcab579"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0cd55664-9604-4584-a07c-fba400397197"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""AttackTailWhip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""db8d42a4-9b52-47cb-9f3c-7318097dc4d5"",
                    ""path"": ""<Mouse>/backButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""AttackTailWhip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""77f63a33-7b8a-4cad-9d65-58414480913e"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1e4ad0dd-d17a-443e-86dd-fbb79e25ade0"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ca0245e5-32be-4d05-ab04-7f620e37cf9c"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""db8c6baf-3df9-4803-8d8e-b6eb04dbd23a"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5ce837e8-d660-47c2-b392-53c13f9b084b"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""AttackLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f862cdf7-06bc-4106-9ece-8c5a8a8b9aef"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""AttackLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0a0c6e3c-f04f-4fca-a20f-bcb180f3e3d4"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Leap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""62c05174-2bbd-4dc4-86f6-be52ef91eeee"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Leap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9da1a020-71fb-42c1-bdfc-20c89f7b171e"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""GroundSlam"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""37f3628e-23b2-472d-b9e0-47f70c419643"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""GroundSlam"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7ef1d825-e1cf-47b0-9825-ab1cca5f2d1f"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""AttackRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""70a7762e-f10d-4605-9fbf-c13108de3790"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""AttackKick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""82cc52cd-927f-471c-8342-778435bcac2b"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""AttackBiteForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a037e3a5-7801-4f38-aafe-31347220abe5"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""AttackBiteDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard&Mouse"",
            ""bindingGroup"": ""Keyboard&Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // GameControls
        m_GameControls = asset.FindActionMap("GameControls", throwIfNotFound: true);
        m_GameControls_Movement = m_GameControls.FindAction("Movement", throwIfNotFound: true);
        m_GameControls_Sprint = m_GameControls.FindAction("Sprint", throwIfNotFound: true);
        m_GameControls_Jump = m_GameControls.FindAction("Jump", throwIfNotFound: true);
        m_GameControls_Leap = m_GameControls.FindAction("Leap", throwIfNotFound: true);
        m_GameControls_AttackLeft = m_GameControls.FindAction("AttackLeft", throwIfNotFound: true);
        m_GameControls_AttackRight = m_GameControls.FindAction("AttackRight", throwIfNotFound: true);
        m_GameControls_AttackTailWhip = m_GameControls.FindAction("AttackTailWhip", throwIfNotFound: true);
        m_GameControls_AttackKick = m_GameControls.FindAction("AttackKick", throwIfNotFound: true);
        m_GameControls_AttackBiteForward = m_GameControls.FindAction("AttackBiteForward", throwIfNotFound: true);
        m_GameControls_AttackBiteDown = m_GameControls.FindAction("AttackBiteDown", throwIfNotFound: true);
        m_GameControls_Dash = m_GameControls.FindAction("Dash", throwIfNotFound: true);
        m_GameControls_GroundSlam = m_GameControls.FindAction("GroundSlam", throwIfNotFound: true);
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

    // GameControls
    private readonly InputActionMap m_GameControls;
    private IGameControlsActions m_GameControlsActionsCallbackInterface;
    private readonly InputAction m_GameControls_Movement;
    private readonly InputAction m_GameControls_Sprint;
    private readonly InputAction m_GameControls_Jump;
    private readonly InputAction m_GameControls_Leap;
    private readonly InputAction m_GameControls_AttackLeft;
    private readonly InputAction m_GameControls_AttackRight;
    private readonly InputAction m_GameControls_AttackTailWhip;
    private readonly InputAction m_GameControls_AttackKick;
    private readonly InputAction m_GameControls_AttackBiteForward;
    private readonly InputAction m_GameControls_AttackBiteDown;
    private readonly InputAction m_GameControls_Dash;
    private readonly InputAction m_GameControls_GroundSlam;
    public struct GameControlsActions
    {
        private @PlayerControls m_Wrapper;
        public GameControlsActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_GameControls_Movement;
        public InputAction @Sprint => m_Wrapper.m_GameControls_Sprint;
        public InputAction @Jump => m_Wrapper.m_GameControls_Jump;
        public InputAction @Leap => m_Wrapper.m_GameControls_Leap;
        public InputAction @AttackLeft => m_Wrapper.m_GameControls_AttackLeft;
        public InputAction @AttackRight => m_Wrapper.m_GameControls_AttackRight;
        public InputAction @AttackTailWhip => m_Wrapper.m_GameControls_AttackTailWhip;
        public InputAction @AttackKick => m_Wrapper.m_GameControls_AttackKick;
        public InputAction @AttackBiteForward => m_Wrapper.m_GameControls_AttackBiteForward;
        public InputAction @AttackBiteDown => m_Wrapper.m_GameControls_AttackBiteDown;
        public InputAction @Dash => m_Wrapper.m_GameControls_Dash;
        public InputAction @GroundSlam => m_Wrapper.m_GameControls_GroundSlam;
        public InputActionMap Get() { return m_Wrapper.m_GameControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameControlsActions set) { return set.Get(); }
        public void SetCallbacks(IGameControlsActions instance)
        {
            if (m_Wrapper.m_GameControlsActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnMovement;
                @Sprint.started -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnSprint;
                @Sprint.performed -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnSprint;
                @Sprint.canceled -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnSprint;
                @Jump.started -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnJump;
                @Leap.started -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnLeap;
                @Leap.performed -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnLeap;
                @Leap.canceled -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnLeap;
                @AttackLeft.started -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnAttackLeft;
                @AttackLeft.performed -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnAttackLeft;
                @AttackLeft.canceled -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnAttackLeft;
                @AttackRight.started -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnAttackRight;
                @AttackRight.performed -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnAttackRight;
                @AttackRight.canceled -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnAttackRight;
                @AttackTailWhip.started -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnAttackTailWhip;
                @AttackTailWhip.performed -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnAttackTailWhip;
                @AttackTailWhip.canceled -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnAttackTailWhip;
                @AttackKick.started -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnAttackKick;
                @AttackKick.performed -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnAttackKick;
                @AttackKick.canceled -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnAttackKick;
                @AttackBiteForward.started -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnAttackBiteForward;
                @AttackBiteForward.performed -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnAttackBiteForward;
                @AttackBiteForward.canceled -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnAttackBiteForward;
                @AttackBiteDown.started -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnAttackBiteDown;
                @AttackBiteDown.performed -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnAttackBiteDown;
                @AttackBiteDown.canceled -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnAttackBiteDown;
                @Dash.started -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnDash;
                @Dash.performed -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnDash;
                @Dash.canceled -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnDash;
                @GroundSlam.started -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnGroundSlam;
                @GroundSlam.performed -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnGroundSlam;
                @GroundSlam.canceled -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnGroundSlam;
            }
            m_Wrapper.m_GameControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Sprint.started += instance.OnSprint;
                @Sprint.performed += instance.OnSprint;
                @Sprint.canceled += instance.OnSprint;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Leap.started += instance.OnLeap;
                @Leap.performed += instance.OnLeap;
                @Leap.canceled += instance.OnLeap;
                @AttackLeft.started += instance.OnAttackLeft;
                @AttackLeft.performed += instance.OnAttackLeft;
                @AttackLeft.canceled += instance.OnAttackLeft;
                @AttackRight.started += instance.OnAttackRight;
                @AttackRight.performed += instance.OnAttackRight;
                @AttackRight.canceled += instance.OnAttackRight;
                @AttackTailWhip.started += instance.OnAttackTailWhip;
                @AttackTailWhip.performed += instance.OnAttackTailWhip;
                @AttackTailWhip.canceled += instance.OnAttackTailWhip;
                @AttackKick.started += instance.OnAttackKick;
                @AttackKick.performed += instance.OnAttackKick;
                @AttackKick.canceled += instance.OnAttackKick;
                @AttackBiteForward.started += instance.OnAttackBiteForward;
                @AttackBiteForward.performed += instance.OnAttackBiteForward;
                @AttackBiteForward.canceled += instance.OnAttackBiteForward;
                @AttackBiteDown.started += instance.OnAttackBiteDown;
                @AttackBiteDown.performed += instance.OnAttackBiteDown;
                @AttackBiteDown.canceled += instance.OnAttackBiteDown;
                @Dash.started += instance.OnDash;
                @Dash.performed += instance.OnDash;
                @Dash.canceled += instance.OnDash;
                @GroundSlam.started += instance.OnGroundSlam;
                @GroundSlam.performed += instance.OnGroundSlam;
                @GroundSlam.canceled += instance.OnGroundSlam;
            }
        }
    }
    public GameControlsActions @GameControls => new GameControlsActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IGameControlsActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnLeap(InputAction.CallbackContext context);
        void OnAttackLeft(InputAction.CallbackContext context);
        void OnAttackRight(InputAction.CallbackContext context);
        void OnAttackTailWhip(InputAction.CallbackContext context);
        void OnAttackKick(InputAction.CallbackContext context);
        void OnAttackBiteForward(InputAction.CallbackContext context);
        void OnAttackBiteDown(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
        void OnGroundSlam(InputAction.CallbackContext context);
    }
}
