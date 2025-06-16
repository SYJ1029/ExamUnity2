using Unity.VisualScripting.InputSystem;
using UnityEngine;
using UnityEngine.InputSystem;

public class CarMove : MonoBehaviour
{

    CharacterController controller;

    public float moveForce;
    public float maxSpeed;
    public float linearDampling;

    Vector3 movevalue = Vector3.zero;

    private Vector3 speed = Vector3.zero;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void FixedUpdate()
    {

    }

    void Update()
    {
        Vector3 accel = Vector3.zero;
        accel += movevalue * (moveForce - linearDampling);
        accel *= Time.deltaTime;


        if(speed.magnitude < maxSpeed)
        {
            speed += accel;
        }

        speed += Physics.gravity;

        controller.Move(speed);

        //speed = Vector3.zero;
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        Vector2 movevector = context.ReadValue<Vector2>();

        movevalue = new Vector3(movevector.x, 0.0f, movevector.y);

        if (movevalue == Vector3.zero)
            return;


        print(movevalue);
    }

}
