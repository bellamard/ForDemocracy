using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class exercices : MonoBehaviour {
    int age=0;
    private void Start() {
        monAge(2011);
        Debug.Log(age);
    }
    
    void monAge(int annee){
       age= 2023-annee;
    }
}