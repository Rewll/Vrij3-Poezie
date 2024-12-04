//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.3
//     from Assets/1 Eerste vonk prototype/SpelerBesturing.inputactions
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

public partial class @SpelerBesturing: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @SpelerBesturing()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""SpelerBesturing"",
    ""maps"": [
        {
            ""name"": ""SpelerBeweging"",
            ""id"": ""d97f451e-b11f-4671-9177-6ad6642cf81f"",
            ""actions"": [
                {
                    ""name"": ""Speler1 Beweging"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ac89215c-ae81-4072-af55-cddcde511abf"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Speler2 Beweging"",
                    ""type"": ""PassThrough"",
                    ""id"": ""8fd14186-4201-4f03-9b46-e63a46e1e67d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""aabe84bb-71e7-4dd1-ac8a-f0c39a4896ce"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Speler2 Beweging"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""0edf0ced-473a-4614-95c6-0a1026657f2c"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Toetsenbord"",
                    ""action"": ""Speler2 Beweging"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0d328f52-011d-408e-80b4-83f1c14fcbec"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Toetsenbord"",
                    ""action"": ""Speler2 Beweging"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2b5e093f-4397-4d0e-99a3-2b409ce36072"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Toetsenbord"",
                    ""action"": ""Speler2 Beweging"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c28cc614-dc7b-4f2f-ad9a-c81552f36428"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Toetsenbord"",
                    ""action"": ""Speler2 Beweging"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""a212b8ec-4c0d-44ea-9def-68c5f923f4b8"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Speler1 Beweging"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""aa5d0d55-d8a9-41e6-845a-4a73dcca1ab5"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Toetsenbord"",
                    ""action"": ""Speler1 Beweging"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""b5c85739-9a1c-40f2-9eef-6da41aeeeb9e"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Toetsenbord"",
                    ""action"": ""Speler1 Beweging"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2f075c2d-dfa8-4b46-90dd-30260840aa3c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Toetsenbord"",
                    ""action"": ""Speler1 Beweging"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""386b315e-6417-45da-9dbd-173d35416b0e"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Toetsenbord"",
                    ""action"": ""Speler1 Beweging"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""ZomerSpeler1A"",
            ""id"": ""4dcfaf54-86a2-47e4-9b75-25be7a1c656c"",
            ""actions"": [
                {
                    ""name"": ""Knop1"",
                    ""type"": ""Value"",
                    ""id"": ""05babbe1-0bee-45e6-bdaa-2f4cf37ec200"",
                    ""expectedControlType"": ""Analog"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""91b075d4-a1a8-428c-aa40-9bbf99460798"",
                    ""path"": ""<Keyboard>/g"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Toetsenbord"",
                    ""action"": ""Knop1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""ZomerSpeler1B"",
            ""id"": ""eabc1a45-1def-42e3-bf26-1b88aed06cb4"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""f2883ea1-da68-482c-a5f5-bcb2d7813be5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""61ceeae3-827d-4caa-b7c0-9e490013086d"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Toetsenbord"",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""ZomerSpeler1C"",
            ""id"": ""a717792d-ecf9-4b15-aff8-64f054efe42b"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""5323af5f-791f-473f-a105-0084d58b5452"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d9ef7f8e-fef4-4f28-8df8-f9c6a4a03ff3"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Toetsenbord"",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Toetsenbord"",
            ""bindingGroup"": ""Toetsenbord"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // SpelerBeweging
        m_SpelerBeweging = asset.FindActionMap("SpelerBeweging", throwIfNotFound: true);
        m_SpelerBeweging_Speler1Beweging = m_SpelerBeweging.FindAction("Speler1 Beweging", throwIfNotFound: true);
        m_SpelerBeweging_Speler2Beweging = m_SpelerBeweging.FindAction("Speler2 Beweging", throwIfNotFound: true);
        // ZomerSpeler1A
        m_ZomerSpeler1A = asset.FindActionMap("ZomerSpeler1A", throwIfNotFound: true);
        m_ZomerSpeler1A_Knop1 = m_ZomerSpeler1A.FindAction("Knop1", throwIfNotFound: true);
        // ZomerSpeler1B
        m_ZomerSpeler1B = asset.FindActionMap("ZomerSpeler1B", throwIfNotFound: true);
        m_ZomerSpeler1B_Newaction = m_ZomerSpeler1B.FindAction("New action", throwIfNotFound: true);
        // ZomerSpeler1C
        m_ZomerSpeler1C = asset.FindActionMap("ZomerSpeler1C", throwIfNotFound: true);
        m_ZomerSpeler1C_Newaction = m_ZomerSpeler1C.FindAction("New action", throwIfNotFound: true);
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

    // SpelerBeweging
    private readonly InputActionMap m_SpelerBeweging;
    private List<ISpelerBewegingActions> m_SpelerBewegingActionsCallbackInterfaces = new List<ISpelerBewegingActions>();
    private readonly InputAction m_SpelerBeweging_Speler1Beweging;
    private readonly InputAction m_SpelerBeweging_Speler2Beweging;
    public struct SpelerBewegingActions
    {
        private @SpelerBesturing m_Wrapper;
        public SpelerBewegingActions(@SpelerBesturing wrapper) { m_Wrapper = wrapper; }
        public InputAction @Speler1Beweging => m_Wrapper.m_SpelerBeweging_Speler1Beweging;
        public InputAction @Speler2Beweging => m_Wrapper.m_SpelerBeweging_Speler2Beweging;
        public InputActionMap Get() { return m_Wrapper.m_SpelerBeweging; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SpelerBewegingActions set) { return set.Get(); }
        public void AddCallbacks(ISpelerBewegingActions instance)
        {
            if (instance == null || m_Wrapper.m_SpelerBewegingActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_SpelerBewegingActionsCallbackInterfaces.Add(instance);
            @Speler1Beweging.started += instance.OnSpeler1Beweging;
            @Speler1Beweging.performed += instance.OnSpeler1Beweging;
            @Speler1Beweging.canceled += instance.OnSpeler1Beweging;
            @Speler2Beweging.started += instance.OnSpeler2Beweging;
            @Speler2Beweging.performed += instance.OnSpeler2Beweging;
            @Speler2Beweging.canceled += instance.OnSpeler2Beweging;
        }

        private void UnregisterCallbacks(ISpelerBewegingActions instance)
        {
            @Speler1Beweging.started -= instance.OnSpeler1Beweging;
            @Speler1Beweging.performed -= instance.OnSpeler1Beweging;
            @Speler1Beweging.canceled -= instance.OnSpeler1Beweging;
            @Speler2Beweging.started -= instance.OnSpeler2Beweging;
            @Speler2Beweging.performed -= instance.OnSpeler2Beweging;
            @Speler2Beweging.canceled -= instance.OnSpeler2Beweging;
        }

        public void RemoveCallbacks(ISpelerBewegingActions instance)
        {
            if (m_Wrapper.m_SpelerBewegingActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ISpelerBewegingActions instance)
        {
            foreach (var item in m_Wrapper.m_SpelerBewegingActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_SpelerBewegingActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public SpelerBewegingActions @SpelerBeweging => new SpelerBewegingActions(this);

    // ZomerSpeler1A
    private readonly InputActionMap m_ZomerSpeler1A;
    private List<IZomerSpeler1AActions> m_ZomerSpeler1AActionsCallbackInterfaces = new List<IZomerSpeler1AActions>();
    private readonly InputAction m_ZomerSpeler1A_Knop1;
    public struct ZomerSpeler1AActions
    {
        private @SpelerBesturing m_Wrapper;
        public ZomerSpeler1AActions(@SpelerBesturing wrapper) { m_Wrapper = wrapper; }
        public InputAction @Knop1 => m_Wrapper.m_ZomerSpeler1A_Knop1;
        public InputActionMap Get() { return m_Wrapper.m_ZomerSpeler1A; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ZomerSpeler1AActions set) { return set.Get(); }
        public void AddCallbacks(IZomerSpeler1AActions instance)
        {
            if (instance == null || m_Wrapper.m_ZomerSpeler1AActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_ZomerSpeler1AActionsCallbackInterfaces.Add(instance);
            @Knop1.started += instance.OnKnop1;
            @Knop1.performed += instance.OnKnop1;
            @Knop1.canceled += instance.OnKnop1;
        }

        private void UnregisterCallbacks(IZomerSpeler1AActions instance)
        {
            @Knop1.started -= instance.OnKnop1;
            @Knop1.performed -= instance.OnKnop1;
            @Knop1.canceled -= instance.OnKnop1;
        }

        public void RemoveCallbacks(IZomerSpeler1AActions instance)
        {
            if (m_Wrapper.m_ZomerSpeler1AActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IZomerSpeler1AActions instance)
        {
            foreach (var item in m_Wrapper.m_ZomerSpeler1AActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_ZomerSpeler1AActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public ZomerSpeler1AActions @ZomerSpeler1A => new ZomerSpeler1AActions(this);

    // ZomerSpeler1B
    private readonly InputActionMap m_ZomerSpeler1B;
    private List<IZomerSpeler1BActions> m_ZomerSpeler1BActionsCallbackInterfaces = new List<IZomerSpeler1BActions>();
    private readonly InputAction m_ZomerSpeler1B_Newaction;
    public struct ZomerSpeler1BActions
    {
        private @SpelerBesturing m_Wrapper;
        public ZomerSpeler1BActions(@SpelerBesturing wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_ZomerSpeler1B_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_ZomerSpeler1B; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ZomerSpeler1BActions set) { return set.Get(); }
        public void AddCallbacks(IZomerSpeler1BActions instance)
        {
            if (instance == null || m_Wrapper.m_ZomerSpeler1BActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_ZomerSpeler1BActionsCallbackInterfaces.Add(instance);
            @Newaction.started += instance.OnNewaction;
            @Newaction.performed += instance.OnNewaction;
            @Newaction.canceled += instance.OnNewaction;
        }

        private void UnregisterCallbacks(IZomerSpeler1BActions instance)
        {
            @Newaction.started -= instance.OnNewaction;
            @Newaction.performed -= instance.OnNewaction;
            @Newaction.canceled -= instance.OnNewaction;
        }

        public void RemoveCallbacks(IZomerSpeler1BActions instance)
        {
            if (m_Wrapper.m_ZomerSpeler1BActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IZomerSpeler1BActions instance)
        {
            foreach (var item in m_Wrapper.m_ZomerSpeler1BActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_ZomerSpeler1BActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public ZomerSpeler1BActions @ZomerSpeler1B => new ZomerSpeler1BActions(this);

    // ZomerSpeler1C
    private readonly InputActionMap m_ZomerSpeler1C;
    private List<IZomerSpeler1CActions> m_ZomerSpeler1CActionsCallbackInterfaces = new List<IZomerSpeler1CActions>();
    private readonly InputAction m_ZomerSpeler1C_Newaction;
    public struct ZomerSpeler1CActions
    {
        private @SpelerBesturing m_Wrapper;
        public ZomerSpeler1CActions(@SpelerBesturing wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_ZomerSpeler1C_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_ZomerSpeler1C; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ZomerSpeler1CActions set) { return set.Get(); }
        public void AddCallbacks(IZomerSpeler1CActions instance)
        {
            if (instance == null || m_Wrapper.m_ZomerSpeler1CActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_ZomerSpeler1CActionsCallbackInterfaces.Add(instance);
            @Newaction.started += instance.OnNewaction;
            @Newaction.performed += instance.OnNewaction;
            @Newaction.canceled += instance.OnNewaction;
        }

        private void UnregisterCallbacks(IZomerSpeler1CActions instance)
        {
            @Newaction.started -= instance.OnNewaction;
            @Newaction.performed -= instance.OnNewaction;
            @Newaction.canceled -= instance.OnNewaction;
        }

        public void RemoveCallbacks(IZomerSpeler1CActions instance)
        {
            if (m_Wrapper.m_ZomerSpeler1CActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IZomerSpeler1CActions instance)
        {
            foreach (var item in m_Wrapper.m_ZomerSpeler1CActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_ZomerSpeler1CActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public ZomerSpeler1CActions @ZomerSpeler1C => new ZomerSpeler1CActions(this);
    private int m_ToetsenbordSchemeIndex = -1;
    public InputControlScheme ToetsenbordScheme
    {
        get
        {
            if (m_ToetsenbordSchemeIndex == -1) m_ToetsenbordSchemeIndex = asset.FindControlSchemeIndex("Toetsenbord");
            return asset.controlSchemes[m_ToetsenbordSchemeIndex];
        }
    }
    public interface ISpelerBewegingActions
    {
        void OnSpeler1Beweging(InputAction.CallbackContext context);
        void OnSpeler2Beweging(InputAction.CallbackContext context);
    }
    public interface IZomerSpeler1AActions
    {
        void OnKnop1(InputAction.CallbackContext context);
    }
    public interface IZomerSpeler1BActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
    public interface IZomerSpeler1CActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
