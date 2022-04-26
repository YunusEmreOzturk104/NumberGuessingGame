using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class Oyun : MonoBehaviour
{
    int min ,max=1501,tahmin;
    public TextMeshProUGUI tahminTxt,bitisTxt;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        OyunaBasla();
    }
    public void OyunaBasla()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            tahmin = Random.Range(1, 1501);
            min = tahmin;
            tahminTxt.text = tahmin.ToString();
        }
    }
    public void SkorArttir()
    {
        min = tahmin;
        sonrakitahmin();
    }
    public void azalt()
    {
        max = tahmin;
        sonrakitahmin();
    }
    public void sonrakitahmin()
    {
        tahmin = Random.Range(min, max);
        tahminTxt.text = tahmin.ToString();
    }
    public void Dogru()
    {
        Time.timeScale = 0;
        Destroy(tahminTxt);
        bitisTxt.text = "Oyun Bitti/Ana ekrana dönmek için space'e bas";
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Main");
        }
    }
}
