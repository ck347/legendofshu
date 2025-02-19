using UnityEngine;
using System.Collections;

public class FallingPlatform : MonoBehaviour
{
    Vector2 startPos;

    void Start()
    {
    // set the position
        startPos = transform.position;
    }  
    
    private float fallDelay = 1f;

    private float respawnDelay = 3f;

    [SerializeField] private Rigidbody2D rb;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(Fall());
        }
    }

    private IEnumerator Fall()
    {
        yield return new WaitForSeconds(fallDelay);
        rb.bodyType = RigidbodyType2D.Dynamic;
        // Destroy(gameObject, destroyDelay);
        yield return new WaitForSeconds(respawnDelay);
        transform.position = startPos;
        rb.bodyType = RigidbodyType2D.Static;

        
    }

}
