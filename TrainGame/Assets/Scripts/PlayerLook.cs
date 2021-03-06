using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public Camera cam;
    private float xRotaition = 0f;

    public float xSensitivity = 30f;
    public float ySensitivity = 30f;

    public void ProcessLook(Vector2 input)
    {
        float mouseX = input.x;
        float mouseY = input.y;

        xRotaition -= (mouseY * Time.deltaTime) * ySensitivity;
        xRotaition = Mathf.Clamp(xRotaition, -80f, 80f);

        cam.transform.localRotation = Quaternion.Euler(xRotaition,0,0);

        transform.Rotate(Vector3.up * (mouseX * Time.deltaTime) * xSensitivity);
    }
    
}
