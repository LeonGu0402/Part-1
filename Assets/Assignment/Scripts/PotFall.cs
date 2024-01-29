using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotFall : MonoBehaviour
{
    public Rigidbody2D pot;
    public float force = 5000f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 push = -transform.right * force * Time.deltaTime;
        pot.AddForce(push);
    }
}
