using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TangkapBuah : MonoBehaviour
{
    public string nameTag;
    public AudioClip mp3Benar;
    public AudioClip mp3Salah;
    private AudioSource MPBenar;
    private AudioSource MPSalah;
    public Text textScore;

    // Start is called before the first frame update
    void Start()
    {
        MPBenar = gameObject.AddComponent<AudioSource>();
        MPBenar.clip = mp3Benar;

        MPSalah = gameObject.AddComponent<AudioSource>();
        MPSalah.clip = mp3Salah;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals(nameTag))
        {
            Data.score += 10;
            textScore.text = Data.score.ToString();
            Destroy(collision.gameObject);
            MPBenar.Play();
        }
        else
        {
            Data.score -= 5;
            textScore.text = Data.score.ToString();
            Destroy(collision.gameObject);
            MPSalah.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
