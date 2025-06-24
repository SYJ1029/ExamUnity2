using UnityEngine;
using UnityEngine.InputSystem;

public class KeyboardSM : MonoBehaviour, IInputProvider
{
    private Vector2 keyInput = Vector2.zero;
    private Vector2 lookInput = Vector2.zero;

    public void OnMove(InputValue value)
    {

        keyInput = value.Get<Vector2>();

        print(keyInput);

    }

    public void OnLook(InputValue value)
    {
        lookInput = value.Get<Vector2>();
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
