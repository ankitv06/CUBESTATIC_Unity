using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    void OnTriggerEnter(Collider other) //used to detect when another Collider enters a Trigger Collider attached to the GameObject this script is on.
    {
        if (other.name == "Player")
        {
            gameManager.LevelCompleted();
        }

    }
}
