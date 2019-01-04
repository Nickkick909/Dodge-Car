using UnityEngine;

public class ObstacleMove : MonoBehaviour {

    public float delay;     
    public Vector3 start;   //keep these numbers small (.1 or less)
    public Vector3 end;

    bool toEnd = false;
    bool toStart = true;

    private void FixedUpdate()
    {
        if(toStart)
            Invoke("MoveToEnd", delay * Time.deltaTime);
        if(toEnd)
            Invoke("MoveToStart", delay * Time.deltaTime);
    }

    public void MoveToEnd()
    {
        transform.Translate(end.x, end.y, end.z);
        toEnd = true;
        toStart = false;
    }
    public void MoveToStart()
    {
        transform.Translate(start.x, start.y, start.z);
        toEnd = false;
        toStart = true;
    }
}
