using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public Slider oxygenBar;
    public TextMeshProUGUI coinsCollectedText;
    public Player player;
    public AudioSource audioSource;
    public AudioClip coinSound;

    public void setMaxHealth()
    {
        oxygenBar.value = 1;
    }

    public void setHealth(float health)
    {
        oxygenBar.value = health / Player.MaxOxygen;
    }

    public void setCoinsCollected()
    {
        audioSource.PlayOneShot(coinSound);
        coinsCollectedText.text = player.coinsCollected.ToString();
    }
}
