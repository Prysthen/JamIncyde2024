using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    public float movementSpeed;
    public Rigidbody rb;
    public Vector2 sensibility;
    public Transform _camera;
    public GameObject _audioClip;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void UpdateMove()
    {
        float hor = Input.GetAxisRaw("Horizontal");
        float ver = Input.GetAxisRaw("Vertical");

        Vector3 velocity = Vector3.zero;
        if (hor != 0 || ver != 0)
        {
            Vector3 direction = (transform.forward * ver + transform.right * hor).normalized;

            velocity.y = rb.velocity.y;
            rb.velocity = direction * movementSpeed;
        }
    }
    private void MouseLook()
    {
        float hor = Input.GetAxis("Mouse X");
        float ver = Input.GetAxis("Mouse Y");
        if (hor != 0)
        {
            transform.Rotate(0, hor * sensibility.x, 0);
        }

        if (ver != 0)
        {
            _camera.transform.Rotate(ver * -sensibility.y, 0, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        UpdateMove();
        MouseLook();
        if (Input.GetKeyDown("d") || (Input.GetKeyDown("s")) || (Input.GetKeyDown("w")) || (Input.GetKeyDown("a")))
        {
            _audioClip.SetActive(true);
        }
        if (Input.GetKeyUp("d") || (Input.GetKeyUp("s")) || (Input.GetKeyUp("w")) || (Input.GetKeyUp("a")))
        {
            _audioClip.SetActive(false);
        }
    }
}
