using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class InputManager : MonoBehaviour
{
    [SerializeField] InputActionReference move;
    [SerializeField] InputActionReference jump;
    [SerializeField] InputActionReference ToggleMenu;

    public Vector2 MovmentValue;

    void Start()
    {
        ToggleMenu.action.started += MenuPing;
        jump.action.started += PingJump;
        
    }
    void MenuPing(InputAction.CallbackContext dat) 
    {
        EventBus.RequestEvent("ToggleMenu", true).Invoke();
    }
    void PingJump(InputAction.CallbackContext dat)
    {
        EventBus.RequestEvent("Suprise", true).Invoke();
    }
    void Update()
    {
        MovmentValue = move.action.ReadValue<Vector2>();
    }
}
