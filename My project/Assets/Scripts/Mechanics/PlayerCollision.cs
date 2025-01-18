using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private Health playerHealth;

    private void Start()
    {
        playerHealth = GetComponent<Health>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            playerHealth.DecreaseHP();
        }
    }
}