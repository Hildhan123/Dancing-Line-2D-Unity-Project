using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public GameObject player;
    private GameObject[] m_Cubes;
    private GameObject[] bayis;
    private GameObject[] playgrounds;
    private GameObject[] school;
    private GameObject[] school2;
    private GameObject[] birumuda;
    private GameObject[] hitam;
    private GameObject[] putih;
    public GameObject popup1;
    public GameObject popup2;
    public GameObject popup3;
    float T;
    float T1;
    float T2;
    float Tu;
    int a;

    
    public void Update()
    {
        
        T = FindObjectOfType<Movement>().Timer;
        float Ti = (int)T;
        int tX = (int)player.transform.position.x;
        int tY = (int)player.transform.position.y;

        bayis = GameObject.FindGameObjectsWithTag("Bayi");
        Tu += Time.deltaTime;
        
        if(a != 12)
        {
            if(Tu >= 0.30f)
            {
                bayis[a].GetComponent<Renderer>().material.color = Color.black;
                a++;
                Tu = 0f;
            }
        }
        

        playgrounds = GameObject.FindGameObjectsWithTag("Playground");

            if(tX < -21)
            {
                playgrounds[0].GetComponent<Renderer>().material.color = Color.black;
            }
            if(tX < -23)
            {
                playgrounds[1].GetComponent<Renderer>().material.color = Color.black;
            }
            if(tX < -25)
            {
                playgrounds[2].GetComponent<Renderer>().material.color = Color.black;
            }

        school = GameObject.FindGameObjectsWithTag("School");

        if(tY > 50 )
        {
            school[0].GetComponent<Renderer>().material.color = Color.black;
        }
        if(tY > 52 )
        {
            school[1].GetComponent<Renderer>().material.color = Color.black;
        }
        if(tY > 54 )
        {
            school[2].GetComponent<Renderer>().material.color = Color.black;
        }
        if(T >= 20f )
        {
            school[3].GetComponent<Renderer>().material.color = Color.black;
        }
        if(T >= 20.5f )
        {
            school[4].GetComponent<Renderer>().material.color = Color.black;
        }
        if(T >= 21f )
        {
            school[5].GetComponent<Renderer>().material.color = Color.black;
        }
        if(T >= 21.5f )
        {
            school[6].GetComponent<Renderer>().material.color = Color.black;
        }
        if(T >= 22f )
        {
            school[7].GetComponent<Renderer>().material.color = Color.black;
        }

            if(Input.GetKey("x"))
            {
                school[9].GetComponent<Renderer>().material.color = Color.black;
                school[11].GetComponent<Renderer>().material.color = Color.black;
                school[8].GetComponent<Renderer>().material.color = Color.white;
                school[10].GetComponent<Renderer>().material.color = Color.white;
            }
            else if(Input.GetKey("z"))
            {
                school[8].GetComponent<Renderer>().material.color = Color.black;
                school[10].GetComponent<Renderer>().material.color = Color.black;
                school[9].GetComponent<Renderer>().material.color = Color.white;
                school[11].GetComponent<Renderer>().material.color = Color.white;
            }
        

        school2 = GameObject.FindGameObjectsWithTag("School2");

        if(tX <= -60)
            {
                school2[0].GetComponent<Renderer>().material.color = Color.black;
            }
        if(tX <= -62)
            {
                school2[1].GetComponent<Renderer>().material.color = Color.black;
            }
        if(tX <= -64)
            {
                school2[2].GetComponent<Renderer>().material.color = Color.black;
            }

        hitam = GameObject.FindGameObjectsWithTag("Hitam");
        putih = GameObject.FindGameObjectsWithTag("Putih");
        T1 += Time.deltaTime;
        
        if(T1 >= 0.50f)
        {
            foreach(GameObject hitamm in hitam)
            {
                hitamm.GetComponent<Renderer>().material.color = Color.black;
            }
            foreach(GameObject putihh in putih)
            {
                putihh.GetComponent<Renderer>().material.color = Color.white;
            }
        }
        if(T1 >= 1f)
        {
            foreach(GameObject putihh in putih)
            {
                putihh.GetComponent<Renderer>().material.color = Color.black;
            }
            foreach(GameObject hitamm in hitam)
            {
                hitamm.GetComponent<Renderer>().material.color = Color.white;
            }

            T1 = 0f;
        }

        m_Cubes = GameObject.FindGameObjectsWithTag("AssetsLain"); 

        foreach(GameObject lampu in m_Cubes)
        {
            if(player.transform.position.y > 90f)
            {
                lampu.GetComponent<Renderer>().material.color = Color.red;         
            }

            if(player.transform.position.y > 92f)
            {
                lampu.GetComponent<Renderer>().material.color = Color.yellow;       
            }

            if(player.transform.position.y > 94f)
            {        
                lampu.GetComponent<Renderer>().material.color = Color.green;     
            }

            if(player.transform.position.y >= 110f)
            {
                lampu.GetComponent<Renderer>().material.color = Color.white;
            }
            if(player.transform.position.y >= 130f)
            {
                lampu.GetComponent<Renderer>().material.color = Color.red;
            }
            if(player.transform.position.y >= 132f)
            {
                lampu.GetComponent<Renderer>().material.color = Color.yellow;
            }
            if(player.transform.position.y >= 134f)
            {
                lampu.GetComponent<Renderer>().material.color = Color.green;
            }
            if(player.transform.position.y >= 161f)
            {
                lampu.GetComponent<Renderer>().material.color = Color.white;
            }
            if(player.transform.position.x <= -147f)
            {
                lampu.GetComponent<Renderer>().material.color = Color.red;
            }
            if(player.transform.position.x <= -150f)
            {
                lampu.GetComponent<Renderer>().material.color = Color.yellow;
            }
            if(player.transform.position.x <= -153f)
            {
                lampu.GetComponent<Renderer>().material.color = Color.green;
            }
        }
        Color BGcolor = Camera.main.backgroundColor;
        birumuda = GameObject.FindGameObjectsWithTag("birumuda");
        T2 += Time.deltaTime;

        if(T2 >= 2)
        {
        foreach(GameObject birumudas in birumuda)
        {
            birumudas.GetComponent<Renderer>().material.color = BGcolor;
           
        }  
        T2 = 0;            
        }
        if(T2 >= 1)
        {
        foreach(GameObject birumudas in birumuda)
        { 
        birumudas.GetComponent<Renderer>().material.color = Color.white;
        }
        }


        if(T < 70f)
        {
            popup1.SetActive(false);
            popup2.SetActive(false);
            popup3.SetActive(false);
        }

        if(T >= 73.50f)
        {
            popup1.SetActive(true);
        }
        if(T >= 75.50f)
        {
            popup2.SetActive(true);
        }
        if(T >= 78.50f)
        {
            popup3.SetActive(true);
        } 
    }

}
