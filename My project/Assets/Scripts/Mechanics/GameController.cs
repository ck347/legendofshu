// starting spawn point for player

using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{
    Vector2 startPos;
    SpriteRenderer spriteRenderer;

    private void Awake() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start() {
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
        spriteRenderer.enabled = false;
        yield return new WaitForSeconds(duration);
        transform.position = startPos;
        spriteRenderer.enabled = true;
    }
}
