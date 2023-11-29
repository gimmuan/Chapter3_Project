using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZepMovement : MonoBehaviour
{

    private MainCharConstroller _controller;

    private Vector2 _movementDiretion = Vector2.zero;
    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _controller = GetComponent<MainCharConstroller>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    


    // Start is called before the first frame update
    private void Start()
    {
        _controller.OnMoveEvent += Move;
    }

    public void FixedUpdate()
    {
        ApplyMovement(_movementDiretion);
    }

    private void Move(Vector2 direction)
    {
        _movementDiretion = direction;
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * 5f;

        _rigidbody.velocity = direction;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
