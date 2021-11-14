using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    private BuildManager _buildManager;

    private void Start()
    {
        _buildManager = BuildManager.instance;
    }

    public void PurchaseStandardTurret()
    {
        print("standard turret selected");
        _buildManager.SetTurretToBuild(_buildManager.standardTurretPrefab);
    }
    
    public void PurchaseMissileLauncher()
    {
        print("missile launcher selected");
        _buildManager.SetTurretToBuild(_buildManager.missileLauncherPrefab);
    }
}
