using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField]
    Vector3 force;

    [SerializeField]
    KeyCode keyPositive;

    [SerializeField]
    KeyCode keyNegative;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(keyPositive))
        GetComponent<Rigidbody>().velocity += force;

        if (Input.GetKey(keyNegative))
        GetComponent<Rigidbody>().velocity -= force;

        if (transform.position.y < -30.0f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    void OnTriggerEnter(Collider collide)
    {
         if (collide.tag == "Obstacle")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
