using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonRockBehaviour : MonoBehaviour
{
    public GameObject moonRock;
    public GameObject neutralPointPosition;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        

    }

    

    // Update is called once per frame
    void Update()
    {
        if (moonRock.transform.position.y <= neutralPointPosition.transform.position.y)
        {
            rb.AddForce(new Vector2(0, 15));
        }
        else if (moonRock.transform.position.y >= neutralPointPosition.transform.position.y)
        {
            rb.AddForce(new Vector2(0, -4));
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(moonRock);
        
    }
}
