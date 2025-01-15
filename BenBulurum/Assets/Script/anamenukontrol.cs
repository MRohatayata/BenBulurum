using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class anamenukontrol : MonoBehaviour
{
    
    public GameObject CikisPanel;
    private void Start()
    {
        if (Time.timeScale==0)
             Time.timeScale = 1;
    }
    public void OyundanCik()
    {
        CikisPanel.SetActive(true);      

    }
    public void Cevap(string cevap)
    {

        if (cevap=="evet")
        {
            Application.Quit();

        }else
        {
            CikisPanel.SetActive(false);

        }

        

    }


    public void OyunaBasla()
    {
        SceneManager.LoadScene(1);
     // SceneManager.LoadScene(PlayerPrefs.GetInt("KaldigiBolum")); // kaldığı devam etmesini sağlıcam
    }
}
