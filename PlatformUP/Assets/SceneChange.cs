using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    [SerializeField] private string sceneName;
    [SerializeField] private Score s;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player") 
        {
            int uno = s.ScoreNum;
            Debug.Log(s);
            if(uno == 4) { 
               SceneManager.LoadScene(sceneName); 
            }
            
        }
    }
}
