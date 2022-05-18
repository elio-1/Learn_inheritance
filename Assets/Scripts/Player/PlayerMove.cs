using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody _rb;
    [SerializeField] float _moveSpeed = 10f;
    

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 direction = horizontalInput * transform.right + verticalInput * transform.forward;
        Vector3 move = direction.normalized * _moveSpeed * Time.deltaTime;

        _rb.MovePosition(transform.position + move);
    }
}
