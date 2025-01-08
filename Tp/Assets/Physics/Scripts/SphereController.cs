using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{
    [SerializeField] private int speed = 10;
    [SerializeField] private int jumpForce = 100;
    private Rigidbody sphereRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        sphereRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        InputManagerControl();
    }
    public void InputManagerControl()
    {
        sphereRigidbody.AddForce(Vector3.forward * speed * Input.GetAxis("Vertical"));
        sphereRigidbody.AddForce(Vector3.right * speed * Input.GetAxis("Horizontal"));
        if (Input.GetButtonDown("Jump"))
        {
            sphereRigidbody.AddForce(Vector3.up * jumpForce);
        }
    }
    public void KeyBoardControl()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            sphereRigidbody.AddForce(Vector3.forward * speed);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            sphereRigidbody.AddForce(-Vector3.forward * speed);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            sphereRigidbody.AddForce(Vector3.right * speed);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            sphereRigidbody.AddForce(-Vector3.right * speed);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            sphereRigidbody.AddForce(Vector3.up * jumpForce);
        }
    }
}
