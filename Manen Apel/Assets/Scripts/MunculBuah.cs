using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MunculBuah : MonoBehaviour
{
    public float jeda = 5f;
    float timer;
    float waktu;
    public GameObject[] obyekBuah;
    public Transform[] titikKeluar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > jeda)
        {
            int random = Random.Range(0, obyekBuah.Length);
            Instantiate(obyekBuah[random], transform.position, transform.rotation);
            timer = 0;
        }

        waktu += Time.deltaTime;
        if (waktu > jeda)
        {
            int ran = Random.Range(0, titikKeluar.Length);
            Instantiate(titikKeluar[ran], transform.position, transform.rotation);
            waktu = 0;
        }
    }
}
