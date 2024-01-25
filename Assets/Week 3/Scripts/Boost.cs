using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boost : MonoBehaviour
{
    public GameObject car;
    public float boostSpeed = 30000f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Vector2 force = -transform.right * boostSpeed * Time.deltaTime;
        collision.attachedRigidbody.AddForce(force);
        Debug.Log("Punch it Chewie!");
    }
}
