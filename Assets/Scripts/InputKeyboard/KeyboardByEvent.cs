using UnityEngine;
using UnityEngine.InputSystem;

public class KeyboardByEvent : MonoBehaviour, IInputProvider
{

    private Vector2 keyInput = Vector2.zero;


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
        if (context.performed)
        {
            keyInput = context.ReadValue<Vector2>();

            print(keyInput);
        }
    }


    public Vector2 GetMoveInput()
    {
        return keyInput;
    }
}
