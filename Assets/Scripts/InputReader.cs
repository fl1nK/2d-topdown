using System;
using System.Collections;
using System.Collections.Generic;
using Player;
using UnityEngine;

public class InputReader : MonoBehaviour
{

    [SerializeField] private PlayerEntity _playerEntity;
        
    private Vector2 _movement;
    private void Update()
    {
        _movement.x = Input.GetAxisRaw("Horizontal");
        _movement.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        _playerEntity.Move(_movement);
    }
}
