using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walking : MonoBehaviour
{

    private Rigidbody2D body;
    public float horizontal;
    public GameObject effect;
    private Animator animator;
    private SpriteRenderer spriteRenderer;

    private bool jumping = false;

    public float runSpeed = 5f;
    public int level;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        if(transform.position.y < -50){
            GameManager.Instance.RestartLevel(level);
        }

        horizontal = Input.GetAxisRaw("Horizontal");
        animator.SetFloat("horizontal", horizontal);
        if (horizontal < 0)
        {
            spriteRenderer.flipX = true;
        }
        else
        {
            spriteRenderer.flipX = false;
        }
        if (Input.GetKeyDown(KeyCode.Space) && !jumping)
        {
            print("Space!");
            body.AddForce(new Vector2(0, 400));
            jumping = true;
            animator.SetBool("jumping", jumping);
        }
    }

    void FixedUpdate()
    {

        body.velocity = new Vector2(horizontal * runSpeed, body.velocity.y);

    }

    // void OnCollisionEnter2D(Collision2D collision2D)
    // {
    //     jumping = false;
    //     animator.SetBool("jumping", jumping);
    //     if (collision2D.gameObject.CompareTag("Animal"))
    //     {   
    //         GameManager.Instance.IncScore(1);  
    //         Destroy(collision2D.gameObject); 
    //         Instantiate(effect);
            
    //     }
        
    // }
}