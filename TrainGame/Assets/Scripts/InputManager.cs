using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private PlayerInput playerInput;
    private PlayerInput.PlayerActions player;
    private PlayerController move;
     void Awake() 
    {
        
        playerInput = new PlayerInput();
        player = playerInput.Player;
       move = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        move.MovePlayer(player.Movement.ReadValue<Vector2>());
    }

    private void OnEnable() {
        player.Enable();
    }

    private void OnDisable() {
        player.Disable();
        
    }
}
