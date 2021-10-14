using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovemant : MonoBehaviour
{
    public float MoveSpeed = 120f;

    public Rigidbody2D RigBody;

    public int health;

    public Camera cam;

    Vector2 movement;
    Vector2 MousePos;

    private void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y= Input.GetAxisRaw("Vertical");

        MousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        if(health==0)
        {
            Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {
        RigBody.MovePosition(RigBody.position + movement * MoveSpeed*Time.fixedDeltaTime);

        Vector2 SightDir = MousePos - RigBody.position;
        float angle = Mathf.Atan2(SightDir.y, SightDir.x)* Mathf.Rad2Deg-90f;
        RigBody.rotation = angle;
    }
}
