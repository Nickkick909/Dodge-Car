using UnityEngine;

public class MovePlayer : MonoBehaviour {

    public Rigidbody rb;
    public float forwardForce;
    public float sidewayForce;
	
	void FixedUpdate () {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))      //WASD or arrow keys to move player
        {
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("w") || Input.GetKey(KeyCode.UpArrow))      //speed up (to a certain point)
        {
            if(forwardForce<=forwardForce+300)
                forwardForce += 5;
        }
        if (Input.GetKey("s") || Input.GetKey(KeyCode.DownArrow))      //slow down (to a certain point)
        {
            if(forwardForce>=forwardForce-300)
                forwardForce -= 8;
        }

        if (rb.position.y < -1) //fall off edge
        {
            FindObjectOfType<GameManagerScript>().EndGame();
        }
    }
}
