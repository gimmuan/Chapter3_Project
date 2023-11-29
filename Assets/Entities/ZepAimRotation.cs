using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private SpriteRenderer armRenderer;
    [SerializeField] private Transform armPivot;

    [SerializeField] private SpriteRenderer characterRenderer;

    private MainCharConstroller _controller;

    private void Awake()
    {
        _controller = GetComponent<MainCharConstroller>();
    }
    // Start is called before the first frame update
    void Start()
    {
        _controller.OnLookEvent += OnAim;
    }

    public void OnAim(Vector2 newAimDirection)
    {
        RotateArm(newAimDirection);
    }

    public void RotateArm(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        armRenderer.flipX = Mathf.Abs(rotZ) > 90f;
        characterRenderer.flipX = armRenderer.flipX;
        armPivot.rotation = Quaternion.Euler(0,0,rotZ);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
