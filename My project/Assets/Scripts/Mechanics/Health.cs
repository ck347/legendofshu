using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHP = 1;
    private int currentHP;

    private void Start()
    {
        currentHP = maxHP;
    }

    public void IncreaseHP()
    {
        currentHP = Mathf.Clamp(currentHP + 1, 0, maxHP);
    }

    public void DecreaseHP()
    {
        currentHP = Mathf.Clamp(currentHP - 1, 0, maxHP);
        if (currentHP == 0)
        {
            //
        }
    }

    public void Revive()
    {
        currentHP = maxHP;
    }
}