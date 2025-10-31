using UnityEngine;

public class CatlantisCollider : MonoBehaviour
{
    public Navigator navigator;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        navigator.VictorySound();
        Debug.Log("You find Catlantis!!!");
    }
}
