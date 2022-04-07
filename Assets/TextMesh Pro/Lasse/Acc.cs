// GENERATED AUTOMATICALLY FROM 'Assets/TextMesh Pro/Lasse/Acc.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Acc : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Acc()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Acc"",
    ""maps"": [
        {
            ""name"": ""GetAcc"",
            ""id"": ""ee1b3f01-e043-4365-8f5b-e1a025311b50"",
            ""actions"": [
                {
                    ""name"": ""AccData"",
                    ""type"": ""Value"",
                    ""id"": ""3def7c69-6871-4cb2-9eef-9e9cca78ae7c"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5f0cc5c8-664a-48e3-8b70-7ea11207b68a"",
                    ""path"": ""<Accelerometer>/acceleration"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AccData"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // GetAcc
        m_GetAcc = asset.FindActionMap("GetAcc", throwIfNotFound: true);
        m_GetAcc_AccData = m_GetAcc.FindAction("AccData", throwIfNotFound: true);
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

    // GetAcc
    private readonly InputActionMap m_GetAcc;
    private IGetAccActions m_GetAccActionsCallbackInterface;
    private readonly InputAction m_GetAcc_AccData;
    public struct GetAccActions
    {
        private @Acc m_Wrapper;
        public GetAccActions(@Acc wrapper) { m_Wrapper = wrapper; }
        public InputAction @AccData => m_Wrapper.m_GetAcc_AccData;
        public InputActionMap Get() { return m_Wrapper.m_GetAcc; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GetAccActions set) { return set.Get(); }
        public void SetCallbacks(IGetAccActions instance)
        {
            if (m_Wrapper.m_GetAccActionsCallbackInterface != null)
            {
                @AccData.started -= m_Wrapper.m_GetAccActionsCallbackInterface.OnAccData;
                @AccData.performed -= m_Wrapper.m_GetAccActionsCallbackInterface.OnAccData;
                @AccData.canceled -= m_Wrapper.m_GetAccActionsCallbackInterface.OnAccData;
            }
            m_Wrapper.m_GetAccActionsCallbackInterface = instance;
            if (instance != null)
            {
                @AccData.started += instance.OnAccData;
                @AccData.performed += instance.OnAccData;
                @AccData.canceled += instance.OnAccData;
            }
        }
    }
    public GetAccActions @GetAcc => new GetAccActions(this);
    public interface IGetAccActions
    {
        void OnAccData(InputAction.CallbackContext context);
    }
}
