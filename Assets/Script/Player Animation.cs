using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public Animator animator;
    public Player player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Speed", player.GetComponent<Rigidbody2D>().linearVelocity.magnitude);
    }
}
