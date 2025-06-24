using UnityEngine;

public class PlayerControllerFactory : MonoBehaviour
{
    [SerializeField] MonoBehaviour inputProviderObject;
    [SerializeField] MonoBehaviour movementStrategyObject;

    private IInputProvider inputProvider;
    private IMovementStrategy movementStrategy;

    void Awake()
    {
        inputProvider = inputProviderObject as IInputProvider;

        movementStrategy = movementStrategyObject as IMovementStrategy;

        if (inputProvider == null || movementStrategy == null)
            Debug.LogError("������Ʈ�� �������̽��� �������� ����!");

    }

    void Update()
    {
        Vector2 input = inputProvider.GetMoveInput();
        Vector2 mouseInput = inputProvider.GetMouseInput();
        
        Vector3 direction = new Vector3(input.x, 0, input.y);
        movementStrategy.Move(direction, mouseInput);
    }
}
