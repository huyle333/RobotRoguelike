using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Handle movement-related responsibilities.
/// </summary>
public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float runSpeed = 8.0f;

    private Rigidbody myRigidbody;
    private Animator myAnimator;

    private bool facingRight;

    private void Start()
    {
        myRigidbody = this.GetComponent<Rigidbody>();
        myAnimator = this.GetComponent<Animator>();

        facingRight = true;
    }

    /// <summary>
    /// Physics updates.
    /// </summary>
    private void FixedUpdate()
    {
        // Input.
        float move = Input.GetAxis("Horizontal");

        // Animation.
        myAnimator.SetFloat("Speed", Mathf.Abs(move));

        // Moving the player.
        myRigidbody.velocity = new Vector3(move * runSpeed,
            myRigidbody.velocity.y,
            0);

        // Flipping the player.
        if ((move > 0 && !facingRight) ||
            (move < 0 && facingRight))
        {
            Flip();
        }
    }

    /// <summary>
    /// Flip the player by reversing the localScale.z.
    /// </summary>
    private void Flip()
    {
        facingRight = !facingRight;
        Vector3 currentLocalScale = this.transform.localScale;
        currentLocalScale.z *= -1;
        this.transform.localScale = currentLocalScale;
    }
}
