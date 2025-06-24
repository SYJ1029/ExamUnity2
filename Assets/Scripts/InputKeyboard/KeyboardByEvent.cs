using UnityEngine;
using UnityEngine.InputSystem;

public class KeyboardByEvent : MonoBehaviour, IInputProvider
{

    private Vector2 keyInput = Vector2.zero;
    private Vector2 lookInput = Vector2.zero;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void OnMove(InputAction.CallbackContext context)
    {
        if (context.performed || context.canceled)
        {
            keyInput = context.ReadValue<Vector2>();

            print(keyInput);
        }
    }

    public void OnLook(InputAction.CallbackContext context)
    {
        if (context.performed || context.canceled)
        {
            keyInput = context.ReadValue<Vector2>();

            print(keyInput);
        }
    }


    public Vector2 GetMoveInput()
    {
        return keyInput;
    }

    public Vector2 GetMouseInput()
    {
        return lookInput;
    }
}
