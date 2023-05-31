using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public float velocity = 2;
    private Rigidbody2D rb;
    
    public ControladorEscena controladorEscena;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * velocity;
        }

    
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        controladorEscena.Perdiste();
    }
}
