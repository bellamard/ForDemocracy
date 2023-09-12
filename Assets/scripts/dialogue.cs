using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialogue : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] 
    string title;
    [SerializeField]
    [TextArea(3,10)]
    string [] sentence;
    [SerializeField]    GameObject dial;
    [SerializeField] Text titlePnj, dialoguePnj;
    bool etat= false;
    int countSentence=0;

    void Update() {
        if(etat){
            
            if(Input.GetKeyDown(KeyCode.E)){
                
            if(countSentence<sentence.Length){
                Debug.Log(" combien de"+countSentence);
                StartCoroutine(interationDialogue(sentence[countSentence]));
                countSentence++;
                }
            }
   

        }
    }

    

    void OnTriggerEnter2D(Collider2D other) {
        
        if(other.tag=="Player"){
            dial.SetActive(true);
            titlePnj.text=title;           
            etat=true;
        }
        
    }

    void OnTriggerExit2D(Collider2D other) {
        if(other.tag=="Player"){
            StartCoroutine(desactive());            
            etat=false;
            countSentence=0;
        }
    }
    IEnumerator desactive(){
        yield return new WaitForSeconds(1f);
        dial.SetActive(false);
    }    
     

     IEnumerator interationDialogue(string sentence){
       dialoguePnj.text="";
        foreach (var item in sentence.ToCharArray())
        {
            
             yield return new WaitForSeconds(1f/10);
             dialoguePnj.text+=item;
        }
     }
}
