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
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     txt_time.text="tiempo: "+(GameManagers.timer).ToString();
    }
    public void addpointandupdatedcoreUI(){
     score ++;
      txt_score.text="puntaje: "+(score).ToString();
    }
}
