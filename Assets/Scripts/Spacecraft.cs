using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public partial class Spacecraft : MonoBehaviour, IPlayer
{
    public float Health { get; set; }
    private Rigidbody rigidbody;

    public IInput playerInput;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.useGravity = false;
        
        playerInput = new PlayerInput();
    }

    public void ApplyDamage(float Damage, float attenuationFactor)
    {
        Health -= Damage * attenuationFactor;
    }

    public void OnGameOver()
    {
        Debug.Log("Game Over");
    }

    public void Update()
    {
        float vertical = playerInput.Vertical;
        float speed = 50f;

        rigidbody.AddForce(0, 0, vertical * speed * Time.deltaTime);
    }
}