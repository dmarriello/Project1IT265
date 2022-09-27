﻿using Nevelson.Topdown2DPitfall.Assets.Scripts.Utils;
using UnityEngine;

public class Player : MonoBehaviour, IPitfallCheck, IPitfallObject {
    public float speed = 7f;
    private Rigidbody2D rb;
    public bool isMovable = true;
    private Vector2 moveVelocity;
    private SpriteRenderer sr;
    public int fallCount = 0;
    private Transform tfm;
    void Start() {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        tfm = GetComponent<Transform>();
    }

    void Update() {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
        if (!isMovable) {
            MovementInput(Vector2.zero);
            return;
        }
        if (Input.GetAxisRaw("Horizontal") < 0f && !sr.flipX)
        {
            sr.flipX = true;
        }
        if (Input.GetAxisRaw("Horizontal") > 0f && sr.flipX)
        {
            sr.flipX = false;
        }
        Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        MovementInput(input);
        if(tfm.position.x<-9.5f)
        {
            tfm.position = new Vector3(9.5f, tfm.position.y, tfm.position.z);
        }
        if (tfm.position.x > 9.5f)
        {
            tfm.position = new Vector3(-9.5f, tfm.position.y, tfm.position.z);
        }
        if (tfm.position.y > 6f)
        {
            tfm.position = new Vector3(tfm.position.x, -6f, tfm.position.z);
        }
        if (tfm.position.y < -6f)
        {
            tfm.position = new Vector3(tfm.position.x, 6f, tfm.position.z);
        }
    }

    void FixedUpdate() {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }

    private void MovementInput(Vector2 moveInput) {
        moveVelocity = moveInput.normalized * speed;
    }

    public bool PitfallConditionCheck() {
        return true;
    }

    public void PitfallActionsBefore() {
        isMovable = false;
        fallCount++;
    }

    public void PitfallResultingAfter() {
        isMovable = true;
    }
}
