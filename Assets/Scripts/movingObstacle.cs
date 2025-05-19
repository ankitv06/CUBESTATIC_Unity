using UnityEngine;

public class movingObstacle : MonoBehaviour
{
    public float speed = 3f;
    public float horizontalRange = 0f;
    public float verticalRange = 0f;

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        if (horizontalRange != 0) transform.position = startPos + Vector3.right * Mathf.Sin(Time.time * speed) * horizontalRange;
        if (verticalRange != 0) transform.position = startPos + Vector3.up * Mathf.Sin(Time.time * speed) * verticalRange;
    }
}
