using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField][Min(1)] private int maxHealth;

    private int currentHealth;

    public int MaxHealth => maxHealth;
    public int CurrentHealth => currentHealth;
    public bool IsAlive => currentHealth > 0;
    public event Action<int> OnHealthChanged;

    private void Awake()
    {
        currentHealth = maxHealth;
    }

    public void Heal(int hp)
    {
        currentHealth += hp;
        OnHealthChanged?.Invoke(currentHealth);
    }

    public void TakeDamage(int dmg)
    {
        currentHealth = Mathf.Max(currentHealth - dmg, 0);
        OnHealthChanged?.Invoke(currentHealth);
    }
}
