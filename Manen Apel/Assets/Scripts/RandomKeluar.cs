using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomKeluar : MonoBehaviour
{
    public Transform[] titikKeluar;
    public GameObject[] buahKeluar;
    public float mini, maxi;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TungguDanSpawn());
    }

    IEnumerator TungguDanSpawn()
    {
        yield return new WaitForSeconds(Random.Range(mini, maxi));
        int Keluar = Random.Range(0, titikKeluar.Length);
        Instantiate(buahKeluar[Random.Range(0, buahKeluar.Length)], titikKeluar[Keluar].position, titikKeluar[Keluar].rotation);
        StartCoroutine(TungguDanSpawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
