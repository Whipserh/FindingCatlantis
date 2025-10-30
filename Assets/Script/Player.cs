using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class Player : MonoBehaviour
{
    [SerializeField] private float acceleration = 1, MaxSPEED;
    public Vector2 movement;
    private KeyCode LEFT, RIGHT, UP, DOWN;

    //variables for managing oxygen
    private float oxygen = 100;
    public static float MaxOxygen = 100;
    [SerializeField] private float oxyegenRatePS = 1;
    private Vector2 previousTrackingSpeed;

    //variables for player taking damage
    [SerializeField] private int MaxDamageTaken = 10;
    [SerializeField] private int MinDamageTaken = 5;
    [SerializeField] private float minSpeedDamage = 4;

    private UIScript playerUI;
    Rigidbody2D rb;

    //Coins collected
    public int coinsCollected;

    void Start()
    {
        //initallizing variables
        LEFT = KeyCode.LeftArrow; RIGHT = KeyCode.RightArrow; UP = KeyCode.UpArrow; DOWN = KeyCode.DownArrow;
        movement = Vector2.zero;
        rb = GetComponent<Rigidbody2D>();
        playerUI = GetComponent<UIScript>();
    }


    void Update()
    {
        #region controls
        //vertical controls
        if (Input.GetKey(UP))
        {
            movement.y = 1;
        }
        else if (Input.GetKey(DOWN))
        {
            movement.y = -1;
        }
        else
        {
            movement.y = 0;
        }


        //horizontal controls
        if (Input.GetKey(LEFT))
        {
            transform.localScale = new Vector3(1, 1, 1);
            movement.x = -1;
        }
        else if (Input.GetKey(RIGHT))
        {
            transform.localScale = new Vector3(-1, 1, 1);
            movement.x = 1;
        }
        else
        {
            movement.x = 0;
        }
        #endregion

        //decrease oxygen over time
        oxygen -= oxyegenRatePS * Time.deltaTime;
        //clamp oxygen
        oxygen = Mathf.Clamp(oxygen, 0, MaxOxygen);
        //update the UI
        playerUI.setHealth(oxygen);
    }

    private void FixedUpdate()
    {
        //Debug.Log(acceleration * Time.fixedDeltaTime * movement.normalized);

        //add added speed to velcocity
        rb.linearVelocity += acceleration * Time.fixedDeltaTime * movement.normalized;

        //controlling speed over pools
        if (rb.linearVelocity.magnitude < 0.01) rb.linearVelocity = Vector2.zero;
        rb.linearVelocity = rb.linearVelocity.normalized * Mathf.Clamp(rb.linearVelocity.magnitude, 0, MaxSPEED);

        //stays at the bottom to keep previous speed
        previousTrackingSpeed = rb.linearVelocity;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {

        GameObject collidedObject = collision.gameObject;

        if (collidedObject.tag == "Ground")//if we hit the ground
        {
            float currentVelocity = previousTrackingSpeed.magnitude;
            if (currentVelocity < minSpeedDamage) return;
            oxygen -= Mathf.FloorToInt(damageTaken(currentVelocity));

        }
    }

    public float damageTaken(float speed)
    {
        //(1-t)a + tb = y [a, b]
        float x = (speed - minSpeedDamage) / Mathf.Abs(minSpeedDamage - MaxSPEED);

        return (1 - x) * MinDamageTaken + x * MaxDamageTaken;
    }

    public float getOxyegn()
    {
        return oxygen;
    }

    public void addOxygen(float addedO2)
    {
        oxygen += addedO2;
    }

    public void addCoinsCollected()
    {
        coinsCollected++;
    }
}
