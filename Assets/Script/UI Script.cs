using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public Player player;
    public Image oxygenLevel;
    public float oxygenWidth;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        oxygenWidth = Mathf.Lerp(0, 300, player.oxygen / 100);
        oxygenLevel.rectTransform.sizeDelta = new Vector2(oxygenWidth, 50);
    }
}
