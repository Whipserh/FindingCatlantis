using UnityEngine;
using UnityEngine.UI;

public class DialogueBubbleTransparency : MonoBehaviour
{
    private Image image;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetDialogueBubbleTransparent()
    {
        Color color = image.color;
        color.a = 0;
        image.color = color;
        Debug.Log("Transparent");
    }

    public void SetDialogueBubbleOpaque()
    {
        Color color = image.color;
        color.a = 1;
        image.color = color;
        Debug.Log("Opaque");
    }
}
