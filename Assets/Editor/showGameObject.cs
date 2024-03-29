﻿using UnityEngine;
using System.Collections;
using UnityEditor;

public class SetGameObjectActive : Editor

 {


    [MenuItem("Tools/通用工具/切换物体显隐状态 &q")]
    public static void SetObjActive()
    {
        GameObject[] selectObjs = Selection.gameObjects;
        int objCtn = selectObjs.Length;
        for (int i = 0; i < objCtn; i++)
        {
            bool isAcitve = selectObjs[i].activeSelf;
            selectObjs[i].SetActive(!isAcitve);
        }
    }
}
