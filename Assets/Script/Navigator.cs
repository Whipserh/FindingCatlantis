using TMPro;
using UnityEngine;

public class Navigator : MonoBehaviour
{
    public AudioSource meow;
    public AudioClip meowF;
    public AudioClip meowG;         //approve
    public AudioClip meowLeft;
    public AudioClip meowRight;     //angry
    public TextMeshProUGUI radioText;
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
            meow.PlayOneShot(meowF, 0.3f);
            radioText.text = "Huh?";
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            meow.Stop();
            meow.PlayOneShot(meowG, 0.6f);
            radioText.text = "Meow~";
        }
        if (Input.GetMouseButton(0))
        {
            meow.Stop();
            meow.PlayOneShot(meowLeft, 2);
            radioText.text = "Hiss!";
        }
        if (Input.GetMouseButton(1))
        {
            meow.Stop();
            meow.PlayOneShot(meowRight, 1);
            radioText.text = "Aoww!";
        }
    }
}
