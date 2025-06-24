using UnityEngine;

public class goBullet : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Rigidbody rb;

    float MaxTime = 30.0f;
    float decord_time = 0.0f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(decord_time > MaxTime)
        {
            Destroy(gameObject);
        }

        decord_time += Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {


        Destroy(gameObject);
        if (other.gameObject.tag == "Enemy")
        {
            other.gameObject.SetActive(false);
        }
    }

 
}
