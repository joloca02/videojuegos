using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
        List<string> Nombres = new List<string> {"Scorpion", "Kano", "Sonya", "Johnny Cage", "Sub-zero"};
        List<string> Categorias = new List<string> { "Ninja", "Mercenario", "Teniente", "Actor", "Ninja"};
    // Start is called before the first frame update
    void Start()
    {

        initFighters();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void initFighters()
    {
        GameObject[] e;
        e = GameObject.FindGameObjectsWithTag("Fighter");
        for (int i = 0; i < e.Length; i++)
        {
            Fighter f = e[i].GetComponent<Fighter>();
            f.Name = Nombres[i];
            f.Category = Categorias[i];
            f.Health = 100;
        }
    }
}
