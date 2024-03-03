using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public Text pointsText;
    public Text timeText;

    public void Setup(int score, float time){
        gameObject.SetActive(true);
        pointsText.text = "PUNTUACION: " + score.ToString() + " PUNTOS";
        timeText.text = "TIEMPO: " + time.ToString("F2") + "s";
    }
   public void RestartButton(){
       SceneManager.LoadScene("Nivel1");
   }
   public void MenuButton(){
       SceneManager.LoadScene("SampleScene");
   }
}
