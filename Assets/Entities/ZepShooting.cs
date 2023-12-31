using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ZepShooting : MonoBehaviour
{
    private MainCharConstroller _controller;

    [SerializeField] private Transform projectileSpawnPosition;
    private Vector2 _aimDirection = Vector2.right;

    public GameObject testPrefab;

    private void Awake()
    {
        _controller = GetComponent<MainCharConstroller>();
    }
    // Start is called before the first frame update
    void Start()
    {
        _controller.OnAttakEvent += OnShoot;
        _controller.OnLookEvent += OnAim;
    }


    private void OnAim(Vector2 newAimDirection)
    {
        _aimDirection = newAimDirection;
    }
    private void OnShoot()
    {
        CreateProjectile();
    }

    private void CreateProjectile()
    {
        Instantiate(testPrefab, projectileSpawnPosition.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
