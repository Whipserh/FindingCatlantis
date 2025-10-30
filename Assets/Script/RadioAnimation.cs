using UnityEngine;

public class RadioAnimation : MonoBehaviour
{
    public Animator animator;
    public Navigator navigator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (navigator.meow.isPlaying)
        {
            animator.SetBool("Sound", true);
        }
        else
        {
            animator.SetBool("Sound", false);
        }
    }
}
