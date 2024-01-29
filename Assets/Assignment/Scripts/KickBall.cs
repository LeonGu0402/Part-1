using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class KickBall : MonoBehaviour
{
    public float horizontalForce = 20000f;
    public float verticalForce = 10000f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Approach ball to kick it");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Vector2 horiz = transform.right * horizontalForce * Time.deltaTime;
        Vector2 verti = transform.up * verticalForce * Time.deltaTime;
        collision.attachedRigidbody.AddForce(horiz);
        collision.attachedRigidbody.AddForce(verti);
    }
}