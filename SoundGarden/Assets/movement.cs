using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody body;
    public float forcemultiplier = 200f;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("right"))
        {
            body.AddForce(0,0, forcemultiplier * Time.deltaTime);
        }
        if (Input.GetKey("left"))
        {
            body.AddForce(0,0,-forcemultiplier * Time.deltaTime);
        }
        if (Input.GetKey("down"))
        {
            body.AddForce(forcemultiplier * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("up"))
        {
            body.AddForce(-forcemultiplier * Time.deltaTime, 0, 0);
        }
    }
}
