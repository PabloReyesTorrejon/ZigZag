using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
     public Text pointsText;
     public Image imagen;
     public void Setup(int score){
        imagen.gameObject.SetActive(true);
        gameObject.SetActive(true);
        pointsText.text = score.ToString() + " PUNTOS";
        
   }
   public void RestartButton(){
       SceneManager.LoadScene("Nivel1");
   }
   public void MenuButton(){
       SceneManager.LoadScene("SampleScene");
   }
}
