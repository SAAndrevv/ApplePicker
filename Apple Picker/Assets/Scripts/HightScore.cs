using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HightScore : MonoBehaviour
{
    public static int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Awake() {
        if (PlayerPrefs.HasKey("HightScore")){
            score = PlayerPrefs.GetInt("HightScore");
        }
        PlayerPrefs.SetInt("HightScore", score);
    }

    // Update is called once per frame
    void Update()
    {
        Text gt = this.GetComponent<Text>();
        gt.text = "Hight Score: " + score;
        if (score > PlayerPrefs.GetInt("HightScore")){
            PlayerPrefs.SetInt("HightScore", score);
        }
    }
}
