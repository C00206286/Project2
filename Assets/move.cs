using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class move : MonoBehaviour
{

    public float movementSpeed = 5.0f;
    public float clockwise = 100.0f;
    public float counterClockwise = -100.0f;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * Time.deltaTime * movementSpeed;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * Time.deltaTime * movementSpeed;
        }
        //else if (Input.GetKey(KeyCode.A))
        //{
        //    rigidbody.position += Vector3.left * Time.deltaTime * movementSpeed;
        //}
        //else if (Input.GetKey(KeyCode.D))
        //{
        //    rigidbody.position += Vector3.right * Time.deltaTime * movementSpeed;
        //}

        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, Time.deltaTime * clockwise, 0);
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0, Time.deltaTime * counterClockwise, 0);
        }
    }
}
