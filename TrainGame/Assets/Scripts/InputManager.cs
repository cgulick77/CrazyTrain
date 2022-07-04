using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private PlayerInput playerInput;
    private PlayerInput.PlayerActions player;
    private PlayerController move;
    private PlayerLook look;
     void Awake() 
    {
        
        playerInput = new PlayerInput();
        player = playerInput.Player;
        move = GetComponent<PlayerController>();
        look = GetComponent<PlayerLook>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        move.MovePlayer(player.Movement.ReadValue<Vector2>());
        
    }

     void LateUpdate() 
    {
        look.ProcessLook(player.Look.ReadValue<Vector2>());
    }

    private void OnEnable() {
        player.Enable();
    }

    private void OnDisable() {
        player.Disable();
        
    }
}
