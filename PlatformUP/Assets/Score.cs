using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text MyscoreText;
    public int ScoreNum;
    // Start is called before the first frame update
    void Start()
    {

        ScoreNum = 0;
        MyscoreText.text = "Score : " + ScoreNum;

    }

    private void OnTriggerEnter2D(Collider2D Coin)
    {

        if(Coin.tag == "CoCoin")
        {
            ScoreNum++;
            Destroy(Coin.gameObject);
            MyscoreText.text = "Score : " + ScoreNum;
        }

    }

}
