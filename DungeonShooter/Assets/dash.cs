using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 6f; // Player movement speed
    public float dashSpeed = 12f; // Player dash speed
    public float dashDuration = 0.5f; // Duration of the dash in seconds
    public float dashCooldown = 2f; // Cooldown time for the dash in seconds

    private CharacterController controller;
    private Vector3 moveDirection;
    private float dashTime;
    private float dashCooldownTime;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        // Get player input
        float horizontal= Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Calculate movement direction based on input
        moveDirection = new Vector3(horizontal, vertical,0f).normalized;

        // Move the player
        controller.Move(moveDirection * speed * Time.deltaTime);

        // Check if the player wants to dash
        if (Input.GetKeyDown(KeyCode.Space) && dashCooldownTime <= 0f)
        {
            // Start the dash
            dashTime = dashDuration;
            dashCooldownTime = dashCooldown;
        }

        // Check if the player is currently dashing
        if (dashTime > 0f)
        {
            // Move the player in the dash direction
            controller.Move(moveDirection * dashSpeed * Time.deltaTime);

            // Decrease the dash time
            dashTime -= Time.deltaTime;
        }

        // Decrease the dash cooldown time
        if (dashCooldownTime > 0f)
        {
            dashCooldownTime -= Time.deltaTime;
        }
    }
}