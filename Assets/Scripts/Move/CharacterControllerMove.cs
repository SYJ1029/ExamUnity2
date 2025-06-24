using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterControllerMove : MonoBehaviour, IMovementStrategy
{
    CharacterController controller;

    public float moveForce;
    public float maxSpeed;
    public float linearDampling;

    public float angularSpeed;

    Vector3 moveDirection = Vector3.zero;
    Vector3 rotateDirection = Vector3.zero;

    private Vector3 speed = Vector3.zero;


    void Awake()
    {
        controller = GetComponent<CharacterController>();
    }


    void Start()
    {
    }

    void FixedUpdate()
    {

    }

    void Update()
    {

    }



    public void Move(Vector3 direction, Vector2 mouseInput)
    {
        Vector3 accel = Vector3.zero;
        moveDirection = direction;
        moveDirection.x = 0.0f;

        float angle = 0.0f;
        rotateDirection = direction;
        rotateDirection.z = 0.0f;

      
        accel += controller.transform.forward * moveDirection.z * moveForce * Time.deltaTime;

        angle = rotateDirection.x * angularSpeed;


        if (speed.magnitude < maxSpeed)
        {
            speed += accel;
        }

        speed += speed.normalized * linearDampling * Time.deltaTime;
        controller.Move(speed);
        controller.Move(Physics.gravity * Time.deltaTime);


        transform.Rotate(controller.transform.up, angle);

        speed = Vector3.zero;
        moveDirection = Vector3.zero;
    }

}
