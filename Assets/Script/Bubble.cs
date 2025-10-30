using UnityEngine;

public class Bubble : MonoBehaviour
{
    public float repairValue = 10;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //we are hitting the sprite so we have to get its parent
        GameObject collidedObject = collision.gameObject;
        

        if (collidedObject.CompareTag("Player"))
        {
                collidedObject.GetComponentInParent<Player>().addOxygen(repairValue);
            Destroy(gameObject);
        }
    }
}
