using UnityEngine;
using System.Collections;

public class CameraMover : MonoBehaviour
{
    public Transform target;
    public float speed;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (target.position.y > transform.position.y)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x,target.position.y, transform.position.z), Time.deltaTime*speed);
        }
    }
}
