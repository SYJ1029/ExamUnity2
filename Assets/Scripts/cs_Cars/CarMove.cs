using Unity.VisualScripting.InputSystem;
using UnityEngine;
using UnityEngine.InputSystem;

public class CarMove : MonoBehaviour
{

    CharacterController controller;

    public float moveForce;
    public float maxSpeed;
    public float linearDampling;

    Vector3 moveDirection = Vector3.zero;

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
        accel += moveDirection * moveForce * Time.deltaTime;



        if (speed.magnitude < maxSpeed)
        {
            speed += accel;
        }

        speed += -speed.normalized * linearDampling * Time.deltaTime;
        controller.Move(speed);
        controller.Move(Physics.gravity * Time.deltaTime);

        //speed = Vector3.zero;
    }

    public void OnMove2(InputAction.CallbackContext context)
    {
        Vector2 movevector = context.ReadValue<Vector2>();

        moveDirection = new Vector3(movevector.x, 0.0f, movevector.y);

        if (moveDirection == Vector3.zero)
            return;


        print(moveDirection);
    }

    void OnMove(Inputvalue value)
    {

    }

}
