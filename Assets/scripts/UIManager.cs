using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UIManager : MonoBehaviour
{
      public GameManager GameManagers;
      public int score;
    public TextMeshProUGUI txt_score;
    public TextMeshProUGUI txt_time;
    // Start is called before the first frame update
    void Awake()
    {
        GameManagers = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
     txt_time.text="tiempo: "+(GameManagers.timer).ToString();
     txt_score.text="Score: "+(score).ToString();
    }
    public void addpointandupdatedcoreUI(){
     score ++;
      if (score == 1){
        score = 0;
        GameManagers.interaccion_areas.sigue_en_juego_win = false;
      
    }

}}
