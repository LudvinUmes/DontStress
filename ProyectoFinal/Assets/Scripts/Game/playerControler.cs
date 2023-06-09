using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControler : MonoBehaviour
{
    //private float horizontalInput, verticalInput;
    //public float speed = 10.0f;
    //private Rigidbody playerRb;


    //// Start is called before the first frame update
    //void Start()
    //{
    //    playerRb = GetComponent<Rigidbody>();
    //}

    //// FixedUpdate is called once per fixed frame rate
    //void FixedUpdate()
    //{
    //    horizontalInput = -Input.GetAxis("Horizontal");
    //    verticalInput = -Input.GetAxis("Vertical");
    //    Vector3 newPosition = playerRb.position + new Vector3(horizontalInput, 0, verticalInput) * speed * Time.fixedDeltaTime;
    //    playerRb.MovePosition(newPosition);
    //}


    //// Update is called once per frame

    ////private void OnCollisionEnter(Collision collision)
    ////{


    ////}   
    public float speed = 5.0f;
    public float turnSpeed;
    public float horizontalInput;
    public float verticalInput;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
    }
}
