using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public Rigidbody2D rb;

    public float moveSpeed = 5f;
    public Animator an;

    Vector2 movment;

    // Update is called once per frame
    void Update()
    {
        movment.x = Input.GetAxisRaw("Horizontal");
        movment.y = Input.GetAxisRaw("Vertical");

        an.SetFloat("Horizontal", movment.x);
        an.SetFloat("Vertical", movment.y);
        an.SetFloat("Speed", movment.sqrMagnitude);
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movment * moveSpeed * Time.fixedDeltaTime);
    }


}
