using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class marche : MonoBehaviour
{
    // Start is called before the first frame update
    public float movementSpeed = 5f;
    private Rigidbody2D rb;
    
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Calculer la direction de déplacement en combinant les mouvements horizontaux et verticaux
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        // Appliquer la vitesse de déplacement au rigidbody du personnage
        rb.velocity = movement * movementSpeed; 
    }
}
