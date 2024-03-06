using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody rb; 
    public float movementSpeed;
    private Vector2 vector2;
    public GameObject _audioClip;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FixedUpdate()
    {
       
    }

    public void OnMovement(InputAction.CallbackContext value)
    {
        if (value.performed)
        vector2 = value.ReadValue<Vector2>();
        rb.AddForce(new Vector3(vector2.x, 0f, vector2.y) * movementSpeed);
        Debug.Log("Hola");
        //if (Input.GetKeyDown("w"))
        //{

        //    _audioClip.SetActive(true);
        //}
        //if (Input.GetKeyUp("w"))
        //{
        //    _audioClip.SetActive(false);
        //}
    }
    // Update is called once per frame
   
}
