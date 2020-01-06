using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject Panel;
    public GameObject Panel1;
    private Color m_oldColor = Color.white;
    // Start is called before the first frame update

    void Start()
    {
        
    }
    
    void OnTriggerEnter(Collider other)
    {
        Renderer render = GetComponent<Renderer>();
        m_oldColor = render.material.color;
        render.material.color = Color.green;
        Panel.gameObject.SetActive(true);

    }
    private void OnTriggerExit(Collider other)
    {
        Renderer render = GetComponent<Renderer>();
        render.material.color = m_oldColor;

        Panel.gameObject.SetActive(false);
        Panel1.gameObject.SetActive(false);
        // Text.SetActive(false);

    }
    public bool IsTrigger
    {
        get
        {
            return Panel.activeInHierarchy;
        }
    }
    // Update is called once per frame
    void Update()
    {

        if (IsTrigger)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                Panel.gameObject.SetActive(false);
                if (Panel.activeInHierarchy == false)
                {
                    Panel1.gameObject.SetActive(true);

                }
               // print("Butonul functioneaza");
            }

        }
        if (Panel1.activeInHierarchy == true)
        {
            if (Input.GetKeyDown(KeyCode.Q))
                Panel1.gameObject.SetActive(false);
        }
    }
}
