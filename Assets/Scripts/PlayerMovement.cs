using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb; // reference to the Rigid Body component of the inspector

    public float forwardspeed = 1000f;
    public float sidewaysSpeed = 300f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // void Start()
    // {
    //     Debug.Log("Hello World!");  // To display messages, testing if script runs, debugging
    //     //rb.useGravity = false;      // to turn off gravity in the rigid body component
    //     rb.AddForce(0, 50, 200);    // to apply force on the object
    // }

    // Update is called once per frame
    void FixedUpdate()  //FixedUpdate, instead of Update whever you're chanigng velocity, adding force or doing physics.
    {
        rb.AddForce(0, 0, forwardspeed * Time.deltaTime); // Time.deltaTime is the amount of time a computer takes to generate the next frame. it helps maintain the same amount of fource on different PCs beacuse frame rate at every PC can be different.

        if (Input.GetKey(KeyCode.A)) rb.AddForce(-sidewaysSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        if (Input.GetKey(KeyCode.D)) rb.AddForce(sidewaysSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        if (rb.position.y < -1f) FindAnyObjectByType<GameManager>().GameOver();
    }
}
