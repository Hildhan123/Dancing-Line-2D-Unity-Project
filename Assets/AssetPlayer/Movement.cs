using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    public static float moveSpeed = 5f; //mengatur kecepatan object player
    public Rigidbody2D rb; //deklarasi Rigidbody2D
    Vector2 movement; //deklarasi movement
    public int arah; //deklarasi arah 
    private GameObject[] m_Cubes;
    public float Timer;
    public Text Debug;
    
    
    void Update()
    {
        if (arah==0)
        {
            movement.x = 0f;
            movement.y = 1f;
            //bergerah ke kanan 45 derajat
        }

        if (arah==1)
        {
            movement.x = -1f;
            movement.y = 0f;
            //bergerak ke kiri 45 derajat
        }

        if(moveSpeed != 0)
        {
            Timer += Time.deltaTime;
            //Timer ketika jalan
        }
    }
    
    void FixedUpdate()
    {
        m_Cubes = GameObject.FindGameObjectsWithTag("Merah");
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        //deklarasi agar object bergerak
        Debug.text = Timer.ToString("0.00");

    if (Input.GetKey("z"))
        {
        arah=1;
        for (int i = 0; i < m_Cubes.Length; i++)
            {
            Color newColor = new Color( Random.value, Random.value, Random.value, 1.0f );
            m_Cubes[i].GetComponent<Renderer>().material.color = newColor;
            }
        }

    if (Input.GetKey("x"))
        {
        arah=0;
        for (int i = 0; i < m_Cubes.Length; i++)
            {
            Color newColor = new Color( Random.value, Random.value, Random.value, 1.0f );
            m_Cubes[i].GetComponent<Renderer>().material.color = newColor;
            }   
        }
         
    }
}