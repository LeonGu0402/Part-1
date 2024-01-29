using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement();
    }


    void movement()
    {
        float move = Input.GetAxis("Horizontal");
        float direction = Input.GetAxisRaw("Horizontal");

        transform.Translate(move * speed * Time.fixedDeltaTime, 0, 0);

        if (transform.position.x <= -20.09f)
        {
            transform.localPosition = new Vector3(-20.09f, -4.56f, 0);
        }
        if (transform.position.x >= 20.45f)
        {
            transform.localPosition = new Vector3(20.45f, -4.56f, 0);
        }
        if (direction != 0)
        {
            transform.localScale = new Vector3(direction, 1, 1);
        }
    }
}
