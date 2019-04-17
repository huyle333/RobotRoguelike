using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Handle combat-related responsibilities.
/// </summary>
public class PlayerCombat : MonoBehaviour
{
    private int m_Health;
    private int m_MaxHealth;

    public PlayerCombat(int health)
    {
        m_Health = health;
        m_MaxHealth = health;
    }

    public int Health
    {
        get { return this.m_Health; }
        set { this.m_Health = value; }
    }

    public int MaxHealth
    {
        get { return this.m_MaxHealth; }
        set { this.m_MaxHealth = value; }
    }

    /// <summary>
    /// Takes an integer and subtracts the current health from.
    /// </summary>
    /// <param name="amount"></param>
    public void TakeDamage(int amount)
    {
        m_Health = Mathf.Max(0, Mathf.Max(0, Mathf.Min(m_MaxHealth, m_Health - amount)));
    }
}