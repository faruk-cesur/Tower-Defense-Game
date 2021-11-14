using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;
    public GameObject standardTurretPrefab;
    public GameObject anotherTurretPrefab;
    
    private GameObject _turretToBuild;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("MORE THAN ONE");
            return;
        }

        instance = this;
    }
    
    public GameObject GetTurretToBuild()
    {
        return _turretToBuild;
    }

    public void SetTurretToBuild(GameObject turret)
    {
        _turretToBuild = turret;
    }
}