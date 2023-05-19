using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateController : MonoBehaviour
{

    private void Awake()
    {
        continueGameTime();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }




    public void pauseGameTime() 
    {
        Time.timeScale = 0;
    }
    public void continueGameTime() 
    {
        Time.timeScale = 1;
    }
}


