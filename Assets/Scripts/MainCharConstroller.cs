using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharConstroller : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnLookEvent;
    public event Action OnAttakEvent;

    private float _timeSinceLastAttack = float.MaxValue;

    protected bool IsAttacking { get; set; }

    protected virtual void Update()
    {
        HandleAttackDelay();
    }

    private void HandleAttackDelay()
    {
        if (_timeSinceLastAttack <= 0.2f)
        {
            _timeSinceLastAttack += Time.deltaTime;
        }

        if (IsAttacking && _timeSinceLastAttack > 0.2f)
        {
            _timeSinceLastAttack = 0;
            CallAttackEvent();
        }
    }

    public void CallMoveEvent(Vector2 dirction)
    {
        OnMoveEvent?.Invoke(dirction);
    }

    public void CallLookEvent(Vector2 dirction)
    {
        OnLookEvent?.Invoke(dirction);
    }

    public void CallAttackEvent()
    {
        OnAttakEvent?.Invoke();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    
}
