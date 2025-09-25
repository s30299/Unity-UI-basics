using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public Animator animator;
    public Transform graphic;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
        if (horizontalInput < 0) {
            graphic.transform.localRotation = Quaternion.Euler(0, 180, 0);
        } else if (horizontalInput > 0) {
            graphic.transform.localRotation = Quaternion.Euler(0, 0, 0);
        }

        animator.SetFloat("speed", MathF.Abs(horizontalInput));
    }
}
