using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public interaccion_area interaccion_areas;
    public UIManager UIManagers;
    public float timer=60;
   
    
       void awake (){
     interaccion_areas= FindObjectOfType<interaccion_area>();
       }
       void Update()
    {
        if (interaccion_areas.sigue_en_juego_lose == true && interaccion_areas.sigue_en_juego_win == true){
        timer -= Time.deltaTime;
        }
    if (timer < 0){
        Time.timeScale = 0;
        interaccion_areas.sigue_en_juego_lose = false;
    }
    if (interaccion_areas.sigue_en_juego_lose == false || interaccion_areas.sigue_en_juego_win == false){
         Time.timeScale = 0;

    if (Input.GetKeyUp(KeyCode.R)) {
         Time.timeScale = 1;
      SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
       }}
    
  
}  public void restart(){
    
        
        Time.timeScale = 1;
        interaccion_areas.sigue_en_juego_lose = true;
        interaccion_areas.sigue_en_juego_win = true;
        UIManagers.score = 0;
         interaccion_areas.pantalla_lose.SetActive(false);
         interaccion_areas.pantalla_win.SetActive(false);
          for (int i = 0; i < interaccion_areas.objeto.Length; i++) {
            interaccion_areas.objeto[i].SetActive(true);
    }
    player.transform.position = new Vector3(23f, 2f, 0f);
        timer=60;
    }
}
