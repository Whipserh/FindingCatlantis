using UnityEngine;

public class Navigator : MonoBehaviour
{
    AudioSource meow;
    public AudioClip meowF;
    public AudioClip meowG;
    public AudioClip meowLeft;
    public AudioClip meowRight;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        meow = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            meow.Stop();
            meow.PlayOneShot(meowF, 0.8f);
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            meow.Stop();
            meow.PlayOneShot(meowG, 1);
        }
        if (Input.GetMouseButton(0))
        {
            meow.Stop();
            meow.PlayOneShot(meowLeft, 1);
        }
        if (Input.GetMouseButton(1))
        {
            meow.Stop();
            meow.PlayOneShot(meowRight, 1);
        }
    }
}
