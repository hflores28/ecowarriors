using UnityEngine;

public class PlayerController : Character
{
    private void Update()
    {
        Move();
        if (Input.GetKeyDown(KeyCode.E)) UseAbility();
    }

    protected override void Move()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(moveX, moveY, 0);
        transform.position += move * moveSpeed * Time.deltaTime;
    }

    protected override void UseAbility()
    {
        // Logica habilidad de jugador
    }
}
