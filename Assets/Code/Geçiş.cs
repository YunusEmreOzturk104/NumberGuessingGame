using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Geçiş : MonoBehaviour
{
    public TextMeshProUGUI tekrar;
    public void DigerSahne()
    {
        SceneManager.LoadScene("oyun");
    }
    public void TekrarOynat()
    {
        tekrar.text = "Sen Bilirsin/ Oynamak istersen Ebutonuna bas";
    }
    
}
