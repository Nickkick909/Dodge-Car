using UnityEngine;


public class Finish : MonoBehaviour {

    public Collider player;

    private void OnTriggerEnter(Collider player)
    {
        FindObjectOfType<GameManagerScript>().NextScene();
    }

}
