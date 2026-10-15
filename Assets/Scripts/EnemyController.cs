using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject player;
    public float speed;
    public float distanceFollow;

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
        
    }

    void checkPlayerDistance()
    {
        /*
        Este método checkea si el jugador está a menor distancia de la de
        distanceFollow, en tal caso seguirá al jugador.
        */
    }

    public void death()
    {
        /*
        Este método inicia la animación de death del enemigo
        */
    }

    public void destroyEnemy()
    {
        /*
        Este método destruye el objeto del enemigo
        */
    }


}
