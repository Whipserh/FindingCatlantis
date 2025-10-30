 

using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public Slider oxygenBar;


    public void setMaxHealth()
    {
        oxygenBar.value = 1;
    }

    /**
     * 
     * */
    public void setHealth(float health)
    {
        oxygenBar.value = health/Player.MaxOxygen;
    }
}
