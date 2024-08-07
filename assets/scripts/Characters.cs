using UnityEngine;

public class Character : MonoBehaviour
{
    public string characterName;
    public float moveSpeed;

    protected virtual void Move()
    {
        // Logica de movimiento
    }

    protected virtual void UseAbility()
    {
        // Logica de habilidad
    }
}
