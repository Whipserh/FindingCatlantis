using UnityEngine;

public class ArrowScript : MonoBehaviour
{
    public Transform catlantis;
    private Vector3 v3;
    public Player player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (player.movement.x == -1)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (player.movement.x == 1)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        v3 = catlantis.position - transform.position;
        float angle = Mathf.Atan2(v3.y, v3.x) * Mathf.Rad2Deg;
        transform.eulerAngles = new Vector3(0, 0, angle);
    }
}
