using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    public CheckGround checkGround;
    private bool isGrounded;

    private SpriteRenderer _spriteRenderer;
    private Rigidbody2D _rigidBody;
    private Animator _animator;
    // Start is called before the first frame update
    void Start()
    {
       _rigidBody = GetComponent<Rigidbody2D>();
       _animator = GetComponent<Animator>(); 

    } 

    // Update is called once per frame
    void Update()
    {
        checkMove();
        CheckJump();
    }

    void FixedUpdate()
    {
     
    }

    private void checkMove()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position = new Vector3(-1, 1);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position = new Vector3(1, -1);
        } 
    }
    
    
    private void CheckJump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            _rigidBody.velocity = new Vector2(_rigidBody.velocity.x, jumpForce);
        }
    }

    public void impulse(float impulse)
    {
        /*
        Este método se ejecutará cuando el jugador salte sobre 
        la cabeza del enemigo impulsado al jugador hacia arriba.
        */

    }



}