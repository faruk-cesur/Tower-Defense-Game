using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;
    public GameObject standartTurretPrefab;
    
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

    private void Start()
    {
        _turretToBuild = standartTurretPrefab;
    }

    public GameObject GetTurretToBuild()
    {
        return _turretToBuild;
    }
}