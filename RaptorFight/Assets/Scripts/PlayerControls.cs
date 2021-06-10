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
            ""name"": ""Land"",
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
                    ""name"": ""WallClimb"",
                    ""type"": ""PassThrough"",
                    ""id"": ""2ed57162-66e9-43a2-a82f-7e1da5a886b1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""WallGrab"",
                    ""type"": ""Button"",
                    ""id"": ""ad4f182b-7596-4b94-8ffc-7925d6cb7c16"",
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
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""4c171fb5-00ce-4830-a00f-539f7d05452b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Melee Attack"",
                    ""type"": ""Button"",
                    ""id"": ""4a6e9f36-cb82-4f30-9673-9c3933a8b6ca"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""7d19725a-ac83-463f-a0f9-2a0a41a604c3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ChangeForm_Yellow"",
                    ""type"": ""Button"",
                    ""id"": ""6a2e687d-4898-4d5d-ba9b-0506c00c3652"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ChangeForm_Blue"",
                    ""type"": ""Button"",
                    ""id"": ""7099e84f-eaa7-4a64-8df1-fdfbf6a494c3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ChangeForm_Red"",
                    ""type"": ""Button"",
                    ""id"": ""bfd018f8-61ee-494f-9bfe-d75475259aa9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ChangeForm_Green"",
                    ""type"": ""Button"",
                    ""id"": ""e116572e-485c-4b39-babd-fc2172cce194"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DashRight"",
                    ""type"": ""Button"",
                    ""id"": ""3127f792-9bc7-46bb-94bc-6b1b90579377"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DashLeft"",
                    ""type"": ""Button"",
                    ""id"": ""69fa0b3c-efdb-4aa8-91ac-e9c67cf2a6ff"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MousePosition"",
                    ""type"": ""Value"",
                    ""id"": ""6feb6a3d-af11-4ed3-83f1-b894935f1d7a"",
                    ""expectedControlType"": ""Vector2"",
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
                    ""groups"": """",
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
                    ""groups"": """",
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
                    ""groups"": """",
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
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
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
                    ""groups"": """",
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
                    ""groups"": """",
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
                    ""groups"": """",
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
                    ""groups"": """",
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
                    ""groups"": """",
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
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8c71729d-8055-482e-aa58-ddeb2cc5ec40"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Melee Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0cd55664-9604-4584-a07c-fba400397197"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Melee Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""db8d42a4-9b52-47cb-9f3c-7318097dc4d5"",
                    ""path"": ""<Mouse>/backButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Melee Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""45102c5d-25f2-4d00-a835-d7dcdad53fa0"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""53056f1e-57a2-4927-a3dc-c1139db091e4"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""95ad24c1-1f19-4d44-8d50-ab2c548b36e3"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeForm_Yellow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3454d509-87d0-4ea1-91b0-86ba558765a5"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeForm_Yellow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d7bff9b4-f33f-491c-b042-dc7572e2d531"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeForm_Blue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a4aa4133-4a16-4b9f-8840-a48d41bf856f"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeForm_Blue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ba239d59-16a1-475a-a58f-66481a3d4688"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeForm_Red"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""64229bad-3ab8-43f3-8d52-369a347f514f"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeForm_Red"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dc668cc9-c815-4e9f-b806-ebba2e6627e3"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeForm_Green"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8e4a1396-89f8-42d2-9dd5-192ab2e51fe1"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeForm_Green"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WS"",
                    ""id"": ""88fab757-b4ad-43f0-be7f-8e1eb9231e3d"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WallClimb"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""55a47281-dd7d-49ef-83bb-2e0fca1aefbd"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WallClimb"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""2a0f4216-94d7-4713-8b1e-92ffc7eafd34"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WallClimb"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""LStick"",
                    ""id"": ""4c948ddb-0f7f-48dc-9692-765b1492d9b8"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WallClimb"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""16d528b9-bb32-4cb2-ae1c-dde037220375"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WallClimb"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""e0622be5-2a69-4d8d-b0df-613233b8620b"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WallClimb"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""77f63a33-7b8a-4cad-9d65-58414480913e"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
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
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d72a0374-3d9f-4afb-812e-96e89d37d763"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WallGrab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""383dcf7d-5ea1-41a5-a92d-100301ebaf07"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WallGrab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ca0245e5-32be-4d05-ab04-7f620e37cf9c"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DashRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""db8c6baf-3df9-4803-8d8e-b6eb04dbd23a"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DashRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bdda9192-b409-4c3c-b48e-e3a95cb444ac"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DashLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""374e5f24-6a6c-4a7c-9baf-9e79d3fa3f19"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DashLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e2b7ce75-ae2e-411d-8549-e7af6a27d8b0"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MousePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5ce837e8-d660-47c2-b392-53c13f9b084b"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f862cdf7-06bc-4106-9ece-8c5a8a8b9aef"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0a0c6e3c-f04f-4fca-a20f-bcb180f3e3d4"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
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
                    ""groups"": """",
                    ""action"": ""Leap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Land
        m_Land = asset.FindActionMap("Land", throwIfNotFound: true);
        m_Land_Movement = m_Land.FindAction("Movement", throwIfNotFound: true);
        m_Land_Sprint = m_Land.FindAction("Sprint", throwIfNotFound: true);
        m_Land_WallClimb = m_Land.FindAction("WallClimb", throwIfNotFound: true);
        m_Land_WallGrab = m_Land.FindAction("WallGrab", throwIfNotFound: true);
        m_Land_Jump = m_Land.FindAction("Jump", throwIfNotFound: true);
        m_Land_Leap = m_Land.FindAction("Leap", throwIfNotFound: true);
        m_Land_Attack = m_Land.FindAction("Attack", throwIfNotFound: true);
        m_Land_MeleeAttack = m_Land.FindAction("Melee Attack", throwIfNotFound: true);
        m_Land_Crouch = m_Land.FindAction("Crouch", throwIfNotFound: true);
        m_Land_ChangeForm_Yellow = m_Land.FindAction("ChangeForm_Yellow", throwIfNotFound: true);
        m_Land_ChangeForm_Blue = m_Land.FindAction("ChangeForm_Blue", throwIfNotFound: true);
        m_Land_ChangeForm_Red = m_Land.FindAction("ChangeForm_Red", throwIfNotFound: true);
        m_Land_ChangeForm_Green = m_Land.FindAction("ChangeForm_Green", throwIfNotFound: true);
        m_Land_DashRight = m_Land.FindAction("DashRight", throwIfNotFound: true);
        m_Land_DashLeft = m_Land.FindAction("DashLeft", throwIfNotFound: true);
        m_Land_MousePosition = m_Land.FindAction("MousePosition", throwIfNotFound: true);
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

    // Land
    private readonly InputActionMap m_Land;
    private ILandActions m_LandActionsCallbackInterface;
    private readonly InputAction m_Land_Movement;
    private readonly InputAction m_Land_Sprint;
    private readonly InputAction m_Land_WallClimb;
    private readonly InputAction m_Land_WallGrab;
    private readonly InputAction m_Land_Jump;
    private readonly InputAction m_Land_Leap;
    private readonly InputAction m_Land_Attack;
    private readonly InputAction m_Land_MeleeAttack;
    private readonly InputAction m_Land_Crouch;
    private readonly InputAction m_Land_ChangeForm_Yellow;
    private readonly InputAction m_Land_ChangeForm_Blue;
    private readonly InputAction m_Land_ChangeForm_Red;
    private readonly InputAction m_Land_ChangeForm_Green;
    private readonly InputAction m_Land_DashRight;
    private readonly InputAction m_Land_DashLeft;
    private readonly InputAction m_Land_MousePosition;
    public struct LandActions
    {
        private @PlayerControls m_Wrapper;
        public LandActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Land_Movement;
        public InputAction @Sprint => m_Wrapper.m_Land_Sprint;
        public InputAction @WallClimb => m_Wrapper.m_Land_WallClimb;
        public InputAction @WallGrab => m_Wrapper.m_Land_WallGrab;
        public InputAction @Jump => m_Wrapper.m_Land_Jump;
        public InputAction @Leap => m_Wrapper.m_Land_Leap;
        public InputAction @Attack => m_Wrapper.m_Land_Attack;
        public InputAction @MeleeAttack => m_Wrapper.m_Land_MeleeAttack;
        public InputAction @Crouch => m_Wrapper.m_Land_Crouch;
        public InputAction @ChangeForm_Yellow => m_Wrapper.m_Land_ChangeForm_Yellow;
        public InputAction @ChangeForm_Blue => m_Wrapper.m_Land_ChangeForm_Blue;
        public InputAction @ChangeForm_Red => m_Wrapper.m_Land_ChangeForm_Red;
        public InputAction @ChangeForm_Green => m_Wrapper.m_Land_ChangeForm_Green;
        public InputAction @DashRight => m_Wrapper.m_Land_DashRight;
        public InputAction @DashLeft => m_Wrapper.m_Land_DashLeft;
        public InputAction @MousePosition => m_Wrapper.m_Land_MousePosition;
        public InputActionMap Get() { return m_Wrapper.m_Land; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LandActions set) { return set.Get(); }
        public void SetCallbacks(ILandActions instance)
        {
            if (m_Wrapper.m_LandActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_LandActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnMovement;
                @Sprint.started -= m_Wrapper.m_LandActionsCallbackInterface.OnSprint;
                @Sprint.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnSprint;
                @Sprint.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnSprint;
                @WallClimb.started -= m_Wrapper.m_LandActionsCallbackInterface.OnWallClimb;
                @WallClimb.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnWallClimb;
                @WallClimb.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnWallClimb;
                @WallGrab.started -= m_Wrapper.m_LandActionsCallbackInterface.OnWallGrab;
                @WallGrab.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnWallGrab;
                @WallGrab.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnWallGrab;
                @Jump.started -= m_Wrapper.m_LandActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnJump;
                @Leap.started -= m_Wrapper.m_LandActionsCallbackInterface.OnLeap;
                @Leap.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnLeap;
                @Leap.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnLeap;
                @Attack.started -= m_Wrapper.m_LandActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnAttack;
                @MeleeAttack.started -= m_Wrapper.m_LandActionsCallbackInterface.OnMeleeAttack;
                @MeleeAttack.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnMeleeAttack;
                @MeleeAttack.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnMeleeAttack;
                @Crouch.started -= m_Wrapper.m_LandActionsCallbackInterface.OnCrouch;
                @Crouch.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnCrouch;
                @Crouch.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnCrouch;
                @ChangeForm_Yellow.started -= m_Wrapper.m_LandActionsCallbackInterface.OnChangeForm_Yellow;
                @ChangeForm_Yellow.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnChangeForm_Yellow;
                @ChangeForm_Yellow.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnChangeForm_Yellow;
                @ChangeForm_Blue.started -= m_Wrapper.m_LandActionsCallbackInterface.OnChangeForm_Blue;
                @ChangeForm_Blue.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnChangeForm_Blue;
                @ChangeForm_Blue.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnChangeForm_Blue;
                @ChangeForm_Red.started -= m_Wrapper.m_LandActionsCallbackInterface.OnChangeForm_Red;
                @ChangeForm_Red.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnChangeForm_Red;
                @ChangeForm_Red.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnChangeForm_Red;
                @ChangeForm_Green.started -= m_Wrapper.m_LandActionsCallbackInterface.OnChangeForm_Green;
                @ChangeForm_Green.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnChangeForm_Green;
                @ChangeForm_Green.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnChangeForm_Green;
                @DashRight.started -= m_Wrapper.m_LandActionsCallbackInterface.OnDashRight;
                @DashRight.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnDashRight;
                @DashRight.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnDashRight;
                @DashLeft.started -= m_Wrapper.m_LandActionsCallbackInterface.OnDashLeft;
                @DashLeft.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnDashLeft;
                @DashLeft.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnDashLeft;
                @MousePosition.started -= m_Wrapper.m_LandActionsCallbackInterface.OnMousePosition;
                @MousePosition.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnMousePosition;
                @MousePosition.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnMousePosition;
            }
            m_Wrapper.m_LandActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Sprint.started += instance.OnSprint;
                @Sprint.performed += instance.OnSprint;
                @Sprint.canceled += instance.OnSprint;
                @WallClimb.started += instance.OnWallClimb;
                @WallClimb.performed += instance.OnWallClimb;
                @WallClimb.canceled += instance.OnWallClimb;
                @WallGrab.started += instance.OnWallGrab;
                @WallGrab.performed += instance.OnWallGrab;
                @WallGrab.canceled += instance.OnWallGrab;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Leap.started += instance.OnLeap;
                @Leap.performed += instance.OnLeap;
                @Leap.canceled += instance.OnLeap;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @MeleeAttack.started += instance.OnMeleeAttack;
                @MeleeAttack.performed += instance.OnMeleeAttack;
                @MeleeAttack.canceled += instance.OnMeleeAttack;
                @Crouch.started += instance.OnCrouch;
                @Crouch.performed += instance.OnCrouch;
                @Crouch.canceled += instance.OnCrouch;
                @ChangeForm_Yellow.started += instance.OnChangeForm_Yellow;
                @ChangeForm_Yellow.performed += instance.OnChangeForm_Yellow;
                @ChangeForm_Yellow.canceled += instance.OnChangeForm_Yellow;
                @ChangeForm_Blue.started += instance.OnChangeForm_Blue;
                @ChangeForm_Blue.performed += instance.OnChangeForm_Blue;
                @ChangeForm_Blue.canceled += instance.OnChangeForm_Blue;
                @ChangeForm_Red.started += instance.OnChangeForm_Red;
                @ChangeForm_Red.performed += instance.OnChangeForm_Red;
                @ChangeForm_Red.canceled += instance.OnChangeForm_Red;
                @ChangeForm_Green.started += instance.OnChangeForm_Green;
                @ChangeForm_Green.performed += instance.OnChangeForm_Green;
                @ChangeForm_Green.canceled += instance.OnChangeForm_Green;
                @DashRight.started += instance.OnDashRight;
                @DashRight.performed += instance.OnDashRight;
                @DashRight.canceled += instance.OnDashRight;
                @DashLeft.started += instance.OnDashLeft;
                @DashLeft.performed += instance.OnDashLeft;
                @DashLeft.canceled += instance.OnDashLeft;
                @MousePosition.started += instance.OnMousePosition;
                @MousePosition.performed += instance.OnMousePosition;
                @MousePosition.canceled += instance.OnMousePosition;
            }
        }
    }
    public LandActions @Land => new LandActions(this);
    public interface ILandActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnWallClimb(InputAction.CallbackContext context);
        void OnWallGrab(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnLeap(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnMeleeAttack(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnChangeForm_Yellow(InputAction.CallbackContext context);
        void OnChangeForm_Blue(InputAction.CallbackContext context);
        void OnChangeForm_Red(InputAction.CallbackContext context);
        void OnChangeForm_Green(InputAction.CallbackContext context);
        void OnDashRight(InputAction.CallbackContext context);
        void OnDashLeft(InputAction.CallbackContext context);
        void OnMousePosition(InputAction.CallbackContext context);
    }
}
