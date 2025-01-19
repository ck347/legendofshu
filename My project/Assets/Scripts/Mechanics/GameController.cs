// starting spawn point for player

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameController : MonoBehaviour
{
    Vector2 startPos;
    SpriteRenderer spriteRenderer;
    Rigidbody2D playerRb;

    private void Awake() {
        spriteRenderer = GetComponent<SpriteRenderer>();
        playerRb = GetComponent<Rigidbody2D>();
    }

    void Start() {
        startPos = transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy")) {
            Die();
        }
    }

    void Die() {
        StartCoroutine(Respawn(0.5f));
    }

    IEnumerator Respawn(float duration) {
        playerRb.linearVelocity = new Vector2(0, 0);
        transform.localScale = new Vector3(0, 0, 0);
        spriteRenderer.enabled = false;
        yield return new WaitForSeconds(duration);
        transform.position = startPos;
        transform.localScale = new Vector3(1, 1, 1);
        spriteRenderer.enabled = true;
    }
}
