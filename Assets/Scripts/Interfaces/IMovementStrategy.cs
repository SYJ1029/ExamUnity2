using UnityEngine;

public interface IMovementStrategy
{
    void Move(Vector3 direction, Vector2 mouseInput);
}
