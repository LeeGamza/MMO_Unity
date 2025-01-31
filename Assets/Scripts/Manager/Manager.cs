﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : MonoBehaviour
{
    public static Managers s_instance;

    public static Managers Instance
    {
        get { Init(); return s_instance;}
    }

    public InputManager _input = new InputManager();
    public static InputManager Input
    {
        get { return Instance._input; }
    }
    void Start()
    {
        Init();
    }

    // Update is called once per frame
    void Update()
    {
        _input.OnUpdate();
    }

    static void Init()
    {
        if (s_instance == null)
        {
            GameObject go = GameObject.Find("@Managers");
            if (go == null)
            {
                go = new GameObject { name = "@Managers" };
                go.AddComponent<Managers>();
            }
            DontDestroyOnLoad(go);
            
            s_instance = go.GetComponent<Managers>();    
        }
        
    }
}
