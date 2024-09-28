using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb2D;


   [SerializeField] float Running;
    [SerializeField] float Jumping;
    [SerializeField] bool IsInAir;
    private float HorizontalMovement;
    private float VerticalMovement;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        HorizontalMovement = Input.GetAxisRaw("Horizontal");
        VerticalMovement = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        if (HorizontalMovement > 0.1f || HorizontalMovement < -0.1f)
        {
            rb2D.AddForce(new Vector2(HorizontalMovement * Running, 0f), ForceMode2D.Impulse);

        }
        if (!IsInAir && VerticalMovement > 0.1f)
        {
            rb2D.AddForce(new Vector2(0f, VerticalMovement * Jumping), ForceMode2D.Impulse);

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            IsInAir = false;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            IsInAir = true;
        }
    }
}
