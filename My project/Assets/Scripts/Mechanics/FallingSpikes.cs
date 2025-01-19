using UnityEngine;
using System.Collections;

public class FallingSpikes
{
    private float fallDelay = 1f;
    private float destroyDelay = 2f;

    [SerializeField] private Rigidbody2D rb;

    void Start()
    {

    }

    void Update()
    {
        if (transform.position.y >= -4.53)
        {
            transform.Translate(0f, -0.25f, 0f);
        }
        else
        {
            this.gameObject.transform(2f,2f,0f);
        }
    }

    private IEnumerator Fall()
    {
        yield return new WaitForSeconds(fallDelay);
        rb.bodyType = RigidbodyType2D.Dynamic;
        Destroy(gameObject, destroyDelay);
    }


}
