using UnityEngine;

public class playerCollision : MonoBehaviour {

    public MovePlayer movement;

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;   // Disable the players movement.
            FindObjectOfType<GameManagerScript>().EndGame();
        }
    }
}
