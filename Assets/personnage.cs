using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personnage : MonoBehaviour
{
    // variable
    
    private string name="bellange Celestine";
    public string postname="Kiala";
    
    int energy;
    bool vie=true;
    float speed=2.9f;
    string affaire;
    
    // tableau
    int [] rabby={1,2,3};
    string [] inventeur={"camera","ordinateur","blooc note"};

    //api
    Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void FixedUpdate() {
       
    }
    void OnEnable() {
       
    }
    void LateUpdate() {
        
        
    }
    void dialogue(string message){
        Debug.Log(message);

    }
    string address(){
        string commune="gombe";
        return commune;
    }
    void Awake() {
        energy=100;
    }
}
