using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cuentaatras : MonoBehaviour
{
    // Start is called before the first frame update
    private Button boton;
    public Image imagen;
    public Sprite [] numeros;

    void Start()
    {
        boton = GameObject.FindWithTag("botonsalir").GetComponent<Button>();
        boton.onClick.AddListener(Empezar);
    }

    void Empezar(){
        imagen.gameObject.SetActive(true);
        boton.gameObject.SetActive(false);
        StartCoroutine(CuentaAtras());
    }

    IEnumerator CuentaAtras(){
        for(int i = 0; i < numeros.Length; i++){
            imagen.sprite = numeros[i];
            yield return new WaitForSeconds(1);
        }
        SceneManager.LoadScene("Nivel1");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
