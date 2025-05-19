using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    public PlayerMovement movement;
    void OnCollisionEnter(Collision collisionInfo)  // detects if collision occurs
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false; // stop the referenced movement if collision w obstacle happens
            FindAnyObjectByType<GameManager>().GameOver();
        }
    }
}
