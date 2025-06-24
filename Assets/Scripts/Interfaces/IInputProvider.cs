using UnityEngine;

public interface IInputProvider
{
    Vector2 GetMoveInput();
    Vector2 GetMouseInput();
}