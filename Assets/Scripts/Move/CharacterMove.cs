using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterMove : MonoBehaviour, IMovementStrategy
{

    CharacterController controller;

    public float moveForce;
    public float maxSpeed;
    public float linearDampling;

    public float mouseSensitivity = 3f;

    private float currentYaw = 0f;

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


        accel += transform.forward * moveDirection.z * moveForce * Time.deltaTime;
        accel += transform.right * moveDirection.x * moveForce * Time.deltaTime;


        if (speed.magnitude < maxSpeed)
        {
            speed += accel;
        }

        speed += speed.normalized * linearDampling * Time.deltaTime;
        controller.Move(speed);
        controller.Move(Physics.gravity * Time.deltaTime);


        currentYaw += mouseInput.x * mouseSensitivity * Time.deltaTime;
        transform.rotation = Quaternion.Euler(0f, currentYaw, 0f);


        speed = Vector3.zero;
        moveDirection = Vector3.zero;
    }



}