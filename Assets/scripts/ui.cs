using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ui : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] 
    int time;
    [SerializeField]
    Text MyTime;

    
    void Start()
    {
        
       StartCoroutine(Minuterie());
    }
    IEnumerator Minuterie(){
       
        while(time>0){
            yield return new WaitForSeconds(1f);
            time--;
            MyTime.text="ngonga:"+time;
        }
        GameObject.Find("player").GetComponent<marchePersonnage>().GameOver();
        
    }

    // Update is called once per frame

}
