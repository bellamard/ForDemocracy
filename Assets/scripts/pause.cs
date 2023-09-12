using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject pauseUI;
    public static bool gameIsPause= false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(gameIsPause){
                resumed();
                
            }else{
                paused();
            }
        }
    }

    void paused(){
        Time.timeScale=0;
        pauseUI.SetActive(true);
        gameIsPause=true;       

    }

    void resumed(){
        Time.timeScale=1;
        pauseUI.SetActive(false);
        gameIsPause=false;
    }
}
