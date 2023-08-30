using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class marches : MonoBehaviour {
    float speed=5f;
    Rigidbody2D rb;
    Vector2 dir;
    private void Start() {
        rb=GetComponent<Rigidbody2D>();
        
    }
    private void Update() {
        dir.x=Input.GetAxisRaw("Horizontal");
         dir.y=Input.GetAxisRaw("Vertical");
         rb.MovePosition(rb.position+dir*speed*Time.fixedDeltaTime);
    }
    
}