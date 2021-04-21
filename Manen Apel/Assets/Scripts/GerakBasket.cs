using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerakBasket : MonoBehaviour
{
    public float speed;
    public string axis;
    public float btskiri;
    public float btskanan;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float gerak = Input.GetAxis(axis) * speed * Time.deltaTime;
        float nextPos = gerak + transform.position.x ;
        if (nextPos > btskiri)
        {
            gerak = 0;
        }
        if (nextPos < btskanan)
        {
            gerak = 0;
        } 
        transform.Translate(gerak,0, 0);
        
    }
}
