using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Player acts as a proxy for the interfaces of PlayerCombat and PlayerMovement!
/// </summary>
public class Player : MonoBehaviour
{
    // Single responsibility principle.
    private PlayerCombat m_Combat;
    private PlayerMovement m_Movement;

    public PlayerCombat Combat
    {
        get { return m_Combat; }
    }

    public PlayerMovement Movement
    {
        get { return m_Movement; }
    }

    private void Start()
    {
        m_Combat = this.gameObject.AddComponent<PlayerCombat>();
        m_Movement = this.gameObject.AddComponent<PlayerMovement>();
    }
}
