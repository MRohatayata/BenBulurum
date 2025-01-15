using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SesKontrol : MonoBehaviour
{
    private static GameObject instance;
    // Çoklu level var ise oyunucuc en son kaldığı leveli'i playerpref ile sisteme kayıt ederek
    // oyun başlarken kaldığı yerden devam etmesini sağlayabiliriz.
    private void Awake()
    {
        DontDestroyOnLoad(gameObject); // pbjenin sahneler arasında kaybolmamasını sağlar. 
        // sahneler arasında yok olmamasını istediğin objeler var ise böyle yapabilirsin.

        if (instance == null)
            instance = gameObject;
        else
            Destroy(gameObject);

    }
}
