using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// PlayerBehaviour.cs
/// Lucas Gurney
/// 101313633
/// November 19, 2022
/// Used for the players behaviour to move around
/// Made the player behaviour
/// </summary>

public class PlayerBehaviour : MonoBehaviour
{
    [Header("Movement Properties")]
    public float horizontalForce;
    public float horizontalSpeed;
    public float verticalForce;
    public float airFactor;
    public Transform groundPoint;
    public float groundRadius;
    public LayerMask groundLayerMask;
    public bool isGrounded;

    private Rigidbody2D rigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        var hit = Physics2D.OverlapCircle(groundPoint.position, groundRadius, groundLayerMask);
        isGrounded = hit;
        Move();
        Jump();
    }

    private void Move()
    {
        var x = Input.GetAxisRaw("Horizontal");

        if (x != 0.0f)
        {
            Flip(x);

            x = (x > 0.0) ? 1.0f : -1.0f;

            rigidbody2D.AddForce(Vector2.right * x * horizontalForce * ((isGrounded) ? 1.0f : airFactor));

            rigidbody2D.velocity = Vector2.ClampMagnitude(rigidbody2D.velocity, horizontalSpeed);

            //var clampedXVelocity = Mathf.Clamp(rigidbody2D.velocity.x, -horizontalSpeed, horizontalSpeed);

            //rigidbody2D.velocity = new Vector2(clampedXVelocity, rigidbody2D.velocity.x);
        }
    }

    private void Jump()
    {
        var y = Input.GetAxis("Jump");

        if((isGrounded) && (y > 0.0f))
        {
            rigidbody2D.AddForce(Vector2.up * verticalForce, ForceMode2D.Impulse);
        }
    }

    public void Flip(float x)
    {
        if(x != 0.0f)
        {
            transform.localScale = new Vector3((x > 0.0f) ? -1.0f : 1.0f, 1.0f, 1.0f);
        }
    }

    public void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(groundPoint.position, groundRadius);
    }
}
