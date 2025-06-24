using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterControllerMove : MonoBehaviour, IMovementStrategy
{
    CharacterController controller;

    public float moveForce;
    public float maxSpeed;
    public float linearDampling;

    Vector3 moveDirection = Vector3.zero;

    private Vector3 speed = Vector3.zero;


    void Awake()
    {
        controller = GetComponent<CharacterController>();
    }


    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void FixedUpdate()
    {

    }

    void Update()
    {

    }



    public void Move(Vector3 direction)
    {
        Vector3 accel = Vector3.zero;
        moveDirection = direction;

      
        accel += moveDirection * moveForce * Time.deltaTime;



        if (speed.magnitude < maxSpeed)
        {
            speed += accel;
        }

        speed += -speed.normalized * linearDampling * Time.deltaTime;
        controller.Move(speed);
        controller.Move(Physics.gravity * Time.deltaTime);


        speed = Vector3.zero;
        moveDirection = Vector3.zero;
    }

}
