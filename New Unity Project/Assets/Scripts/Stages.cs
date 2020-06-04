using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stages : MonoBehaviour
{
    List<GameObject> stage1List = new List<GameObject>();
    List<GameObject> stage2List = new List<GameObject>();
    List<GameObject> stage3List = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        stage1List.AddRange(GameObject.FindGameObjectsWithTag("Stage_1"));
        stage2List.AddRange(GameObject.FindGameObjectsWithTag("Stage_2"));
        stage3List.AddRange(GameObject.FindGameObjectsWithTag("Stage_3"));
        stage1();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
            stage1();
        if (Input.GetKeyDown(KeyCode.X))
            stage2();
        if (Input.GetKeyDown(KeyCode.C))
            stage3();
    }

    

    void stage1 ()
    {
        foreach (GameObject item in stage1List)
        {
            item.SetActive(true);
        }
        foreach (GameObject item in stage2List)
        {
            item.SetActive(false);
        }
        
    }
    void stage2()
    {
        foreach (GameObject item in stage2List)
        {
            item.SetActive(true);
        }
        foreach (GameObject item in stage1List)
        {
            item.SetActive(false);
        }
        foreach (GameObject item in stage3List)
        {
            item.SetActive(false);
        }
    }
    void stage3()
    {
        foreach (GameObject item in stage3List)
        {
            item.SetActive(true);
        }
        foreach (GameObject item in stage2List)
        {
            item.SetActive(true);
        }
        foreach (GameObject item in stage1List)
        {
            item.SetActive(false);
        }
    }
}
