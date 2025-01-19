using UnityEngine;

public class FallingSpike : MonoBehaviour
{
    Vector2 startPos;

    

    void Start()
    {
    // set the position
        startPos = transform.position;
    }      

    
    void Awake()
    {
        if (transform.position.y >= 4.53)
        {
            transform.Translate(0f, -0.1f, 0f);
        }
        else
        {
            Respawn();
        }
    }

    void Respawn()
    {
        transform.position = startPos;
    }
}
