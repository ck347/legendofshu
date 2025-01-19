using UnityEngine;
using System.Collections;



public class FallingSpike : MonoBehaviour
{
    Vector2 startPos;
    private float fallDelay = 1f;

    private float respawnDelay = 3f;

        [SerializeField] private Rigidbody2D rb;



    void Start()
    {
    // set the position
        startPos = transform.position;
        int x = 0;
        while(x != 10)
        {
        StartCoroutine(Fall());
        x +=1;
        }
    }      

    // void Awake()    
    // {
    //     transform.Translate(0f, -0.1f, 0f);
        
    //     yield return new WaitForSeconds(respawnDelay);
        
    //     StartCoroutine(Respawn());
        
    // }

    // IEnumerator Respawn()
    // {
    //     transform.position = startPos;
    // }



    private IEnumerator Fall()
    {
        yield return new WaitForSeconds(fallDelay);
        rb.bodyType = RigidbodyType2D.Dynamic;
        // Destroy(gameObject, destroyDelay);
        yield return new WaitForSeconds(respawnDelay);
        rb.bodyType = RigidbodyType2D.Kinematic;
        transform.position = startPos;
        
    }
}

