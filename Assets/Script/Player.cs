using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Rendering;

public class Player : MonoBehaviour
{
    [SerializeField] private float acceleration = 1, MaxSPEED;
    private Vector2 movement;
    private KeyCode LEFT, RIGHT, UP, DOWN;

    public int health = 100;
    public float oxygen = 100;
    [SerializeField] private float oxyegenRatePS = 1;


    Rigidbody2D rb;
    void Start()
    {
        LEFT = KeyCode.A; RIGHT = KeyCode.D; UP = KeyCode.W; DOWN = KeyCode.S;

        movement = Vector2.zero;
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        #region controls
        //vertical controls
        if (Input.GetKey(UP))
        {
            movement.y = 1;
        }else if (Input.GetKey(DOWN))
        {
            movement.y = -1;
        }else
        {
            movement.y = 0;
        }


        //horizontal controls
        if (Input.GetKey(LEFT))
        {
            movement.x = -1;
        } else if (Input.GetKey(RIGHT))
        {
            movement.x = 1;
        }
        else
        {
            movement.x = 0;
        }
        #endregion

        //decrease oxygen over time
        oxygen -= oxyegenRatePS * Time.deltaTime;

    }

    private void FixedUpdate()
    {
        Debug.Log(acceleration * Time.fixedDeltaTime * movement.normalized);

        //add added speed to velcocity
        rb.linearVelocity += acceleration * Time.fixedDeltaTime * movement.normalized;

        //controlling speed over pools
        if (rb.linearVelocity.magnitude < 0.01) rb.linearVelocity = Vector2.zero;
        rb.linearVelocity = rb.linearVelocity.normalized  * Mathf.Clamp(rb.linearVelocity.magnitude, 0, MaxSPEED);
    }



}
