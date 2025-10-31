using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogueBubbleTransparency : MonoBehaviour
{
    private Image image;
    public TextMeshProUGUI radioText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        image = GetComponent<Image>();
    }

    public void SetDialogueBubbleTransparent()
    {
        Color imageColor = image.color;
        imageColor.a = 0;
        image.color = imageColor;
        Color textColor = radioText.color;
        textColor.a = 0;
        radioText.color = textColor;
        //Debug.Log("Transparent");
    }

    public void SetDialogueBubbleOpaque()
    {
        Color imageColor = image.color;
        imageColor.a = 1;
        image.color = imageColor;
        Color textColor = radioText.color;
        textColor.a = 1;
        radioText.color = textColor;
        //Debug.Log("Opaque");
    }
}
